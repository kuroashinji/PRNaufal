using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic5
{
    class soal04:logicbase
    {
        public soal04(int n) {
            jumlahbaris = (n * n + n) / 2;//0,1,3
            jumlahkolom = n * n;//0,1,4
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(Array2d);
        }
        private void isiarray(int n){
            for (int bangun = 0; bangun < n; bangun++) {
                int startbaris = (bangun * bangun + bangun) / 2;//0,1,3
                int startkolom = jumlahkolom-1-(bangun*bangun);//8,7,4
                int endbaris = startbaris + bangun; //0,2,5
                int endkolom = startkolom-((bangun * 2));//8, 5, 0
                for (int b = startbaris; b <= endbaris; b++)
                {
                    for (int k = startkolom; k >= endkolom; k--)
                    {
                        if (b + k >= endkolom + endbaris&&k-b<=startkolom-endbaris)
                          Array2d[b, k] = "*";
                        

                    }
                }
            
            }
        }
    }
}
