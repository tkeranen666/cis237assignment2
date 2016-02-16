using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 5000;

            /// <summary>
            /// Starting Coordinates.
            /// </summary>
            const int X_START = 1;
            const int Y_START = 1;

            char[,] maze1 = 
          { { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            { '#', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#' },
            { '#', '.', '#', '.', '#', '.', '#', '#', '#', '#', '.', '#' },
            { '#', '#', '#', '.', '#', '.', '.', '.', '.', '#', '.', '#' },
            { '#', '.', '.', '.', '.', '#', '#', '#', '.', '#', '.', '#' },
            { '#', '#', '#', '#', '.', '#', '.', '#', '.', '#', '.', '.' },
            { '#', '.', '.', '#', '.', '#', '.', '#', '.', '#', '.', '#' },
            { '#', '#', '.', '#', '.', '#', '.', '#', '.', '#', '.', '#' },
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '#' },
            { '#', '#', '#', '#', '#', '#', '.', '#', '#', '#', '.', '#' },
            { '#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '#' },
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' } };

            //Create the second maze by transposing the first maze
            char[,] maze2 = transposeMaze(maze1);

            MazeSolver mazeSolver = new MazeSolver();

            Console.WriteLine("First Maze");
            Console.WriteLine();
            // This calls the MazeSolver class to solve the first maze
            mazeSolver.SolveMaze(maze1, X_START, Y_START);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Second Maze");
            Console.WriteLine();
            // This calls the MazeSolver class to solve the transposed maze
            mazeSolver.SolveMaze(maze2, X_START, Y_START);
        }

        // The first maze is passed into a method which tranposes it by switching the X and Y values
        static char[,] transposeMaze(char[,] mazeToTranspose)
        {
            char[,] maze = new char[12, 12];
            for (int y = 0; y < 12; y++)
            {
                for (int x = 0; x < 12; x++)
                {
                    maze[x, y] = mazeToTranspose[y, x];
                }
            }
            return maze; // The transposed maze is returned here
        }
    }
}
