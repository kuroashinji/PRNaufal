using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Nilai ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.Write("Maaf, masukkan nilai ganjil ");
                Console.ReadKey(); }
            else { 
                Console.Write("Masukkan jumlah loop ");
                int o = int.Parse(Console.ReadLine());
                
                    soal9 soal = new soal9(n,o);
                
                Console.ReadKey();
            
            }
        }
    }
}
