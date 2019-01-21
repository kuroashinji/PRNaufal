using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic5
{
    class postes:logicbase
    {
        public postes(int n) {
            jumlahbaris = n;
            jumlahkolom = n;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(Array2d);
        }
        private void isiarray(int n) {
            int angka = 0;
            bool trigger = true;
            int[] fibo = functionbase.Fibonacci(8*8);
            for(int b=0;b<n;b++){
                for (int k = 0; k < n; k++)
                {
                    if (trigger) { 
                        if(b%2==0){
                            Array2d[b, k] = fibo[angka++].ToString();
                        }
                        else if (k == n - 1)
                        {
                            Array2d[b, k] = fibo[angka++].ToString();
                            trigger = !trigger;
                        }
                    } 

                    else { 
                        if (b % 2 == 0)
                        {
                            Array2d[b, n - 1 - k] = fibo[angka++].ToString();
                        }
                        else if (k == n - 1) {
                            Array2d[b, n - 1 - k] = fibo[angka++].ToString();
                            trigger = !trigger;
                        }
                        
                    }

                }
            
            }
  
        }
    }
}
