using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Masukkan kode tugas\n");
                Console.Write("S5 = Soal no 5\n");
                Console.Write("S6 = Soal no 6\n");
                Console.Write("S7 = Soal no 7\n");
                Console.Write("S8 = Soal no 8\n");
                Console.Write("S9 = Soal no 9\n");
                Console.Write("S10 = Soal no 10\n");
                Console.Write("P3 = PR no 3\n");
                Console.Write("P4 = PR no 4\n");
                Console.Write("PR1 = Pretest no 1\n");
                string nama = Console.ReadLine();
                if (nama == "S5") { Soal5 soal5 = new Soal5(8); }
                else if (nama == "S6") { Soal6 soal6 = new Soal6(8); }
                else if (nama == "S7") { Soal7 soal7 = new Soal7(8); }
                else if (nama == "S8") { Soal8 soal8 = new Soal8(8); }
                else if (nama == "S9") { Soal9 soal9 = new Soal9(8); }
                else if (nama == "S10") { Soal10 soal10 = new Soal10(8); }
                else if (nama == "P3") { Pr3 pr3 = new Pr3(8); }
                else if (nama == "P4") { Pr4 pr4 = new Pr4(8); }
                else if (nama == "PR1") { Pretes pre = new Pretes(8); }
                else { Console.Write("Salah input"); break; }
            }
            
            Console.Read();
        }
    }
}
