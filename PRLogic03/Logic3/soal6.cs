using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic3
{
    class soal6:logicbase
    {
        public soal6(int n)
        {
            jumlahbaris = n;
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
            int[] tribo = functionbase.tribonancci(jumlahkolom);
            int[] reverse = functionbase.reversefibo(jumlahkolom);
            int[] modif = functionbase.modiffibo(jumlahkolom);
            for (int k = 0; k < jumlahkolom; k++)
            {
                for (int b = 0; b < jumlahkolom; b++)
                {

                     Array20[b, k] = fibo[k].ToString();
                    

                }
                
            }

        }
        private void CetakArray() {
            for (int b = 0; b < Array20.GetLength(0); b++)
            {
                for (int k = 0; k < Array20.GetLength(1); k++) {
                    if (b == k || b + k == jumlahkolom - 1)
                        Console.Write(Array20[b, k] + "\t");
                    else if (b < k && b + k < Array20.GetLength(1))
                        Console.Write("A\t");
                    else if(b<=k&&b+k>= Array20.GetLength(1))
                        Console.Write("B\t");
                    else if (b > k && b + k >= Array20.GetLength(1))
                        Console.Write("D\t");
                    else if (b >= k && b + k <= Array20.GetLength(1))
                        Console.Write("C\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine("\n");
            }
        } 
    }
}
