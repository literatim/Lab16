using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Validator
    {
        public static int GetUserInput()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.Write("Enter menu number: ");
            }

            return input;
        }

        public static string GetUserCountry(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Country cannot be blank!");
                Console.Write("Enter country: ");
                Console.ReadLine();
            }

            return input;
        }
    }
}
