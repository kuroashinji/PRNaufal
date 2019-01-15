using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLogic01
{
    class Soal6
    {
        public Soal6() {
            int n = 9;
            int i, j;

            Console.WriteLine("Jawaban Soal Nomer 6");
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= n; j++)
                {


                    if (j == 0)
                    {
                        Console.Write(i + " ");
                    }
                    else if (i == 0)
                    {
                        Console.Write(j + " ");
                    }
                    else if (i >= j)
                    {
                        Console.Write("* ");
                    }


                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            
        }

    }
}
