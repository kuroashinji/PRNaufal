using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambases;
namespace Logic_7
{
    class Soal02:logicbase
    {
        public Soal02(int n)
        {
            jumlahbaris = ((n * 2) - 1) + (n * 2);
            jumlahkolom = jumlahbaris;
            Array2d = new string[jumlahbaris, jumlahkolom];
            IsiArray(n);
            functionbase.print(Array2d);
        }

        private void IsiArray(int n)
        {
            int[] fibo = functionbase.Fibonacci(jumlahkolom * jumlahkolom);
            int[] tribo = functionbase.Fibonacci(jumlahkolom * jumlahkolom);
            int angka = 1;
            int index1 = 0;
            int index2 = 0;
            
            for (int b = 0; b < jumlahbaris; b++)
            {
                for (int k = 0; k < jumlahkolom; k++)
                {
                    //segitiga atas
                    if (b + k >= n * 2 - 1 && k - b <= n * 2 - 1 && b <= n - 1)
                    {
                        Array2d[b, k] = angka.ToString();
                        angka += 2;
                    }
                    //segitiga kiri
                    if (b + k >= n * 2 - 1 && b - k <= n * 2 - 1 && k <= n - 1)
                    {
                        Array2d[b, k] = fibo[index1++].ToString();
                    }
                    //segitiga bawah
                    if (b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= jumlahbaris - n)
                    {
                        Array2d[b, k] = angka.ToString();
                        angka += 2;
                    }
                    if (k - b <= n * 2 -1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && k >= jumlahkolom - n)
                    {
                        Array2d[b, k] = tribo[index2++].ToString();
                    }
                }
            }
        }
    }
}
