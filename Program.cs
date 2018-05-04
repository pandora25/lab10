using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\twlecome to the Circle Tester !!");
            int count = 0;
            bool repeat = true;
            while (repeat)
            {
                count++;
                Console.Write("enter Radius ?");
                double radius = double.Parse(Console.ReadLine());
                           
                Circule objects = new Circule(radius);

                Console.WriteLine($"Circumference:{objects.CalculateCircumference()}\n");

                Console.WriteLine($"Area:{objects.CalculateArea()}\n");

                repeat = Confirmation("Continue? (y/n)");
            }
            Console.WriteLine($"You Created {count} Circule Object");
        }

        //method for y or n
        public static bool Confirmation(string message)
        {
            Console.WriteLine(message);
            string input1 = Console.ReadLine().ToLower();
            while ((!Regex.IsMatch(input1, @"^[n|y]$")))
            {
                Console.WriteLine("invalid entery please enter the 'y' or 'n')");
                input1 = Console.ReadLine();
            }
            return input1 == "y";
        }

        //method for is the string number between 0-9
        //public static double RadiusConfirmation(string message)
        //{
        //    Console.WriteLine(message);
        //    string input = Console.ReadLine();
        //    while ((!Regex.IsMatch(input, @"^[0-9]{1,30}$")))
        //    {
        //        Console.WriteLine("invalid entery please enter the 'y' or 'n')");
        //        input = Console.ReadLine();
        //    }
        //    return input;
        //}
    }
}
