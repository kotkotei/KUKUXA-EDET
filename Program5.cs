using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//11.52 B
            int n = 10;
            int z = 5;
            int b = 5;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 20);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    mas[i] = mas[i] + z;
                }
                else
                {
                    mas[i] = mas[i] - b;
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
                    

                
            


        }
    }
}
