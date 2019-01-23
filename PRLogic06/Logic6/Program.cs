using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan kode\n1. Soal10\t2. PR1\t3. PR2\n");
            int kode = int.Parse(Console.ReadLine());
            if (kode == 1) { 
                soal10 soal1 = new soal10(9);
            }
            else if (kode == 2) {
                Pr1 soal1 = new Pr1(7);
            }
            else if (kode == 3)
            {
                Pr2 soal1 = new Pr2(4);
            }
            else {
                Console.WriteLine("\nSalah input");
            }
            Console.ReadKey();
        }
    }
}
