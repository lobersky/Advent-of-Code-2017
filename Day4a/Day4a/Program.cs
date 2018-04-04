using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file content into a string array, each element is one line of file
            string[] passPhrasesList = System.IO.File.ReadAllLines(@"C:\Users\Liz\Documents\GitHub\Advent-of-Code-2017\Day4a\Day4a\Test.txt");
            string[] result;
            string currentWord = "";
            string[] stringSeparator = new string[] {" "};
            int validPassPhraseCount = 0;
            int wordCounter = 0;

            // Investigate the file contents by line

            foreach (string lineOfList in passPhrasesList)
            {
                result = lineOfList.Split(stringSeparator, StringSplitOptions.None);

                for (int i = 0; i < result.Length; i++)
                {
                    currentWord = result[i];

                    for (int j = 0; j < result.Length-i-1; j++)
                    {
                        if ((currentWord != result[j + 1]) && (j + 1 <= result.Length))
                        {
                            wordCounter++;

                            if (wordCounter == result.Length-1)
                            {
                                validPassPhraseCount++;
                                Console.WriteLine(validPassPhraseCount.ToString());
                            }
                        }
                    }
                }
            }
            Console.WriteLine(validPassPhraseCount.ToString());
            Console.ReadLine();
        }
    }
}
