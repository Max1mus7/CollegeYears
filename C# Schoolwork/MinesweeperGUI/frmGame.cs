using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Minesweeper;

namespace MinesweeperGUI
{
    public partial class frmGame : Form
    {
        //btnGrid stores a 2d array of buttons
        public Button[,] btnGrid;
        //Instantiates a new board with a default size of 8
        Board board = new Board(8);
        //Provides a timer for the user to see how much time has elapsed
        Stopwatch swGameTime = new Stopwatch();
        //Holds the parent form for later interactions
        frmGamePrep PrepForm { get; set; }
        //keeps track of the size of the board given by the user
        int GameSize { get; set; }

        /// <summary>
        /// Constructor, takes the original form as a parameter in order to pass to the results form, 
        /// takes gridSize to specify the size of the Board and of the button grid shown.
        /// </summary>
        /// <param name="prepForm"></param>
        /// <param name="gridSize"></param>
        public frmGame(frmGamePrep prepForm, int gridSize)
        {
            InitializeComponent();
            PrepForm = prepForm;
            GameSize = gridSize;
            //Create and set up a new board object
            board = new Board(gridSize);
            board.SetupLiveNeighbors(gridSize / 2);
            board.CalculateLiveNeighbors();

            //btnGrid contains the button controls 
            btnGrid = new Button[gridSize, gridSize];

            //populate the grid with buttons
            PopulateGrid(gridSize);
            
            //start the stopwatch and timer
            swGameTime.Start();
            tmrGameTimer.Start();
            //grant the timer a new tick event
            tmrGameTimer.Tick += TmrGameTimer_Tick;
        }

        /// <summary>
        /// Updates the label showing the amount of time the game has lasted every tick of the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrGameTimer_Tick(object sender, EventArgs e)
        {
            lblGameTime.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", swGameTime.Elapsed);
       }


        /// <summary>
        /// Populate the Board
        /// </summary>
        /// <param name="boardGridSize"></param>
        public void PopulateGrid(int boardGridSize)
        {
            //Calculate the width of each button using available space
            int buttonSize = pnlButtons.Width / boardGridSize;

            //Make the panel square
            pnlButtons.Height = pnlButtons.Width;

            //Dynamically create new button objects and place these into the panel
            for (int row = 0; row < boardGridSize; row++)
            {
                for (int col = 0; col < boardGridSize; col++)
                {
                    btnGrid[row, col] = new Button();
                    //Define the width and height of each button
                    btnGrid[row, col].Width = buttonSize;
                    btnGrid[row, col].Height = buttonSize;

                    //Place the button on the panel
                    pnlButtons.Controls.Add(btnGrid[row, col]);

                    //gives each button a tag
                    btnGrid[row, col].Tag = row + "," + col;

                    //Locate the button where it needs to live
                    btnGrid[row, col].Location = new Point(buttonSize * col, buttonSize * row);

                    //give each button a click listener
                    btnGrid[row, col].MouseUp += FrmGame_MouseUp;
                    
                }
            }
        }

