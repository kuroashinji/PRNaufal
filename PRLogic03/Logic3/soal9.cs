using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic3
{
    class soal9:logicbase
    {
         public soal9(int n)
        {
            jumlahbaris = n;
            jumlahkolom = n;
            Array20 = new string[jumlahbaris, jumlahkolom];
            
            IsiArray();
            
            functionbase.PrintArray(Array20);
        }
        private void IsiArray() {
            Console.WriteLine("nilai jumlah baris "+jumlahbaris);
            Console.WriteLine("nilai jumlah kolom "+jumlahkolom);
            Console.WriteLine("buffer array "+jumlahbaris*jumlahkolom);
            int[] fibo = functionbase.fibonancci(jumlahkolom);
            int[] tribo = functionbase.tribonancci(jumlahkolom);
            int[] reverse = functionbase.reversefibo(jumlahkolom);
            int[] modif = functionbase.modiffibo(jumlahkolom);

            for (int k = 0; k < jumlahkolom; k++)
            {
                for (int b = 0; b < jumlahkolom; b++)
                {

                    //atas
                    if (b <= k && b + k <= jumlahkolom - 1 && b % 2 == 0)
                    {
                        //Garis bawah
                        Array20[b, k] = fibo[b / 2].ToString();
                        //GARIS BAWAH - MIRROR
                        Array20[jumlahkolom - 1 - b, k] = fibo[b / 2].ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= jumlahkolom - 1 && k % 2 == 0)
                    {
                        //Garis bawah
                        Array20[b, k] = fibo[k / 2].ToString();
                        //GARIS BAWAH - MIRROR
                        Array20[b, jumlahbaris - 1 - k] = fibo[k / 2].ToString();
                    }
                    
                    

                }
                
            }

        }
    }
}
