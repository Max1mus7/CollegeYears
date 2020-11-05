using System;

namespace KnightsTour
{
    class Program
    {
        static int BoardSize = 8;
        static int attemptedMoves = 0;

        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

        static int[,] boardGrid = new int[BoardSize, BoardSize];

        static void Main(string[] args)
        {
            SolveKT();
            Console.ReadKey();
        }

        static void SolveKT()
        {
            for(int i = 0; i < BoardSize; i++)
            {
                for(int j = 0; j < BoardSize; j++)
                {
                    boardGrid[i, j] = -1;
                }
            }
            int startX = 4;
            int startY = 4;

            boardGrid[startX, startY] = 0;

            attemptedMoves = 0;

            if(!SolveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution does not exist for {0} {1}", startX, startY);
            }
            else
            {
                PrintSolution(boardGrid);
                Console.WriteLine("Total attempted moves {0}", attemptedMoves);
            }
        }

        static bool SolveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0)
            {
                Console.WriteLine("Attempts {0}", attemptedMoves);
            }

            int nextX, nextY;

            if (moveCount == 64)
            {
                return true;
            }
            else
            {
                int[] validMoves = IsSquareSafe(x, y);
                if (validMoves[0] != -2)
                {
                    nextX = x + xMove[validMoves[0]];
                    nextY = y + yMove[validMoves[0]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }

                }

                if (validMoves[1] != -2)
                {
                    nextX = x + xMove[validMoves[1]];
                    nextY = y + yMove[validMoves[1]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }
                }

                if (validMoves[2] != -2)
                {
                    nextX = x + xMove[validMoves[2]];
                    nextY = y + yMove[validMoves[2]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }
                }
                if (validMoves[3] != -2)
                {
                    nextX = x + xMove[validMoves[3]];
                    nextY = y + yMove[validMoves[3]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }
                }
                if (validMoves[4] != -2)
                {
                    nextX = x + xMove[validMoves[4]];
                    nextY = y + yMove[validMoves[4]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }
                }
                if (validMoves[5] != -2)
                {
                    nextX = x + xMove[validMoves[5]];
                    nextY = y + yMove[validMoves[5]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }
                }
                if (validMoves[6] != -2)
                {
                    nextX = x + xMove[validMoves[6]];
                    nextY = y + yMove[validMoves[6]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }
                }
                if (validMoves[7] != -2)
                {
                    nextX = x + xMove[validMoves[7]];
                    nextY = y + yMove[validMoves[7]];
                    boardGrid[nextX, nextY] = moveCount;
                    if (!SolveKTUtil(nextX, nextY, moveCount + 1))
                    {
                        boardGrid[nextX, nextY] = -1;
                    }
                }
                
            }
            return false;
        }

        static int[] IsSquareSafe(int x, int y)
        {
            int[] validReturn = new int[8] { -2, -2, -2, -2, -2, -2, -2, -2 };
            int[] validMoves = new int[8] { -2, -2, -2, -2, -2, -2, -2, -2 };
            for (int i = 0; i < 8; i++)
            {
                int checkX = x + xMove[i];
                int checkY = y + yMove[i];
                if (checkX >= 0 && checkX < BoardSize && checkY >= 0 && checkY < BoardSize && boardGrid[checkX, checkY] == -1)
                {
                    validReturn[i] = CheckNeighborCount(checkX, checkY);
                    validMoves[i] = i;
                }

            }
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(validReturn[i] < validReturn[j])
                    {
                        int temp = validReturn[i];
                        validReturn[i] = validReturn[j];
                        validReturn[j] = temp;
                        int temp1 = validMoves[i];
                        validMoves[i] = validMoves[j];
                        validMoves[j] = temp1;
                    }
                }
            }
            return validMoves; 
        }

        static int CheckNeighborCount(int x, int y)
        {
            int count = 0;
            for(int i = -1; i <= 1; i++)
            {
                for(int j = -1; j <= 1; j++)
                {
                    if(x + i >= 0 && x + i < 8 && y + j >= 0 && y + j < 8 && i != 0 && j != 0)
                    {
                        if(boardGrid[x+i,y+j] != -1)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        static void PrintSolution(int[,] solution)
        {
            for(int i = 0; i < BoardSize; i++)
            {
                for(int j = 0; j < BoardSize; j++)
                {
                    Console.Write(solution[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