        /// <summary>
        /// Reveals the buttons on the grid as a loss state and disables the grid on defeat
        /// </summary>
        private void RevealGridLoss()
        {
            swGameTime.Stop();
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    //bombs show up as *
                    if (board.Grid[i, j].Live)
                    {
                        btnGrid[i, j].BackgroundImage = Image.FromFile(@"..\Bomb.png");
                        btnGrid[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    //non-bombs show up with their number of liveNeighbors
                    else
                    {
                        btnGrid[i, j].Text = "" + board.Grid[i, j].LiveNeighbors;
                    }
                    //disables the grid to prevent further play
                    btnGrid[i, j].Enabled = false;
                }
            }
            string message = ("You Lost.");
            int score = 0;
            frmResult frmResult = new frmResult(PrepForm, this, message, GameSize, score, swGameTime.Elapsed);
            frmResult.ShowDialog();
        }
        /// <summary>
        /// Reveals the board as a win state and disables the grid on victory
        /// </summary>
        private void RevealGridWin()
        {
            swGameTime.Stop();
            string gameTime = string.Format("{0:hh\\:mm\\:ss\\:ff}", swGameTime.Elapsed);
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    //bombs show up as *
                    if (board.Grid[i, j].Live)
                    {
                        btnGrid[i, j].BackgroundImage = Image.FromFile(@"..\Flag.png");
                        btnGrid[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    //non-bombs show up with their number of liveNeighbors
                    else
                    {
                        btnGrid[i, j].Text = "" + board.Grid[i, j].LiveNeighbors;
                    }
                    //disables the grid to prevent further play
                    btnGrid[i, j].Enabled = false;
                }
            }
            string message = ("You win!\n It took you " + gameTime.Substring(0, 8) + " to complete the game!\n Would you like to play again?");
            int score;
            if(GameSize < 16)
            {
                score = 50000 - (int)swGameTime.ElapsedMilliseconds;
            }
            else if (GameSize < 25)
            {
                score = 750000 - (int)swGameTime.ElapsedMilliseconds;
            }
            else
            {
                score = 50000000 - (int)swGameTime.ElapsedMilliseconds;
            }
            frmResult frmResult = new frmResult(PrepForm, this, message, GameSize, score, swGameTime.Elapsed);
            frmResult.ShowDialog();
        }

        /// <summary>
        /// A click event for each button in the grid to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGame_MouseUp(object sender, MouseEventArgs me)
        {
            //Specifies which button is being chosen
            Button b = (Button)sender;
            string[] location = b.Tag.ToString().Split(',');
            int row = int.Parse(location[0]);
            int col = int.Parse(location[1]);
            

            //Put a flag on a square if the user right clicks
            if (me.Button == System.Windows.Forms.MouseButtons.Right && btnGrid[row,col].BackgroundImage == null)
            {
                if (!board.Grid[row, col].Visited)
                {
                    btnGrid[row, col].BackgroundImage = Image.FromFile(@"..\Flag.png");
                    btnGrid[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            //Removes the flag if the button already has a flag on it
            else if(me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                btnGrid[row, col].BackgroundImage = null;
            }
            //Plays the game if the user left clicks
            else
            {
                Object s = btnGrid[row, col].BackgroundImage;
                if (s != null)
                {

                }
                else
                {
                    board.Grid[row, col].Visited = true;

                    if (!board.Grid[row, col].Live)
                    {
                        board.RevealSafeNeighbors(row, col);
                        for (int i = 0; i < board.Size; i++)
                        {
                            for (int j = 0; j < board.Size; j++)
                            {
                                if (board.Grid[i, j].Visited)
                                {
                                    btnGrid[i, j].Text = "" + board.Grid[i, j].LiveNeighbors;
                                    btnGrid[i, j].BackgroundImage = null;
                                }
                            }
                        }
                    }
                    //Checks to see if the game has ended
                    string game = board.CheckGUIGameEnded(row, col);
                    //If the game is lost, reveal the board as a loss state
                    if (game.Equals("loss"))
                    {
                        RevealGridLoss();
                    }
                    //If the game is won, reveal the board as a win state
                    else if (game.Equals("win"))
                    {
                        RevealGridWin();
                    }
                }
            }
        }

        /// <summary>
        /// Resets the board and button grid so the user can play again
        /// </summary>
        public void ResetBoard()
        {
            board = new Board(GameSize);
            board.SetupLiveNeighbors(GameSize / 2);
            board.CalculateLiveNeighbors();
            for(int i = 0; i < GameSize; i++)
            {
                for(int j = 0; j < GameSize; j++)
                {
                    btnGrid[i, j].Enabled = true;
                    btnGrid[i, j].Text = "";
                    btnGrid[i, j].BackgroundImage = null;
                }
            }
            
            swGameTime.Restart();
        }
    }
}
