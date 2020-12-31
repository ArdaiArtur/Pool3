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
           
            int n = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("K");
            int k= Convert.ToInt32(Console.ReadLine());
            while (n < k)
            {
                Console.WriteLine("K");
                k = Convert.ToInt32(Console.ReadLine());
               
            }
            int[] v = new int[n];
            for (int i = 0; i < n; i++) {
               
                v[i] = Convert.ToInt32(Console.ReadLine());

            }
           



            Console.WriteLine("vectorul");
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (i == k - 1) { v[i] = v[j];i++; }


                   
                } Console.WriteLine(v[i]);
            }
        }
    }
}
