using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch7_Fix_It_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch7 Fix It Exercises by Jared Tims\n");

            Food apples = new Food("Apples", 8.5);
            Food oranges = new Food("Oranges", 10.75);

            WriteLine($"Bushal of {apples.getName()} price: {apples.getPrice():C}. Discounted price: {apples.foodMarkUp():C}");
            WriteLine($"Bushal of {oranges.getName()} price: {oranges.getPrice():C}. Discounted price: {oranges.foodMarkUp():C}");

            Write("\nPress any key to continue...");
            ReadKey();
        }
    }
}
