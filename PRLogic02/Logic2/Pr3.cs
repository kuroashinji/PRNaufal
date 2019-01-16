using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Pr3
    {
        int Trib(int n)
        {
            

            if (n == 1||n == 3 || n == 2)
                return 1;
            else
                return Trib(n - 1) +
                       Trib(n - 2) +
                       Trib(n - 3);
        } 
        public Pr3(int n) {
            int a = 0;
            int c = 1;
            int temp;
            
            int[] dp = new int[n];
            dp[0] = dp[1] = 0;
            dp[2] = 1;
            for (int k = 0; k <= n; k++)
            {
                for (int b = 0; b <= n; b++)
                {

                    if (b == k)
                    {
                        temp = a;
                        a = c;
                        c = temp + c;
                        Console.Write(a+"\t");

                    }
                    else if (b + k == n) {
                        Trib(n);
                        Console.Write(Trib(b+1) + "\t");

                    }
                    else if (b <= k && b + k <= n - 1)
                    {
                        Console.Write("A\t");
                    }
                    else if (b >= k && b + k-1 >= n - 1)
                    {
                        Console.Write("B\t");
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
