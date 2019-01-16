using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Soal10
    {
        public Soal10(int n) {
            for (int k = 0; k <= n; k++)
            {
                for (int b = 0; b <= n; b++)
                {

                    if (k <= n / 2)
                    {
                        Console.Write(k * 2 + "\t");

                    }

                    else if (k > n / 2)
                    {

                        Console.Write((n - k) * 2 + "\t");

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
