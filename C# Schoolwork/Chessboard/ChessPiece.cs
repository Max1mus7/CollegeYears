using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public abstract class ChessPiece
    {
        ///<summary>
        ///properties required in every piece
        /// </summary>
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int HorizontalPosition { get; set; }
        public int VerticalPosition { get; set; }
        public string Color { get; }
        public static int PiecesCreated { get; set; }

        ///<summary>
        ///Default constructor that uses the PiecesCreated property to automatically determine-
        ///whether a piece is the color black or the color white
        /// </summary>
        public ChessPiece()
        {
            PiecesCreated++;
            if (PiecesCreated < 17)
            {
                Color = "Black";
            }
            else
            {
                Color = "White";
            }
            HorizontalPosition = (PiecesCreated - 1) % 8;
        }
        /// <summary>
        /// Method used to change a chess piece's status to defeated
        /// </summary>
        /// <param name="c">Requires a single ChessPiece</param>
        public void Defeat(ChessPiece c)
        {
            c.IsAlive = false;
        }

        /// <summary>
        /// Overrides the Object class's ToString method and returns a string representation of any ChessPiece object
        /// </summary>
        /// <returns>Returns a string representation of a chess piece. For example: a Black Pawn would be represented as BP</returns>
        public override string ToString()
        {
            return Color[0].ToString() + Name[0].ToString();
        }
    }
}