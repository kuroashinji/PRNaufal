using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic6
{
    class soal01:logicbase
    {
        public soal01(int n) {
            jumlahbaris = n*n;
            jumlahkolom = (n * 2 - 1) *2;
            array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(array2d);
            bool trigger = true;
        }
        private void isiarray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int startkolom;
                int startbaris = n * bangun;
                if (bangun % 2 == 0)
                {
                    startkolom = 0;
                }
                else
                    startkolom = n * 2 - 1;
                int endbaris = startbaris + n-1;
                int endkolom = startkolom + 2*(n-1);

                for (int b = startbaris; b <= endbaris; b++)
                {
                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        if (bangun % 2 == 0)
                        {
                            if (b + k >= endbaris && k - b <= endkolom - endbaris)
                                array2d[b, k] = "*";
                        }
                        else
                        {
                            if (k + b >= endbaris + startkolom && k - b <= endkolom - endbaris)
                            {
                                array2d[b, k] = "*";
                            }
                        }
                        //else
                        //{
                        //    if(b+k>=JmlhBaris+1&&k-b<=JmlhBaris/2)
                        //        Array2D[b,k]= 
                        //}
                    }

                }

            }

        }
    }
}
