using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambases;
namespace Logic_7
{
    class Soal3:logicbase
    {
        public Soal3(int n)
        {
            jumlahbaris = n + n + 1;
            jumlahkolom = ((n * 2) - 1) + n * 2;
            Array2d = new string[jumlahbaris, jumlahkolom];
            IsiArray(n);
            functionbase.print(Array2d);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int startbaris = bangun * 2;
                int startkolom = startbaris;
                int endbaris = jumlahbaris - 1;
                int endkolom = jumlahkolom - endbaris;

                for (int b = startbaris; b <= endbaris; b++)
                {
                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        if (b == startbaris || k == startkolom)
                        {
                            Array2d[b, k] = "*";
                            Array2d[b, jumlahkolom - 1 - k] = "*";
                        }
                    }
                }
            }
        }
    }
}
