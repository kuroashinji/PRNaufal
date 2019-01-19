using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;
namespace Logic4
{
    class PR:logicbase
    {
        public PR(int n) { 
            jumlahbaris=n;
            jumlahkolom=n*2;
            Array2d=new string[jumlahbaris,jumlahkolom];
            isi();
            functionbase.print(Array2d);
        }
        private void isi(){
            int no=2;
            int[] ganjil=functionbase.reverseganjil(jumlahkolom);
            for (int i = 0; i < jumlahbaris; i++)
			{
			    for (int j = 0; j < jumlahkolom; j++){
                    
                    if (i <= j && i + j >= jumlahkolom/2-1)
                    {

                        Array2d[i, j] = ganjil[j].ToString();
                        //Array2d[i, (jumlahkolom-2)-j] = ganjil[j].ToString();
                        //Array2d[jumlahkolom / 2-1 - i, j ] = ganjil[j].ToString();
                        //Array2d[jumlahkolom / 2 - 1 - i, (jumlahkolom - 2) - j] = ganjil[j].ToString();
                    }
                    
                    
                    
                }
			
			}
        }
    }
}
