using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel
{
    class sayi
    {
        static Random random = null;
        public static int uret(int min, int max) //Tek seferde olusturulacak sekilde statik bir uret fonsiyonu yapildi.
        {

            if (random == null)//Onceden olusturulmamissa random nesnesi olusturuldu.
                random = new Random();
            return random.Next(min, max);//Onceden olusturulan bir random nesnesi varsa deger geri donduruluyor.
        }
    }
}
