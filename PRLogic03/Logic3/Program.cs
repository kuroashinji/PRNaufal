using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Logic 3");
                Console.Write("Masukkan Nilai ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("S3 = soal no 3\n");
                Console.Write("S4 = soal no 4\n");
                Console.Write("S5 = soal no 5\n");
                Console.Write("S6 = soal no 6\n");
                Console.Write("S7 = soal no 7\n");
                Console.Write("S8 = soal no 8\n");
                Console.Write("S9 = soal no 9\n");
                Console.Write("S10 = soal no 10\n");
                
                string nama = Console.ReadLine();
                if (nama == "S5") { soal5 soal5 = new soal5(n); }
                else if (nama == "S4") { soal4 soal4 = new soal4(n); }
                else if (nama == "S3") { soal3 soal3 = new soal3(n); }
                else if (nama == "S6") { soal6 soal6 = new soal6(n); }
                else if (nama == "S7") { soal7 soal7 = new soal7(n); }
                else if (nama == "S8") { soal8 soal8 = new soal8(n); }
                else if (nama == "S9") { soal9 soal9 = new soal9(n); }
                else if (nama == "S9") { soal9 soal9 = new soal9(n); }
                else if (nama == "S9") { soal9 soal9 = new soal9(n); }
                else if (nama == "S10") { soal10 soal10 = new soal10(8); }

                else { Console.Write("Salah input"); break; }
            }
            Console.Write("Tekan sembarang tombol ");
            Console.ReadKey();
        }
    }
}
