using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch7_Fix_It_Exercises
{
    internal class Food
    {
        private string name;
        private double price;
        static public double markup = .02;

        //default constructor
        public Food()
        {

        }
        //overloaded constructor
        public Food(string n, double p)
        {
            name = n;
            price = p;
        }

        //getters (make private variables available or visible to the outside)
        public string getName()
        {
            return name;
        }
        public double getPrice()
        {
            return price;
        }
        public static double getMarkUp()
        {
            return markup;
        }

        //setters
        public double foodMarkUp()
        {
            double markUpPrice = price * markup;
            markUpPrice = price - markUpPrice;

            return markUpPrice;
        }
    }
}
