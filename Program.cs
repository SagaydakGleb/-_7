using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a>=0&a<=60)
            {
                Console.WriteLine("НЕУДОВЛЕТВОРИТЕЛЬНО");
            }
            else if(a>60&a<=74)
            {
                Console.WriteLine("УДОВЛЕТВОРИТЕЛЬНО");
            }
             else if(a>74&a<=89)
            {
                Console.WriteLine("ХОРОШО");
            }
            else if(a>89&a<=100)
            {
                Console.WriteLine("ОТЛИЧНО");
            }

            Console.ReadKey();
            
        }

    }
}
