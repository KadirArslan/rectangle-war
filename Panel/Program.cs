using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel
{
    class Program
    {
        static void Main(string[] args)
        {
            dortgen[] d = new dortgen[100];//100 elemanli dortgen sifindan d adinda bir dizi olusturuldu.
            paneller panel = new paneller();//paneller sinifindan panel isimli bir nesne olusturuldu.
            int index = 0;//Olusturulacak dortgen sayisini tutmak icin index adinda bir degisken olusturuldu.
            string secenek = "k";//secenek degiskeni icin while dongusune girsin diye ilk basta k degeri verildi.
            bool sinirkontrol;//Siniri kontrol etmek icin bool adinda degisken olusturuldu.
            while (secenek == "e" || secenek == "a" || secenek == "d" || secenek == "w" || secenek == "s" || secenek == "k")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                panel.Ciz(0, 0, 70, 28);
                Console.ForegroundColor = ConsoleColor.Green;
                panel.Ciz(72, 0, 42, 13);
                Console.ResetColor();
                Console.SetCursorPosition(85, 1);
                Console.Write("KONTROL PANELI");
                Console.SetCursorPosition(85, 3);
                Console.Write("Sekil Ekle  (E)");
                Console.SetCursorPosition(85, 5);
                Console.Write("Sola Otele  (A)");
                Console.SetCursorPosition(85, 7);
                Console.Write("Saga Otele  (D)");
                Console.SetCursorPosition(85, 9);
                Console.Write("Yukari Otele  (W)");
                Console.SetCursorPosition(85, 11);
                Console.Write("Asagi Otele  (S)");
                Console.ForegroundColor = ConsoleColor.Blue;
                panel.Ciz(72, 16, 42, 12);
                Console.ResetColor();
                //Konsol Sahnesi Cizildi.
                if (secenek == "e")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    panel.Ciz(0, 0, 70, 28);
                    Console.ForegroundColor = ConsoleColor.Green;
                    panel.Ciz(72, 0, 42, 13);
                    Console.ResetColor();
                    Console.SetCursorPosition(85, 1);
                    Console.Write("KONTROL PANELI");
                    Console.SetCursorPosition(85, 3);
                    Console.Write("Sekil Ekle  (E)");
                    Console.SetCursorPosition(85, 5);
                    Console.Write("Sola Otele  (A)");
                    Console.SetCursorPosition(85, 7);
                    Console.Write("Saga Otele  (D)");
                    Console.SetCursorPosition(85, 9);
                    Console.Write("Yukari Otele  (W)");
                    Console.SetCursorPosition(85, 11);
                    Console.Write("Asagi Otele  (S)");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    panel.Ciz(72, 16, 42, 12);
                    Console.ResetColor();
                    d[index] = new dortgen();

                    d[index].konumGoster();
                    for (int i = 0; i <= index; i++)
                        d[i].Ciz();
                    index++;
                    //Konsol Temizlendikten sonra yeniden konsol sahnesi cizildi. Olusturulan dortgen ve eger oncesinde
                    //olusturulmus dortgen varsa onlar cizildi. Index degiskeni arttirildi.
                }
                if (secenek == "d")
                {
                    bool kontrol = true;
                    for (int k = 0; k < index - 1; k++)
                    {
                        if (
                       d[index - 1].konumx + d[index - 1].genislik + 1 >= d[k].konumx &&
                       d[index - 1].konumx - 1 <= d[k].konumx + d[k].genislik &&
                       d[index - 1].konumy - 1 <= d[k].konumy + d[k].yukseklik &&
                        d[index - 1].konumy + d[index - 1].yukseklik + 1 >= d[k].konumy)
                            kontrol = false;
                    }
                    //Dortgenlerin birbirine degip degmeme kontrol yapildi.
                    if (d[index - 1].konumx + d[index - 1].genislik > 68)
                        sinirkontrol = false;
                    else
                        sinirkontrol = true;
                    //Konsol sahnesi kontrolu yapildi.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    panel.Ciz(0, 0, 70, 28);
                    Console.ForegroundColor = ConsoleColor.Green;
                    panel.Ciz(72, 0, 42, 13);
                    Console.ResetColor();
                    Console.SetCursorPosition(85, 1);
                    Console.Write("KONTROL PANELI");
                    Console.SetCursorPosition(85, 3);
                    Console.Write("Sekil Ekle  (E)");
                    Console.SetCursorPosition(85, 5);
                    Console.Write("Sola Otele  (A)");
                    Console.SetCursorPosition(85, 7);
                    Console.Write("Saga Otele  (D)");
                    Console.SetCursorPosition(85, 9);
                    Console.Write("Yukari Otele  (W)");
                    Console.SetCursorPosition(85, 11);
                    Console.Write("Asagi Otele  (S)");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    panel.Ciz(72, 16, 42, 12);
                    Console.ResetColor();
                    if (sinirkontrol && kontrol)
                        d[index - 1].saga();
                    d[index - 1].konumGoster();
                    for (int i = 0; i < index; i++)
                        d[i].Ciz();
                    //Ekran temizlenip kontoller dogrultusunda islemler yapildi.
                }
                if (secenek == "a")
                {
                    bool kontrol = true;
                    for (int k = 0; k < index - 1; k++)
                    {
                        if (
                    d[index - 1].konumx + d[index - 1].genislik + 0 >= d[k].konumx &&
                    d[index - 1].konumx - 2 <= d[k].konumx + d[k].genislik &&
                    d[index - 1].konumy - 1 <= d[k].konumy + d[k].yukseklik &&
                    d[index - 1].konumy + d[index - 1].yukseklik + 1 >= d[k].konumy)
                            kontrol = false;
                    }

                    if (d[index - 1].konumx < 2)
                        sinirkontrol = false;
                    else
                        sinirkontrol = true;
                    //Konsol sahnesi ve dortgen'e degip degmeme kontrolu yapildi.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    panel.Ciz(0, 0, 70, 28);
                    Console.ForegroundColor = ConsoleColor.Green;
                    panel.Ciz(72, 0, 42, 13);
                    Console.ResetColor();
                    Console.SetCursorPosition(85, 1);
                    Console.Write("KONTROL PANELI");
                    Console.SetCursorPosition(85, 3);
                    Console.Write("Sekil Ekle  (E)");
                    Console.SetCursorPosition(85, 5);
                    Console.Write("Sola Otele  (A)");
                    Console.SetCursorPosition(85, 7);
                    Console.Write("Saga Otele  (D)");
                    Console.SetCursorPosition(85, 9);
                    Console.Write("Yukari Otele  (W)");
                    Console.SetCursorPosition(85, 11);
                    Console.Write("Asagi Otele  (S)");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    panel.Ciz(72, 16, 42, 12);
                    Console.ResetColor();
                    if (sinirkontrol && kontrol)
                        d[index - 1].sola();
                    d[index - 1].konumGoster();
                    for (int i = 0; i < index; i++)
                        d[i].Ciz();
                    //Kontroller dogrultusunda islemler yapildi.
                }
                if (secenek == "w")
                {
                    bool kontrol = true;
                    for (int k = 0; k < index - 1; k++)
                    {
                        if (
                       d[index - 1].konumx + d[index - 1].genislik + 0 >= d[k].konumx &&
                       d[index - 1].konumx - 1 <= d[k].konumx + d[k].genislik &&
                       d[index - 1].konumy - 2 <= d[k].konumy + d[k].yukseklik &&
                       d[index - 1].konumy + d[index - 1].yukseklik + 1 >= d[k].konumy)
                            kontrol = false;
                    }
                    if (d[index - 1].konumy < 2)
                        sinirkontrol = false;
                    else
                        sinirkontrol = true;
                    //Konsol sahnesi ve dortgen'e degip degmeme kontrolu yapildi.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    panel.Ciz(0, 0, 70, 28);
                    Console.ForegroundColor = ConsoleColor.Green;
                    panel.Ciz(72, 0, 42, 13);
                    Console.ResetColor();
                    Console.SetCursorPosition(85, 1);
                    Console.Write("KONTROL PANELI");
                    Console.SetCursorPosition(85, 3);
                    Console.Write("Sekil Ekle  (E)");
                    Console.SetCursorPosition(85, 5);
                    Console.Write("Sola Otele  (A)");
                    Console.SetCursorPosition(85, 7);
                    Console.Write("Saga Otele  (D)");
                    Console.SetCursorPosition(85, 9);
                    Console.Write("Yukari Otele  (W)");
                    Console.SetCursorPosition(85, 11);
                    Console.Write("Asagi Otele  (S)");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    panel.Ciz(72, 16, 42, 12);
                    Console.ResetColor();
                    if (sinirkontrol && kontrol)
                        d[index - 1].yukari();
                    d[index - 1].konumGoster();
                    for (int i = 0; i < index; i++)
                        d[i].Ciz();
                    //Kontroller dogrultusunda islemler yapildi.
                }
                if (secenek == "s")
                {
                    bool kontrol = true;
                    for (int k = 0; k < index - 1; k++)
                    {
                        if (
                       d[index - 1].konumx + d[index - 1].genislik + 0 >= d[k].konumx &&
                       d[index - 1].konumx - 1 <= d[k].konumx + d[k].genislik &&
                       d[index - 1].konumy - 1 <= d[k].konumy + d[k].yukseklik &&
                       d[index - 1].konumy + d[index - 1].yukseklik + 2 >= d[k].konumy)
                            kontrol = false;

                    }
                    if (d[index - 1].konumy + d[index - 1].yukseklik > 26)
                        sinirkontrol = false;
                    else
                        sinirkontrol = true;
                    //Konsol sahnesi ve dortgen'e degip degmeme kontrolu yapildi.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    panel.Ciz(0, 0, 70, 28);
                    Console.ForegroundColor = ConsoleColor.Green;
                    panel.Ciz(72, 0, 42, 13);
                    Console.ResetColor();
                    Console.SetCursorPosition(85, 1);
                    Console.Write("KONTROL PANELI");
                    Console.SetCursorPosition(85, 3);
                    Console.Write("Sekil Ekle  (E)");
                    Console.SetCursorPosition(85, 5);
                    Console.Write("Sola Otele  (A)");
                    Console.SetCursorPosition(85, 7);
                    Console.Write("Saga Otele  (D)");
                    Console.SetCursorPosition(85, 9);
                    Console.Write("Yukari Otele  (W)");
                    Console.SetCursorPosition(85, 11);
                    Console.Write("Asagi Otele  (S)");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    panel.Ciz(72, 16, 42, 12);
                    Console.ResetColor();
                    if (sinirkontrol && kontrol)
                        d[index - 1].asagi();
                    d[index - 1].konumGoster();
                    for (int i = 0; i < index; i++)
                        d[i].Ciz();
                    //Kontroller dogrultusunda islemler yapildi.
                }
                Console.ResetColor();
                Console.SetCursorPosition(72, 15);
                secenek = Console.ReadKey().KeyChar.ToString();
                //Secenek degiskeni yeniden alindi. Ve dongu basa donuyor.
            }
        }
    }
}
