using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel
{
    class dortgen
    {
        public int konumx = sayi.uret(1, 48);//Olustulacak Dortgen icin rastegele x konumu bilgisi alindi.
        public int konumy = sayi.uret(1, 19);//Olustulacak Dortgen icin rastegele y konumu bilgisi alindi.
        public int genislik = sayi.uret(2, 20);//Olustulacak Dortgen icin rastegele genislik bilgisi alindi.
        public int yukseklik = sayi.uret(2, 8);//Olustulacak Dortgen icin rastegele yukseklik bilgisi alindi.
        //Rastegele bilgiler statik sayi fonksiyonundan alindi.
        private ConsoleColor renk = (ConsoleColor)sayi.uret(1, 15);
        //Rastgele renk alindi.
        public void konumGoster()
        {
            Console.ResetColor();
            Console.SetCursorPosition(85, 19);
            Console.Write("DIKDORTGEN BILGILERI");
            Console.SetCursorPosition(85, 20);
            Console.Write("X KONUMU ...: {0}", konumx);
            Console.SetCursorPosition(85, 21);
            Console.Write("Y KONUMU ...: {0}", konumy);
            Console.SetCursorPosition(85, 22);
            Console.Write("GENISLIK ...: {0}", genislik);
            Console.SetCursorPosition(85, 23);
            Console.Write("YUKSEKLIK ..: {0}", yukseklik);
            Console.SetCursorPosition(85, 24);
            Console.Write("Renk .......:,{0}", renk);
            //Olusturulan dortgenin bilgileri ekrana bu fonksiyon ile yazildi.
        }

        public void Ciz()
        /*Rastgele alinan bilgilerle dortgen'i cizen fonksiyon*/
        {
            Console.ForegroundColor = renk;
            Console.SetCursorPosition(konumx, konumy);
            for (int i = 0; i < genislik; i++)
            {
                if (i == 0)
                    Console.Write("╔");
                if (i == genislik - 1)
                    Console.Write("╗");
                else
                    Console.Write("═");
            }
            Console.SetCursorPosition(konumx, konumy + yukseklik + 1);
            for (int i = 0; i < genislik; i++)
            {
                if (i == 0)
                    Console.Write("╚");
                if (i == genislik - 1)
                    Console.Write("╝");
                else Console.Write("═");
            }
            for (int i = 0; i < yukseklik; i++)
            {
                Console.SetCursorPosition(konumx, konumy + i + 1);
                Console.Write("║");
                Console.SetCursorPosition(konumx + genislik, konumy + i + 1);
                Console.Write("║");
            }


        }
        public void sola()//Dortgenin sola hareketini saglamak icin x konumunu azaltan fonksiyon.
        {

            konumx -= 1;
        }
        public void saga()//Dortgenin saga hareketini saglamak icin x konumunu arttiran fonksiyon.
        {
            konumx += 1;
        }
        public void asagi()//Dortgenin asagi hareketini saglamak icin y konumunu arttiran fonksiyon.
        {
            konumy += 1;
        }
        public void yukari()//Dortgenin yukari hareketini saglamak icin y konumunu azaltan fonksiyon.
        {
            konumy -= 1;
        }
    }
}
