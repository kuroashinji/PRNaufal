using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic6
{
    class Pr2:logicbase
    {
        public Pr2(int n){
            jumlahbaris=3+(n-1);
            jumlahkolom=n*3+(n*n-1)/2;
            array2d=new string[jumlahbaris,jumlahkolom];
            isiarray(n);
            functionbase.print(array2d);
        }
        private void isiarray(int n)
        {
            int angka = 1;
            int deret = 1;
            for (int bangun = 0; bangun < n; bangun++)
            {
                int startkolom = (bangun * 3) + (bangun * (bangun - 1) / 2);
                int startbaris = n - bangun - 1;
                int endbaris = n + 1;
                int endkolom = startkolom + 2 + bangun;
                for (int b = startbaris; b <= endbaris; b++)
                {
                    angka = deret;
                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        if (b - k == startbaris - startkolom || k == endkolom || b == startbaris)
                        {
                            array2d[b, jumlahkolom-1-k] = angka.ToString();
                        }
                        angka++;
                    }

                }
                deret = angka;
            }
            
        }
       
    }
}
