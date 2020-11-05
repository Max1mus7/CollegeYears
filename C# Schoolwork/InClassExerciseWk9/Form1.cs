using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InClassExerciseWk9
{
    public partial class Form1 : Form
    {
        //Define scoreboard properties
        private int scoreButton = 0;
        private int scoreForm = 0;
        private Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
            //This is the event handler
            this.MouseClick += mouseClick;
           
        }

        //Create the mouseClick for the form
        /// <summary>
        /// Mouse click for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                lblScoreFrm.Text = ++scoreForm + "";
            }
        }

        /// <summary>
        /// Button to set properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetProp_Click(object sender, EventArgs e)
        {
            //change the text on the face of the button
            btnChanged.Text = "I will change";
            //change the font properties
            btnChanged.Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //change the button size
            btnChanged.Width = 100;
            btnChanged.Height = 50;
            btnChanged.AutoSize = true;

            //what is the object sender
            var tester = sender.ToString();
            tester = sender.GetType().ToString();

            //keep the score
            lblScoreBtn.Text = ++scoreButton + "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            lblElapsedTime.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", stopWatch.Elapsed);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate the stopwatch class
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //put the time elapsed from the timer into the stopwatch label
            //lblStopWatch.Text = stopWatch.Elapsed.ToString();

            lblStopWatch.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}",stopWatch.Elapsed);
        }
    }
}
