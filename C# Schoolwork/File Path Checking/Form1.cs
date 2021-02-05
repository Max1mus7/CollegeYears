using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Path_Checking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\Users\poker\Documents\MAMP\htdocs\Milestone Project\Eagle Claw Tackle Kit.JPG");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

    }
}
