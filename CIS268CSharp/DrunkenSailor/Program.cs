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


            //Setup and variable intializer
 
            int rndCounter;
            int cols = 40;
            int rows = 40;
            String[,] Grid = new String[cols, rows];


            //Random Number Generator
            Random rnd = new Random(); //Random Number initializer
            Random rnd2 = new Random(); //Random Number initializer
            int rndPiratePlacer = rnd.Next(0, rows);
            int rndPiratePlacer2 = rnd2.Next(0, rows);



            // Randomly place drunken pirate on left side before displaying to the user.
            Grid[rndPiratePlacer, 0] = "!";

            int i;
            // Setup Grid for displaying to user (using a nested for-loop)  and randomly move pirate to the right side
            for (i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Grid[i, j] = "%";//print grid
                    rndPiratePlacer = rnd.Next(0, rows);//gen random number
                    Grid[rndPiratePlacer, rndPiratePlacer2] = "!"; //Move it to a random place.
                    Console.Write(Grid[i, j]);
                }

            }






            Console.ReadLine(); //Pause and wait for user input before exiting
        }
    }
}
