using Chessboard;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessboardGUI
{
    public partial class Form1 : Form
    {
        private Button[,] buttonGrid = new Button[8, 8];
        private ChessBoard cb = new ChessBoard();

        public Form1()
        {
            InitializeComponent();

            PopulateButtonGrid(cb);
        }

        public void PopulateButtonGrid(ChessBoard board)
        {
            int buttonSize = panel1.Width / 8;
            panel1.Height = panel1.Width;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttonGrid[i, j] = new Button();
                    buttonGrid[i, j].Width = buttonSize;
                    buttonGrid[i, j].Height = buttonSize;
                    buttonGrid[i, j].Click += Grid_Click;
                    panel1.Controls.Add(buttonGrid[i, j]);
                    buttonGrid[i, j].Location = new Point(buttonSize * j, buttonSize * i);

                    if (board.Chessboard[i, j].IsOccupied)
                    {
                        buttonGrid[i, j].Text = board.Chessboard[i, j].ChessPiece.ToString();
                    }
                    else
                    {
                        buttonGrid[i, j].Text = "";
                    }
                    buttonGrid[i, j].Tag = i + "," + j;
                }
            }
        }

        public void Grid_Click(object sender, EventArgs e)
        {
            string[] stringArr = (sender as Button).Tag.ToString().Split(",");
            int row = int.Parse(stringArr[0]);
            int col = int.Parse(stringArr[1]);

            ChessSquare chessSquare = cb.Chessboard[row, col];
            if (chessSquare.IsOccupied)
            {
                if (chessSquare.ChessPiece.Name.Equals("Pawn"))
                {
                    try
                    {
                        cb.MovePawn(((ChessPawn)cb.Chessboard[row, col].ChessPiece), int.Parse(rowIn.Text.ToString()) - row, int.Parse(colIn.Text.ToString()) - col);
                    }
                    catch (System.InvalidOperationException error)
                    {
                        label1.Text = error.Message;
                    }
                    catch (System.FormatException)
                    {
                        label1.Text = "Input numbers please.";
                    }
                }
                else if (chessSquare.ChessPiece.Name.Equals("Knight"))
                {
                    try
                    {
                        cb.MoveKnight(((ChessKnight)cb.Chessboard[row, col].ChessPiece), int.Parse(rowIn.Text.ToString()) - row, int.Parse(colIn.Text.ToString()) - col);
                    }
                    catch (System.InvalidOperationException error)
                    {
                        label1.Text = error.Message;
                    }
                    catch (System.FormatException)
                    {
                        label1.Text = "Input numbers please.";
                    }
                }
                else if (chessSquare.ChessPiece.Name.Equals("Bishop"))
                {
                    try
                    {
                        cb.MoveBishop(((ChessBishop)cb.Chessboard[row, col].ChessPiece), int.Parse(rowIn.Text.ToString()) - row, int.Parse(colIn.Text.ToString()) - col);
                    }
                    catch (System.InvalidOperationException error)
                    {
                        label1.Text = error.Message;
                    }
                    catch (System.FormatException)
                    {
                        label1.Text = "Input numbers please.";
                    }
                }
                else if (chessSquare.ChessPiece.Name.Equals("Queen"))
                {
                    try
                    {
                        cb.MoveQueen(((ChessQueen)cb.Chessboard[row, col].ChessPiece), int.Parse(rowIn.Text.ToString()) - row, int.Parse(colIn.Text.ToString()) - col);
                    }
                    catch (System.InvalidOperationException error)
                    {
                        label1.Text = error.Message;
                    }
                    catch (System.FormatException)
                    {
                        label1.Text = "Input numbers please.";
                    }
                }
                else if (chessSquare.ChessPiece.Name.Equals("King"))
                {
                    try
                    {
                        cb.MoveKing(((ChessKing)cb.Chessboard[row, col].ChessPiece), int.Parse(rowIn.Text.ToString()) - row, int.Parse(colIn.Text.ToString()) - col);
                    }
                    catch (System.InvalidOperationException error)
                    {
                        label1.Text = error.Message;
                    }
                    catch (System.FormatException)
                    {
                        label1.Text = "Input numbers please.";
                    }
                }
                else if (chessSquare.ChessPiece.Name.Equals("Rook"))
                {
                    try
                    {
                        cb.MoveRook(((ChessRook)cb.Chessboard[row, col].ChessPiece), int.Parse(rowIn.Text.ToString()) - row, int.Parse(colIn.Text.ToString()) - col);
                    }
                    catch (System.InvalidOperationException error)
                    {
                        label1.Text = error.Message;
                    }
                    catch (System.FormatException)
                    {
                        label1.Text = "Input numbers please.";
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (cb.Chessboard[i, j].IsOccupied)
                        {
                            buttonGrid[i, j].Text = cb.Chessboard[i, j].ChessPiece.ToString();
                        }
                        else
                        {
                            buttonGrid[i, j].Text = "";
                        }
                    }
                }
            }
        }

    }
}