using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Pr4
    {
        public Pr4(int n) {
            for (int k = 0; k <= n; k++)
            {
                for (int b = 0; b <= n; b++)
                {

                    if (k==0||k==n||b==0||b==n)
                    {
                        Console.Write("A\t");

                    }
                    else if (k == 1 || k == n-1 || b == 1 || b == n-1)
                    {
                        Console.Write("B\t");

                    }
                    else if (k == 2 || k == n - 2 || b == 2 || b == n - 2)
                    {
                        Console.Write("C\t");

                    }
                    else if (k == 3 || k == n - 3 || b == 3 || b == n - 3)
                    {
                        Console.Write("D\t");

                    }
                    
                    else
                    {
                        Console.Write("E\t");
                    }


                }
                Console.WriteLine("  ");

            }
            Console.WriteLine("  ");
        }
    }
}
