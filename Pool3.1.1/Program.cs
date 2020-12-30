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
            int a=0,b=0;
            int[] n = new int[10];
            for (int i = 0; i < 10; i++) {
                n[i] = Convert.ToInt32(Console.ReadLine());

            }




            Console.WriteLine("1");
            for(int j=0;j<10;j++)
            { int w = 0;
                w = n[j];
                b = b + w;
            }
            Console.WriteLine(b);

        }
    }
}
