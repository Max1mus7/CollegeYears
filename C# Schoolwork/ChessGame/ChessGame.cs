using System;
using Chessboard;

namespace ChessGame
{
    internal class ChessGame
    {
        /// <summary>
        /// Allows users to play the chess game through the console
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            ChessBoard cb = new ChessBoard();
            //prints a string representation of whether or not the squares of the chessboard are occupied
            cb.PrintCellIsOccupied();

            
            //prints a string representation of the pieces on the chessboard
            cb.PrintChessPieces();

           
            //prints a string representation of the color of the board's squares
            cb.PrintBoardColor();

            //for(int i = 0; i < 8; i++)
            //{
            //    for(int j = 0; j < 8; j++)
            //    {
            //        count++;
            //        Console.Write(cb.Chessboard[i, j].HPosition + cb.Chessboard[i, j].VPosition);
            //        if(count % 8 == 0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //tests to see the board state after a pawn is moved
            cb.MovePawn((ChessPawn)cb.Chessboard[1, 1].ChessPiece, 2, 0);
            Console.WriteLine("=================This is how the board is affected by the movement of a pawn=================\n\n\n");
            cb.PrintChessPieces();
            cb.PrintCellIsOccupied();

            //tests to see the board state after a bishop is moved
            cb.MoveBishop((ChessBishop)cb.Chessboard[7, 5].ChessPiece, 2, -2);
            Console.WriteLine("=================This is how the board is affected by the movement of a bishop=================\n\n\n");
            cb.PrintChessPieces();
            cb.PrintCellIsOccupied();
            

            //tests to see the board state after a knight is moved
            cb.MoveKnight((ChessKnight)cb.Chessboard[0, 1].ChessPiece, 2, 1);
            Console.WriteLine("=================This is how the board is affected by the movement of a knight=================\n\n\n");
            cb.PrintChessPieces();
            cb.PrintCellIsOccupied();
            

            //tests to see the board state after a queen is moved
            cb.MoveQueen((ChessQueen)cb.Chessboard[7, 3].ChessPiece, 4, 0);
            Console.WriteLine("=================This is how the board is affected by the movement of a queen=================\n\n\n");
            cb.PrintChessPieces();
            cb.PrintCellIsOccupied();
            

            //tests to see the board state after a king is unsuccessfully moved
            //cb.MoveKing((ChessKing)cb.Chessboard[0, 3].ChessPiece, 1, 0);
            //Console.WriteLine("=================This is how the board is affected by the movement of a king=================\n\n\n");
            //cb.PrintChessPieces();
            //cb.PrintCellIsOccupied();
            //Console.ReadKey();f

        }
    }
}
