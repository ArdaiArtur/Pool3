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
            int n= Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n]; int ma = 0, mi = 0;
            for (int i = 1; i < n+1; i++) {
                v[i] = Convert.ToInt32(Console.ReadLine());

            }




           
            for(int j=1;j<n+1;j++)
            {
                
                int min = 0;int max = 0;
                if (v[j] > max) { max = v[j]; ma = j; }
                if (min > v[j]) { min = v[j]; mi = j; }

            }
            Console.WriteLine("pozitia lui cel mai mic"); Console.WriteLine(mi) ;
            Console.WriteLine("pozitia lui cel mai mare"); Console.WriteLine( ma);
        }
    }
}
