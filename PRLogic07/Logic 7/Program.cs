using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Angka");
            int n = int.Parse(Console.ReadLine());
            Pr3 soal1 = new Pr3(n);
            Console.ReadKey();
        }
    }
}
