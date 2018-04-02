using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2a
{
    class Program
    {
        public static string mySpreadsheet = "";
        public static int rowCount = 0;

        static void Main(string[] args)
        {
            // Specify file path
            StreamReader sr = new StreamReader(@"C:\Users\Liz\Documents\GitHub\Advent-of-Code-2017\Day2a\Day2a\Test1.txt");

            // File path for test case: C:\Users\Liz\Documents\GitHub\Advent-of-Code-2017\Day2a\Day2a\Test1.txt
            // File path for Day2a case: C:\Users\Liz\Documents\GitHub\Advent-of-Code-2017\Day2a\Day2a.txt

            try
            {
                // Read line first line
                mySpreadsheet = sr.ReadToEnd();
                Console.WriteLine(mySpreadsheet);
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            finally
            {
                // Close text file
                sr.Close();
            }

            // Count the number of rows of data
            LinesCount();
            rowCount++;

            // Convert string to array of integers
            int[] myNumbers = new int[mySpreadsheet.Length];

            for (int i = 0; i < mySpreadsheet.Length; i++)
            {
                myNumbers[i] = mySpreadsheet[i];
            }

            for (int i = 0; i < rowCount; i++)
            {

            }
           
            Console.ReadLine();
        }

        static long LinesCount()
        {
            // Check how many lines there are from new line '/n'

            int lineStart = -1;
            while ((lineStart = mySpreadsheet.IndexOf('\n', lineStart+1)) != -1)
            {
                rowCount++;
            }
            return rowCount;
        }
    }
}
