using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper;

namespace MinesweeperGame
{
    class Program
    {

        //Main method, makes the board and shows a board that is set up
        static void Main(string[] args)
        {
            Console.WriteLine("Please input how large you would like your board to be(14 at most):");
            int size = int.Parse(Console.ReadLine());
            Board board = new Board(size);
            Console.WriteLine("On a scale of 1 to 100, how difficult would you like the game to be?");
            int diff = int.Parse(Console.ReadLine());
            board.Difficulty = diff;
            board.SetupLiveNeighbors(board.Difficulty);
            board.CalculateLiveNeighbors();
            bool ended = false;

            while(!ended)
            {
                PrintBoardDuringGame(board);
                Console.WriteLine("\nPlease input a row number");
                int row = int.Parse(Console.ReadLine())-1;
                Console.WriteLine("Please input a column number");
                int column = int.Parse(Console.ReadLine())-1;
                board.Grid[row, column].Visited = true;
                board.RevealSafeNeighbors(row, column);
                ended = CheckGameEnded(board, row, column);
                
            }
            PrintBoard(board);
            Console.ReadKey();

        }
        //checks to see if the game has ended
        static bool CheckGameEnded(Board board, int row, int col)
        {
            if (board.Grid[row, col].Live && board.Grid[row, col].Visited)
            {
                Console.WriteLine("You have hit a bomb and the game is over!");
                return true;
            }
            for (int i = 0; i < board.Size; i++)
            {
                for(int j = 0; j < board.Size; j++)
                { 
                    if(!board.Grid[i,j].Live && !board.Grid[i,j].Visited)
                    {
                        return false;
                    }
                }
            }
            Console.WriteLine("You have won the game! Congratulations!");
            return true;
        }
        //Defines a method to print out the grid in a text representation
        static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("  " + (i + 1) + " \t");
            }
            Console.WriteLine();
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("________");
            }
            Console.WriteLine();
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < board.Size; j++)
                {
                    Console.Write("+---+\t");
                }
                Console.Write("| ");
                Console.WriteLine();
                Console.Write("| ");
                for (int j = 0; j < board.Size; j++)
                {
                    Console.Write("| ");
                    if (board.Grid[i, j].Live)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(board.Grid[i, j].LiveNeighbors);
                    }
                    Console.Write(" |\t");
                }
                Console.Write("| " + (i + 1));
                Console.WriteLine();
                Console.Write("| ");
                for (int j = 0; j < board.Size; j++)
                {
                    Console.Write("+---+\t");
                }
                Console.Write("| ");
                Console.WriteLine();
            }
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("________");
            }
            Console.Write("|");
        }
        //prints a string representation of the current game
        static void PrintBoardDuringGame(Board board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("  " + (i + 1) + " \t");
            }
            Console.WriteLine();
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("________");
            }
            Console.WriteLine();
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < board.Size; j++)
                {
                    Console.Write("+---+\t");
                }
                Console.Write("| ");
                Console.WriteLine();
                Console.Write("| ");
                for (int j = 0; j < board.Size; j++)
                {
                    Console.Write("| ");
                    if(board.Grid[i,j].Visited)
                    {
                        if(board.Grid[i,j].Live)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(board.Grid[i, j].LiveNeighbors);
                        }
                       
                    }
                    else
                    {
                        Console.Write("?");
                    }
                    Console.Write(" |\t");
                }
                Console.Write("| " + (i + 1));
                Console.WriteLine();
                Console.Write("| ");
                for (int j = 0; j < board.Size; j++)
                {
                    Console.Write("+---+\t");
                }
                Console.Write("| ");
                Console.WriteLine();
            }
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("________");
            }
            Console.Write("|");
        }
    }
}
