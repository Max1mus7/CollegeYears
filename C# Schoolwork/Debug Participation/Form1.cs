using System;
using System.Drawing;
using System.Windows.Forms;

namespace Debug_Participation
{
    public partial class Form1 : Form
    {
        private Button draw = new Button();
        private RadioButton square = new RadioButton();
        private RadioButton circle = new RadioButton();

        public Form1()
        {
            Text = "Select";
            draw.Text = "Draw";
            square.Text = "Square";
            circle.Text = "Circle";
            Size = new Size(500, 250);
            int w = 20;
            draw.Location = new Point(20, 30);
            square.Location = new Point(w += 10 + draw.Width, 30);
            circle.Location = new Point(w += 10 + square.Width, 30);
            Controls.Add(draw);
            Controls.Add(square);
            Controls.Add(circle);
            draw.Click += new System.EventHandler(draw_Click);
        }

        protected void draw_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (square.Checked)
            {
                g.FillRectangle(Brushes.Red, 100, 100, 100, 100);
                g.DrawString("Square", new Font("Algerian", 14), Brushes.Black, 102, 140);
            }
            else
            {
                g.FillEllipse(Brushes.Red, 100, 100, 100, 100);
                g.DrawString("Circle", new Font("Arial", 14), Brushes.Black, 115, 140);
            }
            base.OnPaint(e);
        }
    }
}