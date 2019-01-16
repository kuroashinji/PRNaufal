using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Soal9
    {
        public Soal9(int n) {
            Console.WriteLine("  ");
            int g=0;
            for (int k = 0; k <= n; k++)
            {
                for (int b = 0; b <= n; b++)
                {

                    if (b <=n/2)
                    {
                        Console.Write(b * 2 + 1 + "\t");
                        
                    }

                    else if (b > n / 2)
                    {

                        Console.Write((n - b) * 2 + 1 + "\t");
                        
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
