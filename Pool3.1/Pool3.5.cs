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
            int[] v = new int[n]; int ma = 0, mi = 0;
            for (int i = 1; i < n; i++) {
                v[0] = k;
                v[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("e");
            int e = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("vectorul");
            for (int j=0;j<n;j++)
            {
                if (j == k) v[j] = e;


                Console.WriteLine(v[j]);
            }
            
        }
    }
}
