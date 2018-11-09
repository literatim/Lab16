using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab16
{
    class CountriesTextFile
    {
        public static void WriteCountriesToFile(string countryInput)
        {
            using (StreamWriter file =
                new StreamWriter(@"C:\dev\GrandCircus\Lab16\countries.txt", true))
            {
                file.WriteLine(countryInput);
            }
            Console.WriteLine("This country has been saved!");
        }

        public static void ReadCountriesFromFile()
        {
            using (StreamReader file =
                new StreamReader(@"C:\dev\GrandCircus\Lab16\countries.txt"))
            {

                Console.WriteLine(file.ReadToEnd());
            }
        }
    }
}
