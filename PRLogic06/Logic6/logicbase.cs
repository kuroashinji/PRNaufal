using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exambase
{
    public class logicbase
    {
        public int jumlahkolom { get; set; }
        public int jumlahbaris { get; set; }
        public int jumlahloop { get; set; }
        public string[,] array2d { get; set; }
    }
    public class functionbase
    {
        public static int[] fibonancci(int n)
        {
            int[] hasil = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    hasil[i] = 1;
                else
                    hasil[i] = hasil[i - 1] + hasil[i - 2];
            }
            return hasil;
        }
        public static int[] tribonancci(int n)
        {
            int[] hasil = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i <= 2)
                    hasil[i] = 1;
                else
                    hasil[i] = hasil[i - 1] + hasil[i - 2] + hasil[i - 3];
            }
            return hasil;
        }
        public static void print(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write(array[i, j] + "\t");

                }


                Console.WriteLine("\n");

            }

        }
    }
}
