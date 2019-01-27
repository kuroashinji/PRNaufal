using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambases;
namespace Logic_7
{
    class Soal10 : logicbase
    {
        public Soal10(int n)
        {
            jumlahbaris = n * n;
            jumlahkolom = jumlahbaris;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiArray(n);
            functionbase.print(Array2d);
        }

        private void isiArray(int n)
        {
            int angka = 1;

            for (int bangunbaris = 0; bangunbaris < n; bangunbaris++)
            {
                for (int bangunkolom = 0; bangunkolom < n; bangunkolom++)
                {
                    if (bangunbaris == 0 || bangunkolom == 0 || bangunbaris == n - 1 || bangunkolom == n - 1)
                    {
                        int startbaris = bangunbaris * n;
                        int startkolom = bangunkolom * n;
                        int endbaris = startbaris + n - 1;
                        int endkolom = startkolom + n - 1;
                        for (int b = startbaris; b <= endbaris; b++)
                        {
                            for (int k = startkolom; k <= endkolom; k++)
                            {
                                if (b - k >= startbaris - startkolom)
                                    Array2d[b, k] = "" + angka;
                            }
                        }
                        angka++;
                    }
                }
            }
        }

    }
}
