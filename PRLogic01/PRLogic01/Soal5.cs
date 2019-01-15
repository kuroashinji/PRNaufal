using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLogic01
{
    class Soal5
    {
        public Soal5()
        {
            int n = 9;
            int i, j;
            Console.WriteLine("Jawaban Soal Nomer 5");
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
                    else if (i == j || i == 1 || j == 1 || i == n || j == n || j == (n + 1) - i)
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
