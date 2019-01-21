using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic5
{
    class soal08:logicbase
    {
        public soal08(int n) {
            jumlahbaris = (n * n + n) / 2;
            jumlahkolom = (n * n + n) / 2;
            Array2d = new string[jumlahbaris, jumlahkolom];
            isiarray(n);
            functionbase.print(Array2d);
        }
        private void isiarray(int n){
            int ganjil=1;
            int genap=2;
            for (int bangun = 0; bangun < n; bangun++)
            {
                int startbaris = (bangun * bangun + bangun) / 2;
                int startkolom = startbaris;
                int endbaris = startbaris + bangun;
                int endkolom = endbaris;
                bool kanan = true;
                for (int b = startbaris; b <= endbaris; b++)
                {

                    for (int k = startkolom; k <= endkolom; k++)
                    {
                        Array2d[b,kanan?k:endkolom-k+startkolom]=bangun%2==0?ganjil.ToString():genap.ToString();
                        if (kanan)
                        {
                            if (bangun % 2 == 0)
                                Array2d[b, k] = ganjil.ToString();
                            else
                                Array2d[b, k] = genap.ToString();
                        }
                        else {
                            if (bangun % 2 == 0)
                                Array2d[b, endkolom-k+startkolom] = ganjil.ToString();
                            else
                                Array2d[b, endkolom - k + startkolom] = genap.ToString();
                        }
                        if (bangun % 2 == 0)
                        {
                            
                            ganjil += 2;
                        }
                        else
                        {
                            
                            genap = genap + 2; ;
                        }

                    }
                    kanan = !kanan;
                }

            }
        }
    }
}
