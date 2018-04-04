using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for puzzle input
            Console.WriteLine("Define puzzle input for spiral:");

            // Read in puzzle input
            string inputString = Console.ReadLine();

            // Convert to integer value
            int inputNumber = int.Parse(inputString);

            // Generate the spiral
            int stepCount = 1; // start at 1
            int currentNumber = 1; // start at 1
            bool shouldStepsIncrease = true;

            // Position co-ordinates
            // Initialise at the origin (0,0)
            int x = 0;
            int y = 0;

            // directionStep values and meaning
            int directionStep = 0;
            // directionStep = 0 == Right
            // directionStep = 1 == Up
            // directionStep = 2 == Left
            // directionStep = 3 == Down


            while (currentNumber < inputNumber)
            {
                

                for (int i = 0; i < stepCount; i++)
                {
                    // Increment the current number
                    currentNumber++;

                    // Take a step based on directionStep value
                    if (directionStep ==0)
                    {
                        y++;
                    }

                    if (directionStep ==1)
                    {
                        x++;
                    }

                    if (directionStep == 2)
                    {
                        y--;
                    }

                    if (directionStep ==3)
                    {
                        x--;
                    }

                    if (currentNumber == inputNumber)
                    {
                        break;
                    }
                }

                shouldStepsIncrease = !shouldStepsIncrease;

                if (shouldStepsIncrease)
                {
                    stepCount++;
                }

                // Print co-ordinates
                Console.WriteLine("({0},{1})", x, y);

                // Increase direction anti-clockwise for the next step
                directionStep++;
                // Check not out of bounds by mod 4
                directionStep = directionStep % 4;
            }

            // Get co-ordinates x and y and output number of steps as Manhattan distance
            int numberStepsToAccessPoint = 0;
            numberStepsToAccessPoint = Math.Abs(x) + Math.Abs(y);

            Console.WriteLine(numberStepsToAccessPoint.ToString());

            Console.ReadLine();
        }
    }
}