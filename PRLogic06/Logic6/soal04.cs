using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic6
{
    class soal04:logicbase
    {
        public soal04(int n){
            jumlahbaris=n*n;
            jumlahkolom=n*n;
            array2d=new string[jumlahbaris,jumlahkolom];
            isiarray(n);
            functionbase.print(array2d);
        }
        private void isiarray(int n){
            int angka = 1;
            for (int bb = 0; bb < n; bb++)
			{
                
                for (int bk = 0; bk < n; bk++){
                    int startbaris=bb*n;
                    int startkolom=bk*n;
                    int endbaris=startbaris+n-1;
                    int endkolom=startkolom+n-1;
                    bool trigger = true;
                    
                    for (int b = startbaris; b <= endbaris; b++)
			        {
                        
			            for(int k=startkolom;k<=endkolom;k++)
                        {
                            if (bb == bk) { 
                            //array2d[b,k]="*";
                                if (trigger)
                                {
                                    array2d[b, k] = angka.ToString();
                                    angka = angka + 2;
                                }
                                else {
                                    array2d[b, endkolom-k+startkolom] = angka.ToString();
                                    angka = angka + 2;
                                }
                            }
                        }
                        trigger = !trigger;
			        }

                }
			{
			 
			}
			 
			}
        }
    }
}
