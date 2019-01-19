using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic4
{
    class soal10:logicbase
    {
        public soal10(int n,int o)
        {
            jumlahloop = o;
            jumlahbaris = n;
            jumlahkolom = n * o - (o-1);
            Array2d = new string[jumlahbaris, jumlahkolom];
            IsiArray2D();
            functionbase.print(Array2d);
        }

        

        private void IsiArray2D()
        {
            int jumlah = jumlahloop-1;
            for (int k = 0; k < jumlahkolom / 2 + 1; k++)
            {
                int angka = 65;

                for (int b = 0; b < jumlahkolom / 2 + 1; b++)
                {
                    if (jumlahbaris / 2 - b <= k && (jumlahkolom / (jumlahloop * 2) + k) - b <= jumlahkolom / jumlahloop  && b <= jumlahbaris / 2)
                    {
                        for (int l = 0; l <= jumlah; l++) {
                            Array2d[b, l * (jumlahbaris - 1) + k] = ((char)angka).ToString();
                            Array2d[jumlahbaris - b - 1, l * (jumlahbaris - 1) + k] = ((char)angka).ToString();
                            
                        }
                        
                        
                        if (k < jumlahkolom / 2)
                            angka += 1;
                        else angka -= 1;

                    }
                    //else if ((jumlahbaris / 2 + b - k) <= jumlahkolom / 3 + 1 - 1 && b + k <= jumlahkolom / 3 + 1 + jumlahkolom / 6 - 1&&b>jumlahbaris/2) { 
                    //    Array20[b, k] = angka.ToString();
                    //    Array20[b, 8 + k] = angka.ToString();
                    //    Array20[b, 16 + k] = angka.ToString();
                    //    if (k < jumlahkolom / 2)
                    //        angka += 2;
                    //    else angka -= 2;
                    //}

                }

            }

        }
    }
}
