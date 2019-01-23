using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic6
{
    class soal05:logicbase
    {
        public soal05(int n){
            jumlahbaris=n*n;
            jumlahkolom=n*n;
            array2d=new string[jumlahbaris,jumlahkolom];
            isiarray(n);
            functionbase.print(array2d);
        }
        //private void isiarray(int n){
        //    int angka = 1;
        //    for (int bb = 0; bb < n; bb++)
        //    {
                
        //        for (int bk = 0; bk < n; bk++){
        //            int startbaris=bb*n;
        //            int startkolom=bk*n;
        //            int endbaris=startbaris+n-1;
        //            int endkolom=startkolom+n-1;
        //            bool trigger = true;
                    
        //            for (int b = startbaris; b <= endbaris; b++)
        //            {
                        
        //                for(int k=startkolom;k<=endkolom;k++)
        //                {
        //                    if (bb== bk) { 
        //                    //array2d[b,k]="*";
        //                        if (b + k >= startkolom + endbaris && k - b <= endkolom - endbaris)
        //                        {
        //                            array2d[b, k] = "*";


        //                        }
        //                        //else if (b + k <= endkolom + startbaris && b - k <= startbaris - startkolom)
        //                        //{
        //                        //    array2d[b, k] = "*";


        //                        //}
                                
                                
                                
        //                    }
        //                    if (bb == bk + 1) {
        //                        if (b + k < endkolom + startbaris && b - k < startbaris - startkolom)
        //                        {
        //                            array2d[b, k] = "*";


        //                        }
        //                    }
        //                }
        //                trigger = !trigger;
        //            }

        //        }
			
			 
        //    }
        //}
        private void isiarray(int n)
        {
            int deret = (n + 1) / 2;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int startbaris = bb * n;
                        int endbaris = startbaris + n - 1;
                        int startkolom = bk * n;
                        int endkolom = startkolom + n - 1;
                        for (int b = startbaris; b <= endbaris; b++)
                        {
                            int angka = deret;
                            for (int k = startkolom; k <= endkolom; k++)
                            {
                                if (b + k >= startbaris + ((startkolom + endkolom) / 2) && (k - startkolom) - (b - startbaris) <= n / 2 && b <= (startbaris + endbaris) / 2)
                                {
                                    if (k < (startkolom + endkolom) / 2)
                                    {
                                        array2d[b, k] = angka.ToString();
                                        array2d[endbaris - b + startbaris, k] = angka.ToString();
                                        angka--;
                                    }
                                    else
                                    {
                                        array2d[b, k] = angka.ToString();
                                        array2d[endbaris - b + startbaris, k] = angka.ToString();
                                        angka++;
                                    }


                                }
                            }
                        }
                    }
                }
                deret = deret + ((n + 1) / 2);
            }
        }
    }
}
