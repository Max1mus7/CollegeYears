using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessPawn : ChessPiece
    {
        //A pawn-specific constructor used to determine whether or not 
        //a piece's first move has been taken
        public bool FirstMoveTaken { get; set; }

        /// <summary>
        /// Constructor for ChessPawn objects
        /// </summary>
        public ChessPawn()
        {
            Name = "Pawn";
            if (PiecesCreated > 8 && PiecesCreated < 17)
            {
                VerticalPosition = 1;
            }
            else if (PiecesCreated >= 17 && PiecesCreated < 25)
            {
                VerticalPosition = 6;
            }
            FirstMoveTaken = false;
        }
    }
}