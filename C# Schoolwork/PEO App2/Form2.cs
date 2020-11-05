using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEO_App2
{
    public partial class Form2 : Form
    {
        private Form1 openForm;

        public Form2()
        {
            InitializeComponent();
            openForm = new Form1();
            openForm.Show();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> btnames = new List<string>();
            List<string> wtnames = new List<string>();

            btnames.Add(btm1.Text);
            btnames.Add(btm2.Text);
            btnames.Add(btm3.Text);
            btnames.Add(btm4.Text);
            btnames.Add(btm5.Text);
            btnames.Add(btm6.Text);
            btnames.Add(btm7.Text);
            btnames.Add(btm8.Text);
            btnames.Add(btm9.Text);
            btnames.Add(btm10.Text);
            btnames.Add(btm11.Text);
            btnames.Add(btm12.Text);

            wtnames.Add(wtm1.Text);
            wtnames.Add(wtm2.Text);
            wtnames.Add(wtm3.Text);
            wtnames.Add(wtm4.Text);
            wtnames.Add(wtm5.Text);
            wtnames.Add(wtm6.Text);
            wtnames.Add(wtm7.Text);
            wtnames.Add(wtm8.Text);
            wtnames.Add(wtm9.Text);
            wtnames.Add(wtm10.Text);
            wtnames.Add(wtm11.Text);
            wtnames.Add(wtm12.Text);

            Form1 gameForm = new Form1(btnames, wtnames);
            gameForm.Show();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            List<string> btnames = new List<string>();
            List<string> wtnames = new List<string>();

            btnames.Add(btm1.Text);
            btnames.Add(btm2.Text);
            btnames.Add(btm3.Text);
            btnames.Add(btm4.Text);
            btnames.Add(btm5.Text);
            btnames.Add(btm6.Text);
            btnames.Add(btm7.Text);
            btnames.Add(btm8.Text);
            btnames.Add(btm9.Text);
            btnames.Add(btm10.Text);
            btnames.Add(btm11.Text);
            btnames.Add(btm12.Text);

            wtnames.Add(wtm1.Text);
            wtnames.Add(wtm2.Text);
            wtnames.Add(wtm3.Text);
            wtnames.Add(wtm4.Text);
            wtnames.Add(wtm5.Text);
            wtnames.Add(wtm6.Text);
            wtnames.Add(wtm7.Text);
            wtnames.Add(wtm8.Text);
            wtnames.Add(wtm9.Text);
            wtnames.Add(wtm10.Text);
            wtnames.Add(wtm11.Text);
            wtnames.Add(wtm12.Text);

            Form1 gameForm = new Form1(btnames, wtnames);
            gameForm.Show();
            openForm.Close();
            this.Hide();
        }
    }
}