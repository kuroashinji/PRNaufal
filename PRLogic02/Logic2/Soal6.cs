using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Soal6
    {
        public Soal6(int n) {
            Console.WriteLine("  ");
            for (int k = 0; k <= n; k++)
            {
                for (int b = 0; b <= n; b++)
                {

                    if (k+b >= n)
                    {
                        Console.Write((b * 2)  +"\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine("  ");
        }
    }
}
