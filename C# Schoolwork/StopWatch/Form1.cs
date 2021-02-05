using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        Random random = new Random();
        int numRounds = 0;
        int points = 0;
        int strikes = 0;
        Image mole = Image.FromFile(@"..\mole.png");
        Image whack = Image.FromFile(@"..\whack.png");
        Image bomb = Image.FromFile(@"..\Bomb.png");
        List<Button> liveButtons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            this.Click += Form1_Click;
            MessageBox.Show("Welcome to Whack-A-Mole!\nMake sure you whack the mole! Reach 10 strikes and the game is over...\nPress Start to begin!");
            btnTarget.BackgroundImage = mole;
            btnTarget.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.Visible = false;
            btnStop.Enabled = false;
            btnRestart.Visible = false;
            btnRestart.Enabled = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (stopWatch.ElapsedMilliseconds > 0)
            {
                ++strikes;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            btnTarget.Visible = true;
            btnTarget.Enabled = true;
            timer1.Enabled = true;
            btnStart.Visible = false;
            btnStart.Enabled = false;
            btnStop.Visible = true;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            timer1.Enabled = false;
            btnStop.Visible = false;
            btnStop.Enabled = false;
            btnRestart.Enabled = true;
            btnRestart.Visible = true;
            btnTarget.Visible = false;
            btnTarget.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetBoard();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Button btn in liveButtons)
            {
                btn.Dispose();
            }
            liveButtons.Clear();
            if (btnTarget.BackgroundImage.Equals(mole))
            {
                strikes++;
            }

            btnTarget.BackgroundImage = mole;
            btnTarget.BackgroundImageLayout = ImageLayout.Stretch;

            int numCheck = random.Next(0, 16);
            if(numCheck + (numRounds/15) > 14 && timer1.Interval > 50)
            {
                timer1.Interval -= 50;
            }
            if(numCheck + (numRounds/15) > 13)
            {
                Button b = new Button();
                b.Size = btnTarget.Size;
                b.BackgroundImage = bomb;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.Left = random.Next(0, (this.Width - btnTarget.Width));
                b.Top = random.Next(0, (this.Height - btnStart.Top + btnTarget.Height));
                this.Controls.Add(b);
                b.Click += B_Click;
                liveButtons.Add(b);
            }

            if (numCheck + (numRounds / 15) > 18)
            {
                Button b = new Button();
                b.Size = btnTarget.Size;
                b.BackgroundImage = bomb;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.Left = random.Next(0, (this.Width - btnTarget.Width));
                b.Top = random.Next(0, (this.Height - btnStart.Top + btnTarget.Height));
                this.Controls.Add(b);
                b.Click += B_Click;
                liveButtons.Add(b);
            }
            if (numCheck + (numRounds / 15) > 23)
            {
                Button b = new Button();
                b.Size = btnTarget.Size;
                b.BackgroundImage = bomb;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.Left = random.Next(0, (this.Width - btnTarget.Width));
                b.Top = random.Next(0, (this.Height - btnStart.Top + btnTarget.Height));
                this.Controls.Add(b);
                b.Click += B_Click;
                liveButtons.Add(b);
                
            }
            btnTarget.Left = random.Next(0, (this.Width - btnTarget.Left));
            btnTarget.Top = random.Next(0, (this.Height - btnStart.Top + btnTarget.Height));
            numRounds++;
        }

        private void B_Click(object sender, EventArgs e)
        {
            points -= 10;
            strikes += 3;
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            if (btnTarget.BackgroundImage.Equals(mole))
            {
                btnTarget.BackgroundImage = whack;
                btnTarget.BackgroundImageLayout = ImageLayout.Stretch;
                points += 5;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:mm\\:ss\\:ff}", stopWatch.Elapsed);
            lblPoints.Text = points + "";
            lblStrikes.Text = strikes + "";
            if (strikes >= 10)
            {
                btnStop.PerformClick();
                gameTimer.Enabled = false;
                btnStop.Visible = false;
                btnStop.Enabled = false;
                btnRestart.Enabled = true;
                btnRestart.Visible = true;
                MessageBox.Show("Nice job! You scored " + points + " points!\nYou lasted " + string.Format("{0:mm\\:ss}", stopWatch.Elapsed) + "!\n" +
                    "Press Restart to try again!");
                if (points > int.Parse(lblHighScore.Text))
                {
                    lblHighScore.Text = points + "";
                }
            }
        }

        private void ResetBoard()
        {
            btnTarget.Location = new Point(329, 130);
            btnTarget.BackgroundImage = mole;
            btnTarget.Enabled = true;
            btnTarget.Visible = true;
            stopWatch.Restart();
            points = 0;
            strikes = 0;
            numRounds = 0;
            lblPoints.Text = 0 + "";
            lblStrikes.Text = 0 + "";
            gameTimer.Enabled = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            btnStop.Enabled = true;
            btnStop.Visible = true;
            btnRestart.Enabled = false;
            btnRestart.Visible = false;
        }

    }
}
