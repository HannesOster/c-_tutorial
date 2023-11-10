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
            Console.WriteLine("Wie alt bist du?");
            
           int age = Convert.ToInt32(Console.ReadLine());
            bool withAdult = false;
            if (age >=12)
            {
                Console.WriteLine("Kauf erlaubt.");
            }
            else if (withAdult == true)
            {
                Console.WriteLine("Erwachsener dabei, kauf möglich.");
              
            }
            else
            {
                Console.WriteLine("Kein kauf möglich");
            }
        }
    }
}