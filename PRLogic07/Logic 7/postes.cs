using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambases;
namespace Logic_7
{
    class Postes : logicbase
    {
        public Postes(int n)
        {
            jumlahbaris = n * n;
            jumlahkolom = jumlahbaris;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiArray(n);
            functionbase.print(Array2d);
        }

        private void isiArray(int n)
        {
            int[] fibo = functionbase.Fibonacci(n * n);
            for (int bangunbaris = 0; bangunbaris < n; bangunbaris++)
            {
                for (int bangunkolom = 0; bangunkolom < n; bangunkolom++)
                {
                    if (bangunbaris == bangunkolom)
                    {
                        int angka = 0;
                        int nAngka = n * 2 + (n - 2) * 2 - 1;
                        int startbaris = bangunbaris * n;
                        int startkolom = bangunkolom * n;
                        int endbaris = startbaris + n - 1;
                        int endkolom = startkolom + n - 1;
                        for (int b = startbaris; b <= endbaris; b++)
                        {
                            for (int k = startkolom; k <= endkolom; k++)
                            {
                                if (b == startbaris || k == endkolom)
                                    Array2d[b, k] = "" + fibo[angka++];
                                else if (b == endbaris || k == startkolom)
                                    Array2d[b, k] = "" + fibo[nAngka--];
                            }
                        }
                    }
                }
            }
        }

    }
}
