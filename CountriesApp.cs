using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class CountriesApp
    {
        public static int DisplayMenu()
        {
            Console.WriteLine("1 - See the list of countries \n2 - Add a country \n3 - Exit");
            Console.Write("Enter menu number: ");

            int menuSelection = Validator.GetUserInput();

            return menuSelection;

        }

        public static void NavigateMenu(int menuSelection)
        {
            string countryInput;

            switch (menuSelection)
            {
                case 1:
                    CountriesTextFile.ReadCountriesFromFile();
                    break;
                case 2:
                    Console.Write("Enter a country: ");
                    countryInput = Console.ReadLine();
                    Validator.GetUserCountry(countryInput);
                    CountriesTextFile.WriteCountriesToFile(countryInput);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("That menu item doesn't exist.");
                    break;
            }
        }
    }
}
