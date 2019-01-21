using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic5
{
    class soal10:logicbase
    {
        public soal10(int n) {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = n * n;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(Array2d);
        }
        private void isiarray(int n){
            {
                for (int bangun = 0; bangun < n; bangun++)
                {
                    int[] fibo = functionbase.Fibonacci(jumlahkolom * jumlahbaris);
                    int startbaris = (bangun * bangun + bangun) / 2;
                    int startkolom = ((n * 2 - 1) / 2) - bangun;
                    int endbaris = startbaris + bangun;
                    int endkolom = startkolom + (bangun * 2);
                    int angka = 1;
                    for (int b = startbaris; b <= endbaris; b++)
                    {
                        for (int k = startkolom; k <= endkolom; k++)
                        {
                            if (b + k >= startkolom + endbaris && k + endbaris <= b + endkolom)
                            {
                                if (bangun % 2 == 0)
                                {
                                    Array2d[b, k] = angka.ToString();
                                    angka += 2;
                                }
                                else
                                {
                                    Array2d[b, k] = fibo[angka - 1].ToString();
                                    angka++;
                                }
                            }
                        }
                    }
                }
            
            }
        }
    }
}
