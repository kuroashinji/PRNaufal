using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLogic01
{
    class Soal9
    {
        public Soal9() {
            int n = 9;
            int i, j;

            Console.WriteLine("Jawaban Soal Nomer 9");
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
                    else if ((j - 1) <= i && (n - j) >= i)
                    {
                        Console.Write("* ");
                    }
                    else if ((j - 1) >= i && (n - j) <= i)
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
