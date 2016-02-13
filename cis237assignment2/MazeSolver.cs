using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;

        int xStart;
        int yStart;

        char path = 'X';
        char deadEnd = '0';

        char userInput;

        bool finish = false;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class.
            //It is possible that you will not need these class level ones and can get all of the work done
            //with the local ones. Regardless of how you implement it, here are the class level assignments.
            //Feel free to remove the class level variables and assignments if you determine that you don't need them.
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;


            Console.WriteLine("Welcome to the Maze. Please use the 'w', 'a', 's', and 'd' keys to navigate.");
            Console.WriteLine("w = up" + Environment.NewLine + "a = left" + Environment.NewLine + "d = right" +
                               Environment.NewLine + "s = down");
            PrintMaze();

            //while (finish == false)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    userInput = Convert.ToChar(Console.ReadLine());

            //    mazeTraversal();
            //}

            if (finish == true)
            {
                Console.WriteLine("CONGRATULATIONS!!!!!!");
            }

            //Do work needed to use mazeTraversal recursive call and solve the maze.
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal()
        {
            //Implement maze traversal recursive call
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
