using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambases;
namespace Logic_7
{
    class Soal01 : logicbase
    {
        public Soal01(int n)
        {
            
            jumlahbaris = ((n * 2) - 1) + (n * 2);
            jumlahkolom = jumlahbaris;
            Array2d = new string[jumlahbaris, jumlahkolom];
            IsiArray(n);
            functionbase.print(Array2d);
        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < jumlahbaris; b++)
            {
                for (int k = 0; k < jumlahkolom; k++)
                {
                    
                    //segitiga atas
                    if (b + k >= n * 2 - 1 && k - b <= n * 2 - 1 && b <= n - 1)
                    {
                        Array2d[b, k] = "*";
                    }
                    //segitiga kiri
                    if (b + k >= n * 2 - 1 && b - k <= n * 2 - 1 && k <= n - 1)
                    {
                        Array2d[b, k] = "*";
                    }
                    //segitiga bawah
                    if (b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= jumlahbaris - n)
                    {
                        Array2d[b, k] = "*";
                    }
                    if (k - b <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && k >= jumlahkolom - n)
                    {
                        Array2d[b, k] = "*";
                    }
                }
            }
        }
    }
}
