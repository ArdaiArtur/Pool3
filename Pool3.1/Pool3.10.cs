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
            int k = Convert.ToInt32(Console.ReadLine());

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {

                v[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("vectorul");
            int x = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                    {

                        x = v[i];
                        v[i] = v[j];
                        v[j] = x;
                    }
                }

        

        int e = -1;
            for (int j = 0; j<n; j++)
            {
                
                if (v[j] == k) e=j;
              


                Console.WriteLine(v[j]);
            }
            Console.WriteLine("pozitia lui k"); Console.WriteLine(e) ;
        }
    }
}
