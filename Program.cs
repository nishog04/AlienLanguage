using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlienLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "C:/Users/nisho/source/repos/AlienLanguage/file.txt";
            Translator translator = new Translator();

            translator.ReadFile(input);

            Console.ReadKey();
        }
    }
}
