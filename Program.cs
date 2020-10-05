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
            MeAfterTen();
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
    }
}
