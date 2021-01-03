using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessKing : ChessPiece
    {
        public ChessKing()
        {
            Name = "King";
            IsAlive = true;
            if (PiecesCreated == 5)
            {
                VerticalPosition = 0;
            }
            if (PiecesCreated == 29)
            {
                VerticalPosition = 7;
            }
        }
    }
}