using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinesweeperGUI
{
    public partial class frmResult : Form
    {
        string Result { get; set; }
        int GameSize { get; set; }
        frmGame GameForm { get; set; }
        frmGamePrep PrepForm { get; set; }
        public frmResult(frmGamePrep prepForm, frmGame gameForm, string result, int gamesize)
        {
            InitializeComponent();
            Result = result;
            GameSize = gamesize;
            GameForm = gameForm;
            PrepForm = prepForm;
            lblMessage.Text = result;
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

    }
}
