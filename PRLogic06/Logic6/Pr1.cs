using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic6
{
    class Pr1:logicbase
    {
        public Pr1(int n) {
            jumlahbaris = n*2-1;
            jumlahkolom = n * 2 - 1;
            array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(array2d);
        }
        private void isiarray(int n){
            for (int b = 0; b <= jumlahbaris; b++)
            {
                for (int k = 0; k <= jumlahkolom; k++)
                {
                    if (b >= jumlahbaris / 4 && k >= jumlahkolom / 4 && k <= jumlahkolom / 4 + jumlahkolom / 4 + 1 && b <= jumlahbaris / 4 + jumlahbaris / 4 + 1)
                        array2d[b, k] = " ";
                    else if (b + k >= jumlahbaris/2 - 1 && k - b <= jumlahbaris/2 - 1&&b<jumlahbaris/2)
                    { 
                        array2d[b, k] = "*";
                        array2d[jumlahbaris-3-b, k] = "*";
                        
                    }


                }
            }
        }
    }
}
