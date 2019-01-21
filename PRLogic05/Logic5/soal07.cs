using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic5
{
    class soal07:logicbase
    {
        public soal07(int n) {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = (n * n + n) / 2;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(Array2d);
        }
        private void isiarray(int n){
            for (int bangun = 0; bangun < n; bangun++) {
                int startbaris = (bangun * bangun + bangun) / 2;//0,1,4,,
                int startkolom = (jumlahkolom-1)-(startbaris+bangun);
                int endbaris = startbaris + bangun;
                int endkolom = jumlahkolom - 1 - startbaris;//9,8,6,3
                int angka = 1;
                for (int b = startbaris; b <= endbaris; b++)
                {
                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        Array2d[b, k] = angka.ToString();
                        angka++;
                    }
                }
            
            
            }
        }
    }
}
