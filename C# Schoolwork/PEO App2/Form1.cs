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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<String> names1, List<String> names2)
        {
            InitializeComponent();
            btm1.Text += names1[0];
            btm2.Text += names1[1];
            btm3.Text += names1[2];
            btm4.Text += names1[3];
            btm5.Text += names1[4];
            btm6.Text += names1[5];
            btm7.Text += names1[6];
            btm8.Text += names1[7];
            btm9.Text += names1[8];
            btm10.Text += names1[9];
            btm11.Text += names1[10];
            btm12.Text += names1[11];

            wtm1.Text += names2[0];
            wtm2.Text += names2[1];
            wtm3.Text += names2[2];
            wtm4.Text += names2[3];
            wtm5.Text += names2[4];
            wtm6.Text += names2[5];
            wtm7.Text += names2[6];
            wtm8.Text += names2[7];
            wtm9.Text += names2[8];
            wtm10.Text += names2[9];
            wtm11.Text += names2[10];
            wtm12.Text += names2[11];
        }
    }
}