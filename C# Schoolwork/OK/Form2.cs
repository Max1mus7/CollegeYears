using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OK
{
    public partial class Form2 : Form
    {
        public Form2(string ok)
        {
            InitializeComponent();
            label1.Text = ok;
        }
    }
}