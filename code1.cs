using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть х: ");

            double x = Convert.ToInt32(Console.ReadLine());
            double y;
            double s = 1;
            double z = 0;          

            if (x <= 0)
            {
                y = Math.Pow(x + 8,2) / 4;
                Console.WriteLine($"y = {y}");
            }
            
            else if (x < 15)
            {                
                for(double i=1; i < x+1; i++)
                {
                    z += (i / 2);
                }
                y = z;
                Console.WriteLine($"y = {y}");
            }

            else
            {
                for(double i = 15; i < x+1; i++)
                {
                    s = s * Math.Pow((i + 4), 1.5);
                }
                y = s + 10;
                Console.WriteLine($"y = {y}");
            }
            
            Console.ReadLine();
        }
    }
}
