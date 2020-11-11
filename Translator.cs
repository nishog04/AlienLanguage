using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlienLanguage
{
    class Translator
    {
        private int[] ldn = new int[3];
        private List<string> dictionary = new List<string>();
        

        //Read from file
        public void ReadFile(string input)
        {
            StreamReader sr = File.OpenText(input);
            CreateLdn(sr);
            CreateDictionary(sr);
            Solve(sr);
            sr.Close();

        }

        //Create array of the first line
        private bool CreateLdn(StreamReader sr)
        {
            bool flag = false;
            string[] temp = sr.ReadLine().Split(' ');

            if (temp.Length > 0)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    ldn[i] = SetLDN(temp[i], ldn[i]);
                }
            }

            if (ldn.Length == 3)
            {
                flag = true;
            }

            return flag;
        }

        //Parse string to int
        private int SetLDN(string inputString, int inputInt)
        {
            inputInt = int.Parse(inputString);
            return inputInt;
        }

        //Create list containing the "dictionary"
        private bool CreateDictionary(StreamReader sr)
        {
            bool flag = false;

            for (int i = 0; i < ldn[1]; i++)
            {
                dictionary.Add(sr.ReadLine());
            }

            if (dictionary.Count == ldn[1])
            {
                flag = true;
            }

            return flag;
        }

        //Match strings
        private void Solve(StreamReader sr)
        {
            for (int i = 0; i < ldn[2]; i++)
            {
                Regex pattern = new Regex("^" + sr.ReadLine().Replace("(", "[").Replace(")", "]") + "$");
                int match = 0;

                foreach (var word in dictionary)
                {
                    if (pattern.IsMatch(word))
                    {
                        match++;
                    }
                }

                Console.WriteLine("Case #{0}: {1}", i + 1, match);
            }
        }
    }
}
