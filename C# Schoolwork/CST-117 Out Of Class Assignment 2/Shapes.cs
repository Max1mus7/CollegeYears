using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Out_Of_Class_Assignment_2
{
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
            shapesList.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameBox.Checked)
            {
                if (filledButton.Checked)
                {
                    if (shapesList.GetSelected(0))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Square;
                        shapeNameDisplay.Text = "Square";
                    }
                    else if (shapesList.GetSelected(1))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Rectangle;
                        shapeNameDisplay.Text = "Rectangle";
                    }
                    else if (shapesList.GetSelected(2))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Circle;
                        shapeNameDisplay.Text = "Circle";
                    }
                    else if (shapesList.GetSelected(3))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Trapezoid;
                        shapeNameDisplay.Text = "Trapezoid";
                    }
                    else if (shapesList.GetSelected(4))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Hexagon;
                        shapeNameDisplay.Text = "Hexagon";
                    }
                }
                else
                {
                    if (shapesList.GetSelected(0))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Square;
                        shapeNameDisplay.Text = "Square";
                    }
                    else if (shapesList.GetSelected(1))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Rectangle;
                        shapeNameDisplay.Text = "Rectangle";
                    }
                    else if (shapesList.GetSelected(2))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Circle;
                        shapeNameDisplay.Text = "Circle";
                    }
                    else if (shapesList.GetSelected(3))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Trapezoid;
                        shapeNameDisplay.Text = "Trapezoid";
                    }
                    else if (shapesList.GetSelected(4))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Hexagon;
                        shapeNameDisplay.Text = "Hexagon";
                    }
                }
            }
            else
            {
                if (filledButton.Checked)
                {
                    if (shapesList.GetSelected(0))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Square;
                    }
                    else if (shapesList.GetSelected(1))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Rectangle;
                    }
                    else if (shapesList.GetSelected(2))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Circle;
                    }
                    else if (shapesList.GetSelected(3))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Trapezoid;
                    }
                    else if (shapesList.GetSelected(4))
                    {
                        imageWindow.Image = Properties.Resources.Filled_Hexagon;
                    }
                }
                else
                {
                    if (shapesList.GetSelected(0))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Square;
                    }
                    else if (shapesList.GetSelected(1))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Rectangle;
                    }
                    else if (shapesList.GetSelected(2))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Circle;
                    }
                    else if (shapesList.GetSelected(3))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Trapezoid;
                    }
                    else if (shapesList.GetSelected(4))
                    {
                        imageWindow.Image = Properties.Resources.Empty_Hexagon;
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (shapesList.GetSelected(0))
            {
                imageWindow.Image = Properties.Resources.Filled_Square;
            }
            else if (shapesList.GetSelected(1))
            {
                imageWindow.Image = Properties.Resources.Filled_Rectangle;
            }
            else if (shapesList.GetSelected(2))
            {
                imageWindow.Image = Properties.Resources.Filled_Circle;
            }
            else if (shapesList.GetSelected(3))
            {
                imageWindow.Image = Properties.Resources.Filled_Trapezoid;
            }
            else if (shapesList.GetSelected(4))
            {
                imageWindow.Image = Properties.Resources.Filled_Hexagon;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (shapesList.GetSelected(0))
            {
                imageWindow.Image = Properties.Resources.Empty_Square;
            }
            else if (shapesList.GetSelected(1))
            {
                imageWindow.Image = Properties.Resources.Empty_Rectangle;
            }
            else if (shapesList.GetSelected(2))
            {
                imageWindow.Image = Properties.Resources.Empty_Circle;
            }
            else if (shapesList.GetSelected(3))
            {
                imageWindow.Image = Properties.Resources.Empty_Trapezoid;
            }
            else if (shapesList.GetSelected(4))
            {
                imageWindow.Image = Properties.Resources.Empty_Hexagon;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nameBox.Checked)
            {
                if (shapesList.GetSelected(0))
                {
                    shapeNameDisplay.Text = "Square";
                }
                else if (shapesList.GetSelected(1))
                {
                    shapeNameDisplay.Text = "Rectangle";
                }
                else if (shapesList.GetSelected(2))
                {
                    shapeNameDisplay.Text = "Circle";
                }
                else if (shapesList.GetSelected(3))
                {
                    shapeNameDisplay.Text = "Trapezoid";
                }
                else if (shapesList.GetSelected(4))
                {
                    shapeNameDisplay.Text = "Hexagon";
                }
            }
            else
            {
                shapeNameDisplay.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (rotateBox.Checked)
            {
                imageWindow.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                imageWindow.Refresh();
            }
            else
            {
                imageWindow.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                imageWindow.Refresh();
            }
        }
    }
}