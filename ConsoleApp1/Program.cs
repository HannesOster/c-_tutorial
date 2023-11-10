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
            int number1 = Subtrahiere(10, 3);
            int number2 = Subtrahiere(7, 2);

            Output(number1);
            Output(number2);
            Output(number1 + number2);
        }
            static int Subtrahiere(int a, int b)
            {
                int result = a - b;
                return result;
            }
        static void Output(int number)
        {
            Console.WriteLine(number);
        }
    }
}