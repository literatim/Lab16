using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!");

            int menuSelection = CountriesApp.DisplayMenu();

            do
            {
                CountriesApp.NavigateMenu(menuSelection);
                menuSelection = CountriesApp.DisplayMenu();

            } while (menuSelection != 3);


            Console.WriteLine("Bye!");
            Console.ReadKey();


        }
    }
}
