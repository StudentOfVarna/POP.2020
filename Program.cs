using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Result();
        }

        static void MeAfterTen()
        {
            Console.WriteLine("What is your age ?");
            string ageAsString = Console.ReadLine();
            int age;
            age = int.Parse(ageAsString);
            //age = Convert.ToInt32(ageAsString);
            int ageten = age + 10;
            Console.WriteLine("Your age in 10 years will be " + ageten);
            Console.ReadKey();
        }

        private static void MeAfterTen2()
        {
            Console.Write("Please enter your age: ");
            string ageAsString = Console.ReadLine();

            bool parseResult = int.TryParse(ageAsString, out int ageAsInt);

            if (parseResult == true)
            {
                int ageAfterTen = ageAsInt + 10;

                Console.WriteLine($"Your age after 10 years will be {ageAfterTen} years");
            }
            else
            {
                Console.WriteLine($"Error!!!");
            }
        }

        private static void SimpleFormulasRectangle()
        {
            Console.WriteLine("You have a rectangle so tell the length of the sides");
            Console.WriteLine("Please enter one side: ");
            int side = int.Parse(Console.ReadLine());
            Console.Write("Please enter other side: ");
            int sideOther = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is" + side * sideOther);
            Console.WriteLine("The perimeter of the rectangle is" + 2 * (side + sideOther));
            Console.ReadKey();

            Console.Clear();
        }
        private static void SimpleFormulasTriangle()
        {

            Console.WriteLine("The same with the triangle");
            Console.Write("Please enter side A: ");
            int sideA = int.Parse(Console.ReadLine());
            Console.Write("Please enter side B: ");
            int sideB = int.Parse(Console.ReadLine());
            Console.Write("Please enter side C: ");
            int sideC = int.Parse(Console.ReadLine());
            Console.Write("Please enter height: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the triangle is " + (sideA * height) / 2.0);
            Console.WriteLine("The perimeter of the triangle is " + (sideA + sideB + sideC));
            Console.ReadKey();

            Console.Clear();
        }

        private static void SimpleFormulasCircle()
        { 
            Console.WriteLine("The same with the circle");
            Console.Write("Please enter radius: ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the triangle is " + (Math.PI * (radius) * radius) );
            Console.WriteLine("The perimeter of the triangle is " + 2 * Math.PI * radius);
            Console.ReadKey();

        }

        private static void Dates()
        {
            DateTime date = DateTime.Now;

            Console.Write("Current date: ");
            Console.WriteLine(date.ToShortDateString());

            Console.Write("Current time: ");
            Console.WriteLine(date.ToShortTimeString());

            Console.Write("Date after 10 years: ");
            Console.WriteLine(date.AddYears(10).ToShortDateString());

            Console.Write("Please enter a period: ");
            int period = int.Parse(Console.ReadLine());
            Console.Write($"Date after {period} years: ");
            Console.WriteLine(date.AddYears(period).ToShortDateString());
            Console.ReadKey();
        }

        private static void FutureBirthday()
        {
            Console.WriteLine("Your future birthday");
            Console.Write("Please enter your current age: ");
            int ageNow = int.Parse(Console.ReadLine());
            Console.Write("Please enter your future age: ");
            int ageFuture = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birthday month: ");
            int birthdayMonth = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birthday day of month: ");
            int birthdayDay = int.Parse(Console.ReadLine());

            DateTime date = DateTime.Now;
        }

        //Homework 1/3

        //1
        private static void HelloName()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("My name is Gatien.");
            Console.ReadKey();
        }


        //2
        private static void SumOfTwoNumbers()
        {
            Console.WriteLine("The Sum of Two Numbers:");
            Console.Write("Please enter the first number: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int numberB = int.Parse(Console.ReadLine());
            Console.Write(numberA + "+" +numberB +"=" + numberA+numberB);
            Console.ReadKey();
        }
        //3
        private static void Result()
        {
            Console.WriteLine("The result of -1 + 4 * 6 is :");
            Console.WriteLine((-1) + 4 * 6);
            Console.WriteLine("The result of ( 35+ 5 ) % 7 is :");
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine("The result of 14 + -4 * 6 / 11 is :");
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine("The result of 2 + 15 / 6 * 1 - 7 % 2 is :");
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadKey();
        }
    }
}
