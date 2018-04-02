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
            StreamReader sr = new StreamReader(@"C:\Users\Liz\Documents\GitHub\Advent-of-Code-2017\Day2a\Day2a.txt");

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

            // Perform calculation
            string[] stringSeparator = new string[] {"\n"};
            string[] result;
            int checksum = 0;

            result = mySpreadsheet.Split(stringSeparator, StringSplitOptions.None);

            foreach (string line in result)
            {
                var row = line.Split(null as string[],StringSplitOptions.RemoveEmptyEntries);
                // default split on white space using null as string[]
                int[] rowValues = Array.ConvertAll(row,s => int.Parse(s));

                // find the difference between the maximum and minimum
                int rowDifference = rowValues.Max() - rowValues.Min();
                checksum = checksum + rowDifference;
            }
            Console.WriteLine(checksum.ToString());
            Console.ReadLine();
        }
    }
}