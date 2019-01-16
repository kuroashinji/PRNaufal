using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Pretes
    {
        public Pretes(int n) {
            int a = 0;
            int c = 1;
            int d = 0;
            int e = 1;
            int temp;
            for (int k = 0; k <= n; k++)
            {
                temp = a;
                a = c;
                c = temp + c;
                temp = d;
                
                for (int b = 0; b <= n; b++)
                {
                    if (b==k+1)
                    {

                        if (c >= n / 2)
                            Console.Write(c + "\t");
                        else
                        {
                            Console.Write("\t");
                        }

                    }
                    else if (b+k == n-1)
                    {

                        if (c >= n / 2)
                        Console.Write(c + "\t");
                        else
                        {
                            Console.Write("\t");
                        }
                        
                    }
                    
                    else if (b == n / 2) { 
                        
                        Console.Write(c + "\t");
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
