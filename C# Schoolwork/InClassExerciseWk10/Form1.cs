using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

namespace InClassExerciseWk10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            //Define the variables
            string line, player = "";
            int scoreValue = 0;
            bool canConvert;

            //Instantiate List class and create the object list for key value pair
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();


            //-------------------------------------------------------------------------------------
            //Create a new score list
            List<Score> gameScores = new List<Score>();

            //Read in the file
            string directoryLoc = AppContext.BaseDirectory + @"\Resources\Data Files\Score.txt";



            //Read in the comma deliminated file and parse the data and put it in a list
            using (StreamReader file = new StreamReader(directoryLoc))
            {
                //Loop through all of the lines and add each line to the list
                while ((line = file.ReadLine()) != null)
                {
                    //split the string by comma
                    string[] array = line.Split(",");
                    foreach (string value in array)
                    {
                        canConvert = int.TryParse(value, out scoreValue);
                        if (!canConvert)
                        {
                            player = value;
                        }
                    }
                    list.Add(new KeyValuePair<string, int>(player, scoreValue));

                    //------------------------------------------------------------------------------
                    //Add a new player and score to the list
                    gameScores.Add(new Score(player, scoreValue));
                }

            }

            //-----------------------------------------------------------------
            //Sort the scores

            //gameScores.Sort();

            //-----------------------------------------------------------------
            //Apply LINQ to the List

            var highscores = (from gameScore in gameScores
                              where gameScore.score > 0
                              orderby gameScore.score descending
                              select new { name = gameScore.name, score = gameScore.score }).Take(5);


            
            DataTable dt = new DataTable();
            dgScores.DataSource = dt;
            dt.Columns.Add("Player", typeof(string));
            dt.Columns.Add("Score", typeof(int));
            //dt.DefaultView.Sort = "Score DESC";
            //foreach(var indLine in list)
            //{
                //populate the datatable
            //    dt.Rows.Add(indLine.Key, indLine.Value);
            //}

            //----------------------------------------------------------------
            //Show the new list
            //foreach(Score score in gameScores)
            //{
            //    dt.Rows.Add(score.name, score.score);
            //}

            //================================================================
            //Populate data table from LINQ query
            foreach(var item in highscores)
            {
                dt.Rows.Add(item.name, item.score);
            }
        }



        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Example: Write one string to a text file - comma deliminated file
            string scoreData = "Bill Hughes, 5500\nAlex, 5100\n";
            //WriteAllText creates a file, writes the spcified string to the file, and then closes the file
            File.WriteAllText(@"..\Data\Score.txt", scoreData);

        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            string scoreUpdate = txtAppend.Text + Environment.NewLine;
            File.AppendAllText(@"..\Data\Score.txt", scoreUpdate);
        }
    }
}
