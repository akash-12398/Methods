using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Excerise 1-----------

            // Name: Michael
            // Favorite Color: Blue
            // Favorite Animal: Walrus
            // Favorite Band: The Beatles



            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"My favorite color is {color}");

            Console.WriteLine($"What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"My favorite animal is {animal}");


            Console.WriteLine($"What band you like?");
            var band = Console.ReadLine();


            Console.WriteLine($"My favorite band is {band}");
        }
    }
}