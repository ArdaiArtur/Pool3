using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate numere vrei sa aiba vectorul");
           
            int n = Convert.ToInt32(Console.ReadLine()); 
           
            int[] v = new int[n]; int[] w = new int[n];
            for (int i = 0; i < n; i++) {
               
                v[i] = Convert.ToInt32(Console.ReadLine());

            }
            int d = 0;
            Console.WriteLine("Cate ori vrei sa rotest");

            int k = Convert.ToInt32(Console.ReadLine());
            do
            {
                int b = 0; b = v[0];
                for (int i = 0; i < n; i++)
                {
                    if (i != n - 1)
                        v[i] = v[i + 1];
                    else v[i] = b;
                }
                d++;
            } while (d != k);

                    Console.WriteLine("vectorul");
            for (int j=0;j<n;j++)
            {
                
                Console.WriteLine(v[j]);
            }
            
        }
    }
}
