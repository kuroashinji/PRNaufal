using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Soal5
    {
        public Soal5(int n) {
            for (int k = 0; k <= n; k++)
            {
                for (int b = 0; b <= n; b++)
                {

                    if (b <= k)
                    {
                        Console.Write((b * 2) + 1 + "\t");
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

        public static Soal5 soal4 { get; set; }
    }
}
