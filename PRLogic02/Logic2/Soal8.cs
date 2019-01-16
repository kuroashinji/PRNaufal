using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Soal8
    {
        
        public Soal8(int n) { 
            Console.WriteLine("  ");
            for (int k = 0; k <= n; k++)
            {
                for (int b = 0; b <= n; b++)
                {

                    if (b==k){
                        Console.Write(b * 2 + 1 + "\t");
                    }
                    else if (b+k==n)
                    {
                        Console.Write(b * 2 + "\t");
                    }
                    else if ((b) <= k && (n - b) >= k)
                    {
                        Console.Write("A\t");
                    }
                    else if ((b) >= k && (n - b) <= k)
                    {
                        Console.Write("B\t");
                    }
                    else{
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine("  ");
        
        }
    }
}
