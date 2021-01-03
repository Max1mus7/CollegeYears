using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessRook : ChessPiece
    {
        public ChessRook()
        {
            Name = "Rook";
            IsAlive = true;
            if (PiecesCreated == 1 || PiecesCreated == 8)
            {
                VerticalPosition = 0;
            }
            if (PiecesCreated == 25 || PiecesCreated == 32)
            {
                VerticalPosition = 7;
            }
        }
    }
}