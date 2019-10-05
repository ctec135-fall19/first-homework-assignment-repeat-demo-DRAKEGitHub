using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up console UI (CUI)
            Console.Title = "My First Assignment";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("***************************");
            Console.WriteLine("*** My First Assignment ***");
            Console.WriteLine("***  by Allison Drake   ***");
            Console.WriteLine("***************************");
            Console.WriteLine();
            Console.WriteLine("       Hello World!        ");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;

            SportsCar myCar = new SportsCar();
            myCar.PetName = "Lucy";
            Console.WriteLine("My car's petname is {0}", myCar.GetPetName());

            //Wait for Enter key to be pressed.
            Console.ReadLine();

            //Instantiates SportsCar object and prints its name

        }
    }
}
