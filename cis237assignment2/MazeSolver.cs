using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment2
{
    class MazeSolver
    {
        // Class level memeber variable for the mazesolver class
        char[,] maze;

        int xStart;
        int yStart;

        // This bool is used to stop the recursion method
        bool finish = false;

        
        // Default Constuctor to setup a new maze solver.
        public MazeSolver()
        {}

        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            // This sets the finish boolean to false so the transposed array works properly
            finish = false;

            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            Console.WriteLine();
            Console.WriteLine();

            mazeTraversal(maze, xStart, yStart);
        }

        // The array and index values are passed into the recursion method
        private void mazeTraversal(char[,] maze, int xIndex, int yIndex)
        {
            //Implement maze traversal recursive call
            Console.WriteLine();
            Console.WriteLine();
            PrintMaze();

            // Base case makes sure the console stays within the bounderies of the array
            if (xIndex != maze.GetLength(0) - 1 && yIndex != maze.GetLength(0) - 1 &&
                xIndex != 0 && yIndex != 0)
            {
                // If there's a path above the current position the program will go there
                if (maze[xIndex - 1, yIndex] == '.' && finish != true) // left -- up
                {
                    maze[xIndex, yIndex] = 'X';
                    mazeTraversal(maze, xIndex - 1, yIndex);

                    //If the program can't go up, the program will mark any dead ends with 0's
                    if (finish == false)
                    {
                        maze[xIndex - 1, yIndex] = '0';
                        maze[xIndex, yIndex] = '0';
                    }
                }

                // If there's a path below the current position the program will go there
                if (maze[xIndex + 1, yIndex] == '.' && finish != true) // rigth -- down
                {
                    maze[xIndex, yIndex] = 'X';
                    mazeTraversal(maze, xIndex + 1, yIndex);

                    //If the program can't go down, the program will mark any dead ends with 0's
                    if (finish == false)
                    {
                        maze[xIndex + 1, yIndex] = '0';
                        maze[xIndex, yIndex] = '0';
                    }
                }

                // If there's a path to the left of the current position the program will go there
                if (maze[xIndex, yIndex - 1] == '.' && finish != true) // up -- left
                {
                    maze[xIndex, yIndex] = 'X';
                    mazeTraversal(maze, xIndex, yIndex - 1);

                    //If the program can't go left, the program will mark any dead ends with 0's
                    if (finish == false)
                    {
                        maze[xIndex, yIndex - 1] = '0';
                        maze[xIndex, yIndex] = '0';
                    }
                }

                // If there's a path to the right of the current position the program will go there
                if (maze[xIndex, yIndex + 1] == '.' && finish != true) // down -- right
                {
                    maze[xIndex, yIndex] = 'X';
                    mazeTraversal(maze, xIndex, yIndex + 1);

                    //If the program can't go right, the program will mark any dead ends with 0's
                    if (finish == false)
                    {
                        maze[xIndex, yIndex + 1] = '0';
                        maze[xIndex, yIndex] = '0';
                    }
                }
            }
            else // If the program reaches the end of the maze, the console with set the finish boolean to true
            {   // and stop the recursion method, and the value of the exit will be changed to 'X'
                finish = true;
                maze[xIndex, yIndex] = 'X';

                Console.WriteLine();
                Console.WriteLine();
                PrintMaze();
            }
        }

        private void PrintMaze()
        {
            Console.WriteLine(maze[0, 0].ToString() + maze[0, 1].ToString() + maze[0, 2].ToString() + maze[0, 3].ToString() + maze[0, 4].ToString() +
                              maze[0, 5].ToString() + maze[0, 6].ToString() + maze[0, 7].ToString() + maze[0, 8].ToString() + maze[0, 9].ToString() +
                              maze[0, 10].ToString() + maze[0, 11].ToString());
            Console.WriteLine(maze[1, 0].ToString() + maze[1, 1].ToString() + maze[1, 2].ToString() + maze[1, 3].ToString() + maze[1, 4].ToString() +
                              maze[1, 5].ToString() + maze[1, 6].ToString() + maze[1, 7].ToString() + maze[1, 8].ToString() + maze[1, 9].ToString() +
                              maze[1, 10].ToString() + maze[1, 11].ToString());
            Console.WriteLine(maze[2, 0].ToString() + maze[2, 1].ToString() + maze[2, 2].ToString() + maze[2, 3].ToString() + maze[2, 4].ToString() +
                              maze[2, 5].ToString() + maze[2, 6].ToString() + maze[2, 7].ToString() + maze[2, 8].ToString() + maze[2, 9].ToString() +
                              maze[2, 10].ToString() + maze[2, 11].ToString());
            Console.WriteLine(maze[3, 0].ToString() + maze[3, 1].ToString() + maze[3, 2].ToString() + maze[3, 3].ToString() + maze[3, 4].ToString() +
                              maze[3, 5].ToString() + maze[3, 6].ToString() + maze[3, 7].ToString() + maze[3, 8].ToString() + maze[3, 9].ToString() +
                              maze[3, 10].ToString() + maze[3, 11].ToString());
            Console.WriteLine(maze[4, 0].ToString() + maze[4, 1].ToString() + maze[4, 2].ToString() + maze[4, 3].ToString() + maze[4, 4].ToString() +
                              maze[4, 5].ToString() + maze[4, 6].ToString() + maze[4, 7].ToString() + maze[4, 8].ToString() + maze[4, 9].ToString() +
                              maze[4, 10].ToString() + maze[4, 11].ToString());
            Console.WriteLine(maze[5, 0].ToString() + maze[5, 1].ToString() + maze[5, 2].ToString() + maze[5, 3].ToString() + maze[5, 4].ToString() +
                              maze[5, 5].ToString() + maze[5, 6].ToString() + maze[5, 7].ToString() + maze[5, 8].ToString() + maze[5, 9].ToString() +
                              maze[5, 10].ToString() + maze[5, 11].ToString());
            Console.WriteLine(maze[6, 0].ToString() + maze[6, 1].ToString() + maze[6, 2].ToString() + maze[6, 3].ToString() + maze[6, 4].ToString() +
                              maze[6, 5].ToString() + maze[6, 6].ToString() + maze[6, 7].ToString() + maze[6, 8].ToString() + maze[6, 9].ToString() +
                              maze[6, 10].ToString() + maze[6, 11].ToString());
            Console.WriteLine(maze[7, 0].ToString() + maze[7, 1].ToString() + maze[7, 2].ToString() + maze[7, 3].ToString() + maze[7, 4].ToString() +
                              maze[7, 5].ToString() + maze[7, 6].ToString() + maze[7, 7].ToString() + maze[7, 8].ToString() + maze[7, 9].ToString() +
                              maze[7, 10].ToString() + maze[7, 11].ToString());
            Console.WriteLine(maze[8, 0].ToString() + maze[8, 1].ToString() + maze[8, 2].ToString() + maze[8, 3].ToString() + maze[8, 4].ToString() +
                              maze[8, 5].ToString() + maze[8, 6].ToString() + maze[8, 7].ToString() + maze[8, 8].ToString() + maze[8, 9].ToString() +
                              maze[8, 10].ToString() + maze[8, 11].ToString());
            Console.WriteLine(maze[9, 0].ToString() + maze[9, 1].ToString() + maze[9, 2].ToString() + maze[9, 3].ToString() + maze[9, 4].ToString() +
                              maze[9, 5].ToString() + maze[9, 6].ToString() + maze[9, 7].ToString() + maze[9, 8].ToString() + maze[9, 9].ToString() +
                              maze[9, 10].ToString() + maze[9, 11].ToString());
            Console.WriteLine(maze[10, 0].ToString() + maze[10, 1].ToString() + maze[10, 2].ToString() + maze[10, 3].ToString() + maze[10, 4].ToString() +
                              maze[10, 5].ToString() + maze[10, 6].ToString() + maze[10, 7].ToString() + maze[10, 8].ToString() + maze[10, 9].ToString() +
                              maze[10, 10].ToString() + maze[10, 11].ToString());
            Console.WriteLine(maze[11, 0].ToString() + maze[11, 1].ToString() + maze[11, 2].ToString() + maze[11, 3].ToString() + maze[11, 4].ToString() +
                              maze[11, 5].ToString() + maze[11, 6].ToString() + maze[11, 7].ToString() + maze[11, 8].ToString() + maze[11, 9].ToString() +
                              maze[11, 10].ToString() + maze[11, 11].ToString());
        }
    }
}
