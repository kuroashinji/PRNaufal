using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLogic01
{
    class Soal8
    {
        public Soal8() {
            int n = 9;
            int i, j;

            Console.WriteLine("Jawaban Soal Nomer 8");
            for (i = n; i >= 0; i--)
            {
                for (j = 0; j <= n; j++)
                {

                    if (i == n)
                    {
                        Console.Write(j + " ");
                    }
                    else if (j == 0)
                    {
                        Console.Write(n - i + " ");
                    }
                    else if (i <= j - 1 && (n - i) >= j)
                    {
                        Console.Write("* ");
                    }
                    else if (i >= j - 1 && (n - i) <= j)
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
