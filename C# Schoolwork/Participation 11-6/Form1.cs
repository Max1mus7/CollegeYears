using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation_11_6
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void btnDisplayMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkBold.Checked && chkItalic.Checked)
                {
                    Font newFont = new Font(cbFontName.Text, int.Parse(txtSize.Text), FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
                    lblMessage.Font = newFont;
                    lblMessage.Text = "Check out this font!";
                }
                else if (chkBold.Checked)
                {
                    Font newFont = new Font(cbFontName.Text, int.Parse(txtSize.Text), FontStyle.Bold, GraphicsUnit.Point);
                    lblMessage.Font = newFont;
                    lblMessage.Text = "Check out this font!";
                }
                else if (chkItalic.Checked)
                {
                    Font newFont = new Font(cbFontName.Text, int.Parse(txtSize.Text), FontStyle.Italic, GraphicsUnit.Point);
                    lblMessage.Font = newFont;
                    lblMessage.Text = "Check out this font!";
                }
                else
                {
                    Font newFont = new Font(cbFontName.Text, int.Parse(txtSize.Text), FontStyle.Regular, GraphicsUnit.Point);
                    lblMessage.Font = newFont;
                    lblMessage.Text = "Check out this font!";
                }
            }
            catch(System.FormatException s)
            {
                lblMessage.Text = "Check out this font!";
            }
        }
    }
}
