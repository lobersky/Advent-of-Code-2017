using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for sequence
            Console.WriteLine("Input sequence:)");

            // Read in and store as a string
            string myString = Console.ReadLine(); 

            // Convert from a string to a character array
            var mySequence = myString.ToCharArray();

            // Initialise Result Array
            int[] myResult = new int[mySequence.Length];

            // Get the size of the step 
            int myStep = mySequence.Length / 2;

            // Check for a match
            for (int i = 0; i < mySequence.Length; i++)
            {
                if (i + myStep < mySequence.Length)
                {
                    if (mySequence[i + myStep] == mySequence[i])
                    {
                        Console.WriteLine("Match detected");
                        int digitMatch = (int)Char.GetNumericValue(mySequence[i + myStep]);
                        myResult[i] = digitMatch;
                    }
                    else
                    {
                        Console.WriteLine("No match detected");
                        myResult[i] = 0;
                    }
                }

                else if (mySequence[myStep] == mySequence[i])
                    {
                        Console.WriteLine("Match detected");
                        int digitMatch = (int)Char.GetNumericValue(mySequence[myStep]);
                        myResult[i] = digitMatch;
                    }


                else if (mySequence[mySequence.Length - myStep-1] == mySequence[i])
                    {
                        Console.WriteLine("Match detected");
                        int digitMatch = (int)Char.GetNumericValue(mySequence[mySequence.Length - myStep - 1]);
                        myResult[i] = digitMatch;
                    }

                    else
                    {
                        Console.WriteLine("No match detected");
                        myResult[i] = 0;
                    }
            }

            // Print contents of result string for logic check
            Console.WriteLine("[{0}]", string.Join(", ", myResult));

            // Sum the result array
            int sum = myResult.Sum();

            // Print final answer
            Console.WriteLine("The final result is: {0}", sum.ToString());
            Console.ReadLine();
        }
    }
}