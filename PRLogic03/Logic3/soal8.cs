using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic3
{
    class soal8:logicbase

    {
        public soal8(int n)
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
            int[] num = functionbase.number(jumlahkolom);
            int no = 1;
            for (int k = 0; k < jumlahkolom; k++)
            {
                for (int b = 0; b < jumlahkolom; b++)
                {

                    //atas
                    if (b <= k && b + k <= jumlahkolom - 1 && b % 2 == 0)
                    {
                        //Garis bawah
                        Array20[b, k] = (no+b).ToString();
                        //GARIS BAWAH - MIRROR
                        Array20[jumlahkolom - 1 - b, k] = (no+b).ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= jumlahkolom - 1 && k % 2 == 0)
                    {
                        //Garis bawah
                        Array20[b, k] = (no + k).ToString();
                        //GARIS BAWAH - MIRROR
                        Array20[b, jumlahbaris - 1 - k] = (no + k).ToString();
                    }
                    
                    

                }
                
            }

        }
        
    }
}
