using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan class yang diinginkan\nPR1=P1, PR2=P2, Postes=Tes");
            string nama = Console.ReadLine();
            if (nama == "P1") {  pr1 pr1 = new pr1(3); }
            else if (nama == "P2") { pr2 pr2 = new pr2(3); }
            else if (nama == "Tes") { postes pos = new postes(7); }
            else { Console.WriteLine("Salah input"); Console.ReadKey(); }
            
            Console.ReadKey();

        }
    }
}
