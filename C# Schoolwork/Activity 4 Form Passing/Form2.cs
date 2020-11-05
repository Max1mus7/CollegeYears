using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Activity_4_Form_Passing
{
    public partial class Form2 : Form
    {
        public Form2(string input)
        {
            InitializeComponent();
            label1.Text = input;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
