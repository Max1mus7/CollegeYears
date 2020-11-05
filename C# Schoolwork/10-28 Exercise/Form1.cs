using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _10_28_Exercise
{
    public partial class Form1 : Form
    {
        Regex reg1 = new Regex("^[a-zA-Z]{5}$");
        Regex reg2 = new Regex("^[0-9]{1,52}$");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check1 = reg1.IsMatch(textBox1.Text);
            bool check2 = reg2.IsMatch(textBox2.Text.ToString());
            string checked1;
            string checked2;
            if (check1)
            {
                checked1 = textBox1.Text;
            }
            else
            {
                checked1 = "Invalid string entered. You can only enter strings with 5 letters.";
            }

            if(check2)
            {
                checked2 = textBox2.Text;
            }
            else
            {
                checked2 = "Invalid string entered. You can only enter numbers";
            }
            Form2 newForm = new Form2(checked1, checked2);
            newForm.Show();
        }
    }
}
