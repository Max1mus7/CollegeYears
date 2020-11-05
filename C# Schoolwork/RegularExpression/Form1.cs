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


namespace RegularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to check valid Regex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //uses the regex to check the input

            Regex reg = new Regex(txtPattern.Text.ToString());
            bool result = reg.IsMatch(txtText.Text);
            //Show the true or false on the label
            lblResult.Text = result.ToString();
        }
    }
}
