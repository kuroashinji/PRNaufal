using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLogic01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            int i, j;
            Console.WriteLine("Jawaban Soal Nomer 4");
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
                    else if (i == j || i == 5 || j == 5 || j == (n + 1) - i)
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
            Console.WriteLine("Jawaban Soal Nomer 7");
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
                    else if ((j - 1) >= (i))
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
            Console.WriteLine("Jawaban Soal Nomer 10");
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
                    else if ((j - 1) <= i && (n - j) >= i && (i - 3) != 0 && (i - 2) != 0 && (i - 1) != 0 && i != 0)
                    {
                        Console.Write("* ");
                    }
                    else if ((j - 1) >= i && (n - j) <= i && (i + 4) != n && (i + 3) != n && (i + 2) != n && (i + 1) != n && i != n)
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
            Console.Read();
        }
    }
}
