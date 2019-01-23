using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic6
{
    class soal10:logicbase
    {
        public soal10(int n) {
            jumlahbaris = n;
            jumlahkolom = n;
            array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(array2d);
        }
        private void isiarray(int n){
            int angka = 1;
            for (int b = 0; b < jumlahbaris; b++)
            {
                for (int k = 0; k < jumlahkolom; k++)
                {
                    if (b >= k) {
                        if(angka%2==1)
                            array2d[b, k] = angka.ToString();
                    }
                    if (b + k>=jumlahkolom-1)
                    {
                        if (angka % 2 == 0)
                            array2d[b, k] = angka.ToString();
                    }
                    


                }
                angka++;
            }
        }
    }
}
