using System;

namespace Chessboard
{
    public class ChessBoard
    {
        //Declare fields
        //2-D array of ChessSquares that will make up the chessboard
        public ChessSquare[,] Chessboard { get; set; }

        /// <summary>
        /// Constructor for ChessBoard objects
        /// </summary>
        public ChessBoard()
        {
            Chessboard = new ChessSquare[8, 8];
            //creates a loop to access all areas of Chessboard array
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //instantiates the board
                    Chessboard[i, j] = new ChessSquare();
                }
            }
        }

        /// <summary>
        /// Prints a string representation of the chessboard
        /// </summary>
        public void PrintChessPieces()
        {
            Console.WriteLine("This is a string representation of the pieces on the chessboard:\n");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("+====+\t");
                }
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    if (Chessboard[i, j].IsOccupied)
                    {
                        Console.Write("| " + Chessboard[i, j].ChessPiece + " |\t");
                    }
                    else
                    {
                        Console.Write("|    |\t");
                    }
                }
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("+====+\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// prints a string representation of whether or not the squares of the chessboard are occupied
        /// </summary>
        public void PrintCellIsOccupied()
        {

            Console.WriteLine("This is a string representation of whether the Chess Squares are occupied with a chess piece:\n");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("+====+\t");
                }
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    if (Chessboard[i, j].IsOccupied)
                    {
                        Console.Write("|Full|\t");
                    }
                    else
                    {
                        Console.Write("|Free|\t");
                    }
                }
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("+====+\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Prints a string representation of the color of the board's squares
        /// </summary>
        public void PrintBoardColor()
        {
            Console.WriteLine("This is a string representation of the color of each of the squares on the chessboard:\n");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Chessboard[i, j].IsBlack)
                    {
                        Console.Write("Black\t");
                    }
                    else
                    {
                        Console.Write("White\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Allows a pawn to move
        /// </summary>
        /// <param name="pawn">Requires an object of the pawn class</param>
        /// <param name="verticalMotion">How far a pawn is being moved vertically</param>
        /// <param name="horizontalMotion">How far a pawn is being moved horizontally</param>
        public void MovePawn(ChessPawn pawn, int verticalMotion, int horizontalMotion)
        {
            //contains logic if a pawn is taking its first move
            if (!((ChessPawn)pawn).FirstMoveTaken)
            {
                //ensures the pawn does not move more than 2 spaces forward
                if (verticalMotion > 2)
                {
                    throw new System.InvalidOperationException("Pawns cannot move that far vertically, even on the first move.");
                }
                //ensures the pawn does not move backwards
                else if (verticalMotion < 0)
                {
                    throw new System.InvalidOperationException("Pawns cannot move backwards.");
                }
                //makes the game more user friendly, and flips the sign of vertical motion if white pieces are used
                if (pawn.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
                {
                    verticalMotion = verticalMotion;
                }
                else
                {
                    verticalMotion = -verticalMotion;
                }

                //ensures the user is not trying to move the pawn too far horizontally
                if (horizontalMotion < -1 || horizontalMotion > 1)
                {
                    throw new System.InvalidOperationException("Pawns can never move more than one space horizontally.");
                }
                //ensures that the user cannot move a pawn diagonally without attacking another piece
                else if (horizontalMotion != 0 && !Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied ||
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece != null &&
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece.Color.Equals(pawn.Color))
                {
                    throw new System.InvalidOperationException("Pawns cannot move horizontally without attacking a piece of the opposite color.");
                }
                //Logic for a successful move/attack
                else
                {
                    if (Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied && horizontalMotion == 1 ||
                        Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied && horizontalMotion == -1)
                    {
                        Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece.Defeat(
                            Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece);
                    }
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece =
                        Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece;
                    Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece = null;
                    Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].IsOccupied = false;
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied = true;
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece.HorizontalPosition = pawn.HorizontalPosition + horizontalMotion;
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition].ChessPiece.VerticalPosition = pawn.VerticalPosition + verticalMotion;
                }
            }

            ///contains logic if a pawn is taking any move after its first
            else
            {
                if (verticalMotion == 2)
                {
                    throw new System.InvalidOperationException("Pawns can only move that far vertically on the first move.");
                }
                else if (verticalMotion > 1)
                {
                    throw new System.InvalidOperationException("Pawns cannot move that far forward.");
                }

                if (pawn.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
                {
                    verticalMotion = verticalMotion;
                }
                else
                {
                    verticalMotion = -verticalMotion;
                }

                if (horizontalMotion < -1 || horizontalMotion > 1)
                {
                    throw new System.InvalidOperationException("Pawns can never move more than one space horizontally.");
                }
                else
                {
                    if (Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied && horizontalMotion == 1 ||
                        Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied && horizontalMotion == -1)
                    {
                        Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece.Defeat(
                            Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece);
                    }
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece =
                        Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece;
                    Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece = null;
                    Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].IsOccupied = false;
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied = true;
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece.HorizontalPosition = pawn.HorizontalPosition + horizontalMotion;
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition].ChessPiece.VerticalPosition = pawn.VerticalPosition + verticalMotion;
                }
            }
        }

        /// <summary>
        /// Allows a knight to move
        /// </summary>
        /// <param name="knight">Requires an object of the knight class</param>
        /// <param name="verticalMotion">How far a knight is being moved vertically</param>
        /// <param name="horizontalMotion">How far a knight is being moved horizontally</param>
        public void MoveKnight(ChessKnight knight, int verticalMotion, int horizontalMotion)
        {
           
            if (horizontalMotion > 2 || verticalMotion > 2)
            {
                throw new System.InvalidOperationException("Knights cannot move more than 2 spaces vertically or horizonatally");
            }
            if(horizontalMotion == 2 && verticalMotion > 1 || horizontalMotion == 2 && verticalMotion == 0 || 
                horizontalMotion == 2 && verticalMotion < -1 || verticalMotion == 2 && horizontalMotion > 1 || 
                verticalMotion == 2 && horizontalMotion == 0 || verticalMotion == 2 && horizontalMotion < -1 || 
                horizontalMotion == 0 && verticalMotion == 0)
            {
                throw new System.InvalidOperationException("Knights can only move 2 squares up/down and 1 square left/right, or " +
                    "2 squares left/right and 1 square up/down.");
            }

            
            if (knight.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                verticalMotion = verticalMotion;
            }
            else
            {
                verticalMotion = -verticalMotion;
            }

            if (Chessboard[knight.VerticalPosition + verticalMotion, knight.HorizontalPosition + horizontalMotion].IsOccupied)
            {
                Chessboard[knight.VerticalPosition, knight.HorizontalPosition].ChessPiece.Defeat(
                    Chessboard[knight.VerticalPosition + verticalMotion, knight.HorizontalPosition + horizontalMotion].ChessPiece);
            }
            Chessboard[knight.VerticalPosition + verticalMotion, knight.HorizontalPosition + horizontalMotion].ChessPiece =
                Chessboard[knight.VerticalPosition, knight.HorizontalPosition].ChessPiece;
            Chessboard[knight.VerticalPosition, knight.HorizontalPosition].ChessPiece = null;
            Chessboard[knight.VerticalPosition, knight.HorizontalPosition].IsOccupied = false;
            Chessboard[knight.VerticalPosition + verticalMotion, knight.HorizontalPosition + horizontalMotion].IsOccupied = true;
            Chessboard[knight.VerticalPosition + verticalMotion, knight.HorizontalPosition + horizontalMotion].ChessPiece.HorizontalPosition = knight.HorizontalPosition + horizontalMotion;
            Chessboard[knight.VerticalPosition + verticalMotion, knight.HorizontalPosition].ChessPiece.VerticalPosition = knight.VerticalPosition + verticalMotion;
        }

        /// <summary>
        /// Allows a bishop to move
        /// </summary>
        /// <param name="bishop">Requires a bishop object</param>
        /// <param name="verticalMotion">Requires a magnitude of vertical motion</param>
        /// <param name="horizontalMotion">Requires a magnitude of horizontal motion</param>
        public void MoveBishop(ChessBishop bishop, int verticalMotion, int horizontalMotion)
        {
            if(verticalMotion != horizontalMotion && verticalMotion != -horizontalMotion)
            {
                throw new System.InvalidOperationException("Bishops must move diagonally.");
            }

            if (bishop.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                verticalMotion = verticalMotion;
            }
            else
            {
                verticalMotion = -verticalMotion;
            }

            if (Chessboard[bishop.VerticalPosition + verticalMotion, bishop.HorizontalPosition + horizontalMotion].IsOccupied)
            {
                Chessboard[bishop.VerticalPosition, bishop.HorizontalPosition].ChessPiece.Defeat(
                    Chessboard[bishop.VerticalPosition + verticalMotion, bishop.HorizontalPosition + horizontalMotion].ChessPiece);
            }
            Chessboard[bishop.VerticalPosition + verticalMotion, bishop.HorizontalPosition + horizontalMotion].ChessPiece =
                Chessboard[bishop.VerticalPosition, bishop.HorizontalPosition].ChessPiece;
            Chessboard[bishop.VerticalPosition, bishop.HorizontalPosition].ChessPiece = null;
            Chessboard[bishop.VerticalPosition, bishop.HorizontalPosition].IsOccupied = false;
            Chessboard[bishop.VerticalPosition + verticalMotion, bishop.HorizontalPosition + horizontalMotion].IsOccupied = true;
            Chessboard[bishop.VerticalPosition + verticalMotion, bishop.HorizontalPosition + horizontalMotion].ChessPiece.HorizontalPosition = bishop.HorizontalPosition + horizontalMotion;
            Chessboard[bishop.VerticalPosition + verticalMotion, bishop.HorizontalPosition].ChessPiece.VerticalPosition = bishop.VerticalPosition + verticalMotion;
        }

        /// <summary>
        /// Allows a rook to move
        /// </summary>
        /// <param name="rook">Requires a rook object</param>
        /// <param name="verticalMotion">Requires a magnitude of vertical motion</param>
        /// <param name="horizontalMotion">Requires a magnitude of horizontal motion</param>
         public void MoveRook(ChessRook rook, int verticalMotion, int horizontalMotion)
        {
            if(verticalMotion != 0 && horizontalMotion != 0)
            {
                throw new System.InvalidOperationException("Rooks must move vertically or horizontally.");
            }

            if (rook.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                verticalMotion = verticalMotion;
            }
            else
            {
                verticalMotion = -verticalMotion;
            }

            if (Chessboard[rook.VerticalPosition + verticalMotion, rook.HorizontalPosition + horizontalMotion].IsOccupied)
            {
                Chessboard[rook.VerticalPosition, rook.HorizontalPosition].ChessPiece.Defeat(
                    Chessboard[rook.VerticalPosition + verticalMotion, rook.HorizontalPosition + horizontalMotion].ChessPiece);
            }
            Chessboard[rook.VerticalPosition + verticalMotion, rook.HorizontalPosition + horizontalMotion].ChessPiece =
                Chessboard[rook.VerticalPosition, rook.HorizontalPosition].ChessPiece;
            Chessboard[rook.VerticalPosition, rook.HorizontalPosition].ChessPiece = null;
            Chessboard[rook.VerticalPosition, rook.HorizontalPosition].IsOccupied = false;
            Chessboard[rook.VerticalPosition + verticalMotion, rook.HorizontalPosition + horizontalMotion].IsOccupied = true; 
            Chessboard[rook.VerticalPosition + verticalMotion, rook.HorizontalPosition + horizontalMotion].ChessPiece.HorizontalPosition = rook.HorizontalPosition + horizontalMotion;
            Chessboard[rook.VerticalPosition + verticalMotion, rook.HorizontalPosition].ChessPiece.VerticalPosition = rook.VerticalPosition + verticalMotion;
        }

        /// <summary>
        /// Allows a king to move
        /// </summary>
        /// <param name="king">Requires a king object</param>
        /// <param name="verticalMotion">Requires a magnitude of vertical motion</param>
        /// <param name="horizontalMotion">Requires a magnitude of horizontal motion</param>
        public void MoveKing(ChessKing king, int verticalMotion, int horizontalMotion)
        {
            if (verticalMotion != 0 && horizontalMotion != 0)
            {
                throw new System.InvalidOperationException("Kings must move vertically or horizontally.");
            }
            if(verticalMotion > 1 || horizontalMotion > 1 || horizontalMotion < -1)
            {
                throw new System.InvalidOperationException("Kings can only move 1 space vertically or horizontally.");
            }
            if (king.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                verticalMotion = verticalMotion;
            }
            else
            {
                verticalMotion = -verticalMotion;
            }

            if(Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition + horizontalMotion].IsOccupied &&
                Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition + horizontalMotion].ChessPiece.Color.Equals(king.Color))
            {
                throw new System.InvalidOperationException("Cannot attack a piece of the same type.");
            }

            else if (Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition + horizontalMotion].IsOccupied)
            {
                Chessboard[king.VerticalPosition, king.HorizontalPosition].ChessPiece.Defeat(
                    Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition + horizontalMotion].ChessPiece);
            }
            Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition + horizontalMotion].ChessPiece =
                Chessboard[king.VerticalPosition, king.HorizontalPosition].ChessPiece;
            Chessboard[king.VerticalPosition, king.HorizontalPosition].ChessPiece = null;
            Chessboard[king.VerticalPosition, king.HorizontalPosition].IsOccupied = false;
            Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition + horizontalMotion].IsOccupied = true;
            Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition + horizontalMotion].ChessPiece.HorizontalPosition = king.HorizontalPosition + horizontalMotion;
            Chessboard[king.VerticalPosition + verticalMotion, king.HorizontalPosition].ChessPiece.VerticalPosition = king.VerticalPosition + verticalMotion;
        }

        /// <summary>
        /// Allows a queen to move
        /// </summary>
        /// <param name="queen">Requires a queen object</param>
        /// <param name="verticalMotion">Requires a magnitude of vertical motion</param>
        /// <param name="horizontalMotion">Requires a magnitude of horizontal motion</param>
        public void MoveQueen(ChessQueen queen, int verticalMotion, int horizontalMotion)
        {
            
            if (queen.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                verticalMotion = verticalMotion;
            }
            else
            {
                verticalMotion = -verticalMotion;
            }

            if (Chessboard[queen.VerticalPosition + verticalMotion, queen.HorizontalPosition + horizontalMotion].IsOccupied)
            {
                Chessboard[queen.VerticalPosition, queen.HorizontalPosition].ChessPiece.Defeat(
                    Chessboard[queen.VerticalPosition + verticalMotion, queen.HorizontalPosition + horizontalMotion].ChessPiece);
            }
            Chessboard[queen.VerticalPosition + verticalMotion, queen.HorizontalPosition + horizontalMotion].ChessPiece =
                Chessboard[queen.VerticalPosition, queen.HorizontalPosition].ChessPiece;
            Chessboard[queen.VerticalPosition, queen.HorizontalPosition].ChessPiece = null;
            Chessboard[queen.VerticalPosition, queen.HorizontalPosition].IsOccupied = false;
            Chessboard[queen.VerticalPosition + verticalMotion, queen.HorizontalPosition + horizontalMotion].IsOccupied = true;
            Chessboard[queen.VerticalPosition + verticalMotion, queen.HorizontalPosition + horizontalMotion].ChessPiece.HorizontalPosition = queen.HorizontalPosition + horizontalMotion;
            Chessboard[queen.VerticalPosition + verticalMotion, queen.HorizontalPosition].ChessPiece.VerticalPosition = queen.VerticalPosition + verticalMotion;
        }
    }
}