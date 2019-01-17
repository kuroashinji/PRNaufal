using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Logic3
{
    class soal1:logicbase
    {
        public soal1(int n)
        {
            jumlahbaris = 1;
            jumlahkolom = n;
            Array20 = new string[jumlahbaris, jumlahkolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray() {
            Console.WriteLine("nilai jumlah baris "+jumlahbaris);
            Console.WriteLine("nilai jumlah kolom "+jumlahkolom);
            Console.WriteLine("buffer array "+jumlahbaris*jumlahkolom);
            int[] fibo = functionbase.fibonancci(jumlahkolom);
            int[] tribo = functionbase.modiffibo(jumlahkolom);
            for (int k = 0; k < jumlahkolom; k++)
            {
                
                Array20[0, k] = fibo [k].ToString();
               
                //for (int k = 0; k < jumlahkolom; k++) {
                //    if (b == k) {
                //        Array20[b, k] = (k * 2+1).ToString();

                //    }
                //    else if (b+k == jumlahkolom-1)
                //    {
                //        Array20[b, k] = (k * 2).ToString();

                //    }
                    
                //}
            }

        }
        private void CetakArray() {
            for (int b = 0; b < Array20.GetLength(0); b++)
            {
                for (int k = 0; k < Array20.GetLength(1); k++) {
                    Console.Write(Array20[b, k] + "\t");

                }
                Console.WriteLine("\n");
            }
        }

    }
}
