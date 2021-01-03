using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessQueen : ChessPiece
    {
        public ChessQueen()
        {
            Name = "Queen";
            IsAlive = true;
            if (PiecesCreated == 4)
            {
                VerticalPosition = 0;
            }
            if (PiecesCreated == 28)
            {
                VerticalPosition = 7;
            }
        }
    }
}