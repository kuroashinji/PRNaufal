using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exambase
{
    public class logicbase
    {
        public int jumlahbaris { get; set; }
        public int jumlahkolom { get; set; }
        public string[,] Array20 { get; set; }
        
    }
    public class functionbase
    {
        public static int[] fibonancci(int n) {
            int[] result = new int[n];
            
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                {
                    result[pos] = 1;
                }
                else {
                    result[pos] = result[pos - 1] + result[pos - 2];
                }
            }
            return result;
        }
        public static int[] number(int n)
        {
            int[] result = new int[n];

            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                {
                    result[pos] = 1;
                }
                else
                {
                    result[pos] = result[pos - 1] + 1;
                }
            }
            return result;
        }
        public static int[] tribonancci(int n) {
            int[] hasil = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i <= 1) hasil[i] = 1;
                else if (i == 2) hasil[i] = 1;
                else hasil[i] = hasil[i - 1] + hasil[i - 2] + hasil[i - 3];
                
            }
            return hasil;
        }
        public static int[] reversefibo(int n)
        {
            int[] hasil = new int[n];
            int g = 1;
            for (int i = 0; i < n; i++)
            {
                if (i <= 1) hasil[i] = 1;
                else if (i <= n / 2)
                    hasil[i] = hasil[i - 1] + hasil[i - 2];
                else
                {
                    hasil[i] = hasil[n / 2 - g];
                    g++;
                }
                
            }
            return hasil;
        }
        public static int[] modiffibo(int n)
        {
            int[] hasil = new int[n];
            int g = 1;
            for (int i = 0; i < n; i++)
            {
                if (i <= 2) hasil[i] = 1;
                else if (i <= n / 2) hasil[i] = hasil[i - 1] + hasil[i - 2] + hasil[i - 3];
                
                else
                {
                    hasil[i] = hasil[n / 2 - g];
                    g++;
                }

            }
            return hasil;
        }
        public static void PrintArray(string[,] array)
        {
            for (int b = 0; b < array.GetLength(0); b++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write("{0}\t", array[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
        public static int[] ascii(int n)
        {
            int[] result = new int[n];

            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                {
                    result[pos] = 65;
                }
                else
                {
                    result[pos] = result[pos - 1] + 1;
                }
            }
            return result;
        }
        

    }
}
