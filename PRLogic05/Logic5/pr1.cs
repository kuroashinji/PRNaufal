using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic5
{
    class pr1:logicbase
    {
        public pr1(int n) {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = n * n;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(Array2d);
        }
        private void isiarray(int n) {
            
            int[] fibo=functionbase.Fibonacci(jumlahkolom*jumlahbaris);
            for (int bangun = 0; bangun < n; bangun++)
            {
                int startbaris = jumlahbaris-1-((bangun * bangun + bangun) / 2);//0,1,3
                int startkolom = bangun * bangun;
                int endbaris = startbaris - (bangun);//
                int endkolom = startkolom + (bangun * 2);
                int angka = 0;
                for (int b = 0; b <= startbaris; b++)
                {
                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        //if (b + k >= startkolom + endbaris && k + endbaris <= b + endkolom)
                        if(b+k>=startkolom+startbaris&&k-b<=endkolom-startbaris)
                            
                            Array2d[b, k] = fibo[angka++].ToString();

                    }
                }

            }
        }
    }
}
