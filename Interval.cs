using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter anything to start and end to exit");
            string input = Console.ReadLine();
            while (input != "end")
            {

                Console.WriteLine("Enter a real number: ");
                double x = Convert.ToDouble(Console.ReadLine());

                bool belongsI = (x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2);

                if (belongsI)
                {
                    Console.WriteLine("x belongs to I");

                }
                else
                {
                    Console.WriteLine("x does not belong to I");
                }
                Console.ReadLine();
            }
        }
    }
}
