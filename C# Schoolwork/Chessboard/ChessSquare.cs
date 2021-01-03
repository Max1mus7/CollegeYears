using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessSquare
    {


        /// <summary>
        /// //properties defining what a square on a chess board should be able to have
        /// </summary>
        // defines whether a square on the board is black or white
        public bool IsBlack { get; }

        //defines whether or not a given chess square is occupied or not
        public bool IsOccupied { get; set; }

        //defines the number of squares created
        private static int SquareCount { get; set; }
        //defines the number of rows in the chessboard
        private static int RowCount { get; set; }
        //allows a ChessPiece object to be given to a square
        public ChessPiece ChessPiece { get; set; }

        //public string HPosition { get; set; }

        //public string VPosition { get; set; }

        /// <summary>
        /// Constructor for the ChessSquare class
        /// Initializes properties and determines within the class itself whether square are occupied or not,
        /// and whether squares are occupied
        /// </summary>
        public ChessSquare()
        {
            //increases the number of squares on the board 
            //whenever a new object of ChessSquare is created
            SquareCount++;

            ///determines the position of each square that is created and determines the color
            ///for example, if SquareCount is even on even rows, make the squares black 
            if (SquareCount % 2 == 0 && RowCount % 2 == 0)
            {
                this.IsBlack = true;
            }
            else if (SquareCount % 2 == 1 && RowCount % 2 == 0)
            {
                this.IsBlack = false;
            }
            else if (SquareCount % 2 == 1 && RowCount % 2 == 1)
            {
                this.IsBlack = true;
            }
            else if (SquareCount % 2 == 0 && RowCount % 2 == 1)
            {
                this.IsBlack = false;
            }

            ///<summary>
            ///using a square's position and automatically occupies it with a chess piece 
            /// </summary>
            //Sets rooks
            if (SquareCount == 1 || SquareCount == 8 || SquareCount == 57 || SquareCount == 64)
            {
                this.ChessPiece = new ChessRook();
                this.IsOccupied = true;
            }
            //Sets knights
            else if (SquareCount == 2 || SquareCount == 7 || SquareCount == 58 || SquareCount == 63)
            {
                this.ChessPiece = new ChessKnight();
                this.IsOccupied = true;
            }
            //Sets bishops
            else if (SquareCount == 3 || SquareCount == 6 || SquareCount == 59 || SquareCount == 62)
            {
                this.ChessPiece = new ChessBishop();
                this.IsOccupied = true;
            }
            //Sets kings
            else if (SquareCount == 4 || SquareCount == 61)
            {
                this.ChessPiece = new ChessKing();
                this.IsOccupied = true;
            }
            //Sets queens
            else if (SquareCount == 5 || SquareCount == 60)
            {
                this.ChessPiece = new ChessQueen();
                this.IsOccupied = true;
            }
            //Sets pawns 
            else if (SquareCount > 8 && SquareCount < 17 || SquareCount > 48 && SquareCount < 57)
            {
                this.ChessPiece = new ChessPawn();
                this.IsOccupied = true;
            }
            else
            {
                this.IsOccupied = false;
            }
            ///<div>Not currently in use. 
            ///Provides a square with a string HPosition and a string VPosition.
            ///if(RowCount == 0)
            ///{
            ///    this.HPosition = "A";
            ///    if(SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///if (RowCount == 1)
            ///{
            ///    this.HPosition = "B";
            ///    if (SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///if (RowCount == 2)
            ///{
            ///    this.HPosition = "C";
            ///    if (SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///if (RowCount == 3)
            ///{
            ///    this.HPosition = "D";
            ///    if (SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///if (RowCount == 4)
            ///{
            ///    this.HPosition = "E";
            ///    if (SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///if (RowCount == 5)
            ///{
            ///    this.HPosition = "F";
            ///    if (SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///if (RowCount == 6)
            ///{
            ///    this.HPosition = "G";
            ///    if (SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///if (RowCount == 7)
            ///{
            ///    this.HPosition = "H";
            ///    if (SquareCount % 8 == 0)
            ///    {
            ///        this.VPosition = 8 + "";
            ///    }
            ///    else
            ///    {
            ///        this.VPosition = SquareCount % 8 + "";
            ///    }
            ///}
            ///</div>
            if (SquareCount % 8 == 0)
            {
                RowCount++;
            }
            
        }
    }
}