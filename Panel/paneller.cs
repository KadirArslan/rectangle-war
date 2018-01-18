using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel
{
    class paneller
    {
        public void Ciz(int konumx, int konumy, int genislik, int yukseklik)//x konumu,y konumu,genislik ve yukseklik parametreli  olan
                                                                            //fonksiyon olusturuldu.
        {

            Console.SetCursorPosition(konumx, konumy);//Cursor Pozisyonu istenen konuma gore degistirildi.
            for (int i = 0; i < genislik; i++)
            {
                if (i == 0)
                    Console.Write("╔");
                if (i == genislik - 1)
                    Console.Write("╗");
                else Console.Write("═");
            }//Dortgenin ust kenari icin duzenlemeler yapildi.
            Console.SetCursorPosition(konumx, konumy + yukseklik + 1);
            for (int i = 0; i < genislik; i++)
            {
                if (i == 0)
                    Console.Write("╚");
                if (i == genislik - 1)
                    Console.Write("╝");
                else Console.Write("═");
            }//Dortgenin alt kenari icin duzenlemeler yapildi.
            for (int i = 0; i < yukseklik; i++)
            {
                Console.SetCursorPosition(konumx, konumy + i + 1);
                Console.Write("║");
                Console.SetCursorPosition(konumx + genislik, konumy + i + 1);
                Console.Write("║");
            }//Sag ve sol kenarlar icin duzenleme yapildi.
        }
    }
}
