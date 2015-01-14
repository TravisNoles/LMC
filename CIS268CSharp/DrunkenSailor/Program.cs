using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenSailor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Place "DrunkenSailor" object at random location at the side of the console screen.
            // When "DrunkenSailor" object reaches the right side of the console screen, end the program.
            // Draw a grid on the screen, and track the path that the "DrunkenSailor" takes.

            int cols = 20;
            int rows = 20;
            int[,] Grid = new int[cols, rows];


            // Setup Grid for displaying to user (using a nested for-loop)
            int index;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Grid[i,j] = 5;
                }
            }

            //Print Grid to user.
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.WriteLine(Grid[i, j]);
                }
            }

           



            Console.ReadLine();





        }
    }
}
