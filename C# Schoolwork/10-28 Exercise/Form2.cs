using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _10_28_Exercise
{
    public partial class Form2 : Form
    {
        public Form2(string check1, string check2)
        {
            InitializeComponent();
            label1.Text = check1;
            label2.Text = check2;
        }

    }
}
