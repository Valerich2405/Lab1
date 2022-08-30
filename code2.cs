using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1Сsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введiть довжину масиву: ");
            string r = Console.ReadLine();
            int n = int.Parse(s);
                        
            int[] arr = new int[n];
            Random rand = new Random();

            for(int i=0; i<n; i++)
            {
                arr[i] = rand.Next(-11, 11);
            }

            Console.WriteLine("Згенерований масив: ");
            
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if(arr[i] == 0)
                {
                    Console.WriteLine("Iндекс першого нульового елемента = " + i);
                    break;
                }

                else
                {
                    Console.WriteLine("Масив не мiстить нульових елементiв.");
                    break;
                }
            }          
            System.Console.ReadLine();
        }
    }
}
