using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambases;
namespace Logic_7
{
    class Pr3 : logicbase
    {
        public Pr3(int n)
        {
            jumlahbaris = n * 2 + 1;
            jumlahkolom = n * 2 + (n * 2 - 1);
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiArray(n);
            functionbase.print(Array2d);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {

                int startkolom = bgn * 2;

                int endbaris = jumlahbaris - 1 - bgn * 2;
                int endkolom = jumlahkolom - 1 - startkolom;
                int angka = 1;
                int nAngka = (endbaris) * 2 + (endkolom - startkolom) + 1;
                for (int b = 0; b <= endbaris; b++)
                {
                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        if (b == endbaris || k == startkolom)
                            Array2d[b, k] = "" + angka++;
                        else if (k == endkolom)
                        {
                            Array2d[b, k] = "" + nAngka--;
                        }
                    }
                }
            }
        }

    }
}
