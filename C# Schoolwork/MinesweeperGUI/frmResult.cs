using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Minesweeper;
using System.Linq;

namespace MinesweeperGUI
{
    public partial class frmResult : Form
    {
        string Result { get; set; }
        int GameSize { get; set; }
        frmGame GameForm { get; set; }
        frmGamePrep PrepForm { get; set; }
        List<Score> Scores { get; set; }
        string Difficulty { get; set; }
        int GameScore { get; set; }
        TimeSpan GameTime { get; set; }
        DataTable dt { get; set; }
        public frmResult(frmGamePrep prepForm, frmGame gameForm, string result, int gamesize, int gameScore, TimeSpan gameTime)
        {
            InitializeComponent();
            //initializes properties
            Result = result;
            GameSize = gamesize;
            GameForm = gameForm;
            PrepForm = prepForm;
            lblMessage.Text = result;
            GameScore = gameScore;
            GameTime = gameTime;
            DetermineDifficulty(GameSize);
            lblScoreNum.Text = GameScore + "";
            //creates new datatable and makes it the source of the datagridview
            dt = new DataTable();
            dgScores.DataSource = dt;
            dt.Columns.Add("Player", typeof(string));
            dt.Columns.Add("Difficulty", typeof(string));
            dt.Columns.Add("Score", typeof(int));
            dt.Columns.Add("Time", typeof(string));
            //Read from text file
            Scores = ReadFile();
            //if the game is lost, prevent the user from entering initials
            if(GameScore <= 0)
            {
                tbInitials.Enabled = false;
                tbInitials.Visible = false;
                btnAddScore.Enabled = false;
                btnAddScore.Visible = false;
                lblScoreText.Text = "";
                lblScoreNum.Text = "";
                lblCongrats.Text = "";
                lblInitials.Text = "";
            }
        }

        private void Close_All(object sender, FormClosedEventArgs e)
        {
            PrepForm.Close();
            GameForm.Close();
        }
        private void Try_Again(object sender, FormClosedEventArgs e)
        {
            GameForm.ResetBoard();
        }

        private void Try_Again_But_Different(object sender, FormClosedEventArgs e)
        {
            GameForm.Close();
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.FormClosed += Try_Again;
            this.Close();
        }

        private void btnTryAgainButDifferent_Click(object sender, EventArgs e)
        {
            this.FormClosed += Try_Again_But_Different;
            this.Close();
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            this.FormClosed += Close_All;
            this.Close();
        }
        /// <summary>
        /// Defines the difficulty parameter for the datatable based on the size of the game
        /// </summary>
        /// <param name="gamesize"></param>
        public void DetermineDifficulty(int gamesize)
        {
            if(gamesize < 16)
            {
                Difficulty = "Easy";
            }
            else if(gamesize < 24)
            {
                Difficulty = "Medium";
            }
            else
            {
                Difficulty = "Hard";
            }
        }

        /// <summary>
        /// Reads from the text file database to populate the datatable
        /// </summary>
        /// <returns></returns>
        private List<Score> ReadFile()
        {
            //creates a new List of type Score to hold the resulting list
            List<Score> result = new List<Score>();
            //uses StreamReader efficiently
            using (StreamReader file = new StreamReader(@"..\scores.txt"))
            {
                //creates placeholder variables
                string line = "";
                string name = "";
                string difficulty = "";
                int score = 0;
                string time = "";
                //reads one line at a time until EOF
                while((line = file.ReadLine()) != null)
                {
                    //splits the data into chunks to make new Score objects using filled placeholder variables
                    string[] scoreParts = line.Split(",");
                    for(int i = 0; i < scoreParts.Length; i++)
                    {
                        if (i == 0)
                        {
                            name = scoreParts[i];
                        }
                        else if(i == 1)
                        {
                            difficulty = scoreParts[i];
                        }
                        else if(i == 2)
                        {
                            score = int.Parse(scoreParts[i]);
                        }
                        else if(i == 3)
                        {
                            time = scoreParts[i];
                        }
                    }
                    result.Add(new Score(name, difficulty, score, time));
                }
            }
            //uses a LINQ statement to order the data in descending order and take the top 5 scores
            var highscores = (from score in result
                              orderby score.Value descending
                              select new { name = score.Name, difficulty = score.Difficulty, playerScore = score.Value, time = score.GameTime }).Take(5);
            //adds the top 5 scores to the datatable and displays the results
            foreach (var item in highscores)
            {
                dt.Rows.Add(item.name, item.difficulty, item.playerScore, item.time);
            }
            return result;
        }

        /// <summary>
        /// Modifies the click listener for the Submit button to add a score to our text file database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string appendedText = tbInitials.Text + "," + Difficulty + "," + GameScore + "," + string.Format("{0:hh\\:mm\\:ss\\:ff}", GameTime) + Environment.NewLine;
            File.AppendAllText(@"..\scores.txt", appendedText);
            Scores = ReadFile();
            tbInitials.Enabled = false;
            tbInitials.Visible = false;
            btnAddScore.Enabled = false;
            btnAddScore.Visible = false;
            lblScoreText.Text = "";
            lblScoreNum.Text = "";
            lblCongrats.Text = "";
            lblInitials.Text = "";
        }
        

        private void tbInitials_TextChanged(object sender, EventArgs e)
        {
            if(tbInitials.TextLength > 2)
            {
                tbInitials.Text = tbInitials.Text.Substring(0, 2);
            }
        }
    }
}
