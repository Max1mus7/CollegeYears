using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessKnight : ChessPiece
    {
        public ChessKnight()
        {
            Name = "Knight";
            IsAlive = true;
            if (PiecesCreated == 2 || PiecesCreated == 7)
            {
                VerticalPosition = 0;
            }
            if (PiecesCreated == 26 || PiecesCreated == 31)
            {
                VerticalPosition = 7;
            }
        }
    }
}