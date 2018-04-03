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
            int inputInteger = int.Parse(inputString);

            // Generate the spiral
            int accessPort = 1;
            int instruction = inputInteger - accessPort;

            // Values to print
            //int[] myNumbers = new int[inputInteger];
            //int count = 0;
            bool isAddition = true;
            // isAddition = (instruction % 2 != 0);
            int x = 0;
            int y = 0;

            // for displaying parameters
            //for (int i = 0; i < inputInteger; i++)
            //{
            //    count++;
            //    myNumbers[i] = count;
            //}

            for (int j = 0; j < instruction; j++)
            {
                if (isAddition)
                {
                    y = (y + 1);
                    Console.WriteLine("Co-ordinate: ({0},{1})", x.ToString(), y.ToString());
                    Console.WriteLine("in addition true case");
                }
                else
                {
                    y = (y - 1);
                    x = (x - 1);
                    isAddition = true;
                    Console.WriteLine("in addition false case");
                }
            }

            // Output result of steps
            int numberSteps = 0;
            numberSteps = Math.Abs(x + y);

            Console.WriteLine(numberSteps.ToString());

            Console.ReadLine();
        }
    }
}