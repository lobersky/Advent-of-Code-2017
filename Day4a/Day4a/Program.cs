﻿using System;
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
            string[] passPhrasesList = System.IO.File.ReadAllLines(@"C:\Users\Liz\Documents\GitHub\Advent-of-Code-2017\Day4a\Day4a\Input.txt");
            int validCount = 0;

            // Investigate the file contents by each passPhrase (line-by-line)
            foreach (string passPhrase in passPhrasesList)
            {
                if (isValidPassPhrase(passPhrase))
                {
                    validCount++;
                }
            }
            Console.WriteLine("Number of valid pass phrases is: {0}", validCount.ToString());
            Console.ReadLine();
        }

        // Helper method isValidPassPhrase
        private static bool isValidPassPhrase(string passPhrase)
        {
            string[] stringSeparator = new string[] { " " };
            string[] words = passPhrase.Split(stringSeparator, StringSplitOptions.None);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i+1; j < words.Length; j++)
                {
                    if (i==j)
                    {
                        continue;
                    }

                    if (words[i] == words[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}