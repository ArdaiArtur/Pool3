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
            
            for (int i = 1; i <= n; i++)
            {
                int db = 0;
                for (int j = 1; j <i; j++)
                {
                    if ( i% j == 0) db++;
                    
                    
                }
                if (db == 1) Console.WriteLine(i);
            }
              



        }
    }
}
