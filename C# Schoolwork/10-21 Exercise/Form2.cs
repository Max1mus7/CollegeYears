using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _10_21_Exercise
{
    public partial class Form2 : Form
    {
        public Form2(string input)
        {
            InitializeComponent();
            label1.Text = input;
            textBox1.Text = input;
        }

    }
}
