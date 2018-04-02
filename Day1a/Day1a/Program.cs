using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for sequence
            Console.WriteLine("Enter your sequence of digits to solve captcha:");
            
            // Read in and store as a string
            string myString = Console.ReadLine();

            // Convert from a string to a character array
            var mySequence = myString.ToCharArray(); 

            // Check for a match
            for (int i = 0; i < mySequence.Length; i++)
            {
                if (i + 1 < mySequence.Length)
                {
                    if (mySequence[i + 1] == mySequence[i])
                    {
                        Console.WriteLine("match detected");
                        int digitStart = (int)Char.GetNumericValue(mySequence[i]);
                        int digitMatch = (int)Char.GetNumericValue(mySequence[i + 1]);
                        int digitValue = digitMatch;
                        Console.WriteLine(digitValue.ToString());
                    }
                }

                if (mySequence[0] == mySequence[i])
                {
                    Console.WriteLine("match detected");
                    int digitStart = (int)Char.GetNumericValue(mySequence[0]);
                    int digitMatch = (int)Char.GetNumericValue(mySequence[i]);
                    int digitValue = digitMatch;
                    Console.WriteLine(digitValue.ToString());
                }
            }
            Console.ReadLine(); 
        }
    }
}
