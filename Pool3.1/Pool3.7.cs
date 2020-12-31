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
            int b = n;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < b; j++) { w[i] = v[j]; }
b--;
                
                    }

                    Console.WriteLine("vectorul");
            for (int j=0;j<n;j++)
            {
                v[j] = w[j];
                Console.WriteLine(v[j]);
            }
            
        }
    }
}
