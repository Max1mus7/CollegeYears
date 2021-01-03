using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessBishop : ChessPiece
    {
        public ChessBishop()
        {
            Name = "Bishop";
            IsAlive = true;
            if (PiecesCreated == 3 || PiecesCreated == 6)
            {
                VerticalPosition = 0;
            }
            if (PiecesCreated == 27 || PiecesCreated == 30)
            {
                VerticalPosition = 7;
            }
        }

    }
}