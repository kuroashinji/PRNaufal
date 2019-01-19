using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic4
{
    class soal5:logicbase
    {
        public soal5(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n * 2 - 1;
            Array2d = new string[jumlahbaris, jumlahkolom];
            IsiArray2D();
            functionbase.print(Array2d);
        }

        

        private void IsiArray2D()
        {
            for (int b = 0; b < jumlahbaris/2+1; b++)
            {
                int angka=65;
                for (int k = 0; k < jumlahkolom; k++)
                {
                    if (b + k <= jumlahbaris - 1 && b<=k)
                    {
                        Array2d[b, k] = ((char)angka++).ToString();
                        //Array2d[jumlahbaris-b-1, k] = angka++.ToString();
                    }
                }
            }
        }
    }
}
