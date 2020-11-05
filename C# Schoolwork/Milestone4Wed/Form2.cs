using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Milestone4Wed
{
    public partial class frmGUI2 : Form
    {
        //btnGrid stores a 2d array of buttons
        public Button[,] btnGrid;
        public int clicks = 0;


        public frmGUI2(int gridSize)
        {
            InitializeComponent();

            //btnGrid contains the button controls 
            btnGrid = new Button[gridSize,gridSize];

            //populate the grid with buttons
            PopulateGrid(gridSize);
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
                    pnlButtons.Controls.Add(btnGrid[row,col]);

                    //Locate the button where it needs to live
                    btnGrid[row, col].Location = new Point(buttonSize*row, buttonSize*col);

                }
            }
        }

    }
}
