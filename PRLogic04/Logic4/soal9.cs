using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic4
{
    class soal9:logicbase
    {
        public soal9(int n,int o)
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
            if (jumlahloop <= 1) {
                
                for (int b = 0; b < jumlahkolom ; b++)
                {
                    int angka = 1;
                    for (int k = 0; k < jumlahkolom ; k++)
                    {

                        if (b + k >= jumlahbaris / 2 && jumlahbaris / 2 + b  > k-1&&b<=jumlahbaris/2)
                        {

                            Array2d[b, k] = angka.ToString();
                            Array2d[jumlahbaris-b-1, k] = angka.ToString();
                            if (k < jumlahkolom / 2)
                                angka += 2;
                            else angka -= 2;
                        }

                    }

                }
            }
            else if (jumlahloop>1){
            
                for (int k = 0; k < jumlahkolom / 2 + 1; k++)
                {
                    int angka = 1;

                    for (int b = 0; b < jumlahkolom / 2 + 1; b++)
                    {
                        if (jumlahbaris / 2 - b <= k && (jumlahkolom / (jumlahloop * 2) + k) - b <= jumlahkolom / jumlahloop && b <= jumlahbaris / 2)
                        {
                            for (int l = 0; l <= jumlah; l++)
                            {
                                Array2d[b, l * (jumlahbaris - 1) + k] = angka.ToString();
                                Array2d[jumlahbaris - b - 1, l * (jumlahbaris - 1) + k] = angka.ToString();

                            }


                            if (k < jumlahkolom / 2)
                                angka += 2;
                            else angka -= 2;

                        }

                    }
                }

            }

        }
    }
}
