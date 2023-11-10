using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        static void Main()
        {
            string name;
            int age;

            Console.WriteLine("Bitte Namen eingeben:");
            name = Console.ReadLine();

            Console.WriteLine("Bitte alter eingeben:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hallo " + name + ", du bist " + age + " Jahre alt.");
                

        }
    }
}