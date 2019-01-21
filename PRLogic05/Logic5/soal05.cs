using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic5
{
    class soal05:logicbase
    {
        public soal05(int n) {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = n * n;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(Array2d);
        }
        private void isiarray(int n){
            for (int bangun = 0; bangun < n; bangun++) {
                int startbaris = (bangun * bangun + bangun) / 2; //0,1,3
                int startkolom = bangun*bangun; //0,1,4
                int endbaris = startbaris + bangun; //0,3,5
                int endkolom = startkolom+(bangun*2); //0,3,8
                for (int b = startbaris; b <= endbaris; b++)
                {
                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        if(k-b>=startkolom-startbaris&&b+k<=startbaris+endkolom)
                        Array2d[b, k] = "*";

                    }
                }
            
            }
        }
    }
}
