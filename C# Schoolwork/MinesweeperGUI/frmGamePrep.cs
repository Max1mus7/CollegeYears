﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperGUI
{
    public partial class frmGamePrep : Form
    {
        /// <summary>
        /// no-args constructor, starts at a base 8
        /// </summary>
        public frmGamePrep()
        {
            InitializeComponent();
            lblGridSize.Text = "8";
        }
        /// <summary>
        /// Allows the user to keep the specified value of difficulty that was orignally chosen.
        /// </summary>
        /// <param name="value"></param>
        public frmGamePrep(int value)
        {
            InitializeComponent();
            lblGridSize.Text = value + "";
            tbarGridSize.Value = value;
        }
        //Declare static variables
        static int gridSize = 8;

        /// <summary>
        /// Grid Size Scroll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbarGridSize_Scroll(object sender, EventArgs e)
        {
            //Read in the trackbar position and give the position to the grid size
            gridSize = tbarGridSize.Value;
            lblGridSize.Text = " " + tbarGridSize.Value;
        }

        /// <summary>
        /// Starts the Minesweeper game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPassToGUI2_Click(object sender, EventArgs e)
        {

            //Pass the number of the grid cells to GUI2
            frmGame newGame = new frmGame(this, gridSize);
            //Show the new form
            newGame.ShowDialog();

        }

    }
}
