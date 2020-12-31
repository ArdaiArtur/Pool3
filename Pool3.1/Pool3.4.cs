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
            int[] v = new int[n]; int ma = 0, mi = 0;int min = 9999;int max = -9999;
            for (int i = 1; i < n+1; i++) {
                v[i] = Convert.ToInt32(Console.ReadLine());

            }




           
            for(int j=1;j<n+1;j++)
            {
                
                
                if (v[j] > max) { max = v[j]; ma++; }
                if (min > v[j]) { min = v[j]; mi++; }

            }
            Console.WriteLine(" cel mai mic si de cate ori apara"); Console.WriteLine(min) ;Console.WriteLine(mi);
            Console.WriteLine(" cel mai mare si de cate ori apara"); Console.WriteLine( max); Console.WriteLine(ma);
        }
    }
}
