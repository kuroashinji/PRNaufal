﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exambase
{
    public class logicbase
    {
        public int jumlahbaris {get; set;}
        public int jumlahkolom { get; set; }
        public int jumlahloop { get; set; }
        public string[,] Array2d { get; set; }
    }
    public class functionbase{
        public static int[] fibonancci(int n){
            int[] hasil=new int[n];
            for (int i = 0; i < n; i++)
			{
                if(i<=0)
			        hasil[i]=1;
                else
                    hasil[i]=hasil[i]+hasil[i-1];
			}
            return hasil;
        }
        public static int[] reverseganjil(int n)
        {
            int[] hasil = new int[n];
            int g = 1;
            for (int i = 0; i < n; i++)
            {
                if (i < 1) hasil[i] = 1;
                else if (i <= n / 2)
                    hasil[i] = hasil[i - 1] + 2;
                else
                {
                    hasil[i] = hasil[n / 2 - g];
                    g++;
                }
                
            }
            return hasil;
        }
        public static int[] ganjil(int n){
            int[] hasil=new int[n];
            int g = 1;
            for (int i = 0; i < n; i++)
			{
                if (i < 1) hasil[i] = 1;
                else if (i <= n / 2)
                    hasil[i] = hasil[i - 1] + 2;
                else
                {
                    hasil[i] = hasil[n / 2 - g];
                    g++;
                }
			}
            return hasil;
        }
        public static void print(string[,] array){
            for (int i = 0; i < array.GetLength(0); i++)
			{
                for (int j = 0; j < array.GetLength(1); j++) { 
                
                    Console.Write(array[i,j]+"\t");
                    
                }
                
                
                Console.WriteLine("\n");
			
			}

        }
    }
}
