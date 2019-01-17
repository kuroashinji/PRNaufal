using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic3
{
    class soal10:logicbase
    {
        public soal10(int n)
        {
            jumlahkolom = n;
            jumlahkolom = n;
            Array20 = new string[jumlahkolom, jumlahkolom];
            IsiArray();
            functionbase.PrintArray(Array20);
        }

        private void IsiArray()
        {
            int[] fibo = functionbase.fibonancci(jumlahkolom / 2);
            int ascii = 64;
            for (int b = 0; b < jumlahkolom; b++)
            {
                for (int k = 0; k < jumlahkolom; k++)
                {
                    //atas
                    if (b <= k && b + k <= jumlahkolom - 1)
                    {
                        //if (b % 2 == 0)
                        //{
                        //    Array20[b, k] = fibo[b / 2].ToString();
                        //    Array20[jumlahkolom - 1 - b, k] = fibo[b / 2].ToString();
                        //}
                        //else
                        //{
                        //    Array20[b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //    Array20[jumlahkolom - 1 - b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //}
                        Array20[b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                        Array20[jumlahkolom - 1 - b, k] =
                            b % 2 == 0 ? fibo[b / 2].ToString() :
                            ((char)(ascii + (b + 1) / 2)).ToString();
                    }
                    //kiri
                    else if (b >= k && b + k <= jumlahkolom - 1)
                    {
                        //Array20[b, k] = fibo[k / 2].ToString();
                        //Array20[b, jumlahkolom - 1 - k] = fibo[k / 2].ToString();
                        Array20[b, k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                        Array20[b, jumlahkolom - 1 - k] =
                            k % 2 == 0 ? fibo[k / 2].ToString() :
                            ((char)(ascii + (k + 1) / 2)).ToString();
                    }
                }
            }
        }
    }
}
