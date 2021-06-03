using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {//1.47 a
            int n = 10;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i =0; i<n; i++)
            {
                mas[i] = r.Next(1, 30);
                Console.WriteLine(mas[i]);

            }
            Console.WriteLine();
            for (int i = 0; i<n; i++)
            {
                if (mas[i]>10)
                {
                    mas[i] = Math.Sqrt(mas[i]);
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
