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
            int a= Convert.ToInt32(Console.ReadLine()),k =5;
            int[] n = new int[10];
            for (int i = 1; i < a+1; i++) {
                n[i] = Convert.ToInt32(Console.ReadLine());

            }




           
            for(int j=1;j<a+1;j++)
            {
                int d = 0;
                if (k == n[j] && d == 0) { Console.WriteLine("pozitia lui k", j); d++; }
                else Console.WriteLine(-1);
            }
            

        }
    }
}
