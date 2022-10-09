using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            ogrenci ogrenci1 = new ogrenci(1663,"Baran","Karakaya",45,60,55,"Sakarya Üniversitesi");

            Console.WriteLine("Uygulamaya Hoş Geldiniz. Yapmak İstediğiniz İşlemi Seçiniz.");
            islemleriGoster();
            

            while (kontrol)
            {
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrenci1.OgrenciBilgileriGoster();
                        break;
                    case "2":
                        double ogrenciOrtalama = ogrenci1.OgrenciNotuBul();
                        if (ogrenciOrtalama < 50)
                        {
                            Console.WriteLine("Ortalaması Cok Düşük.");
                        }
                        else
                        {
                            Console.WriteLine("Ortalaması Gayet Güzel");
                        }
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;


                }
            }
        }


        static void islemleriGoster()
        {
            Console.WriteLine("1-Öğrenci Bilgileri Göster");
            Console.WriteLine("2-Öğrenci Ortalaması Göster");
            Console.WriteLine("3-Öğrenci Okulunu Göster");
            Console.WriteLine("4-Cıkış Yap");
        }
    }
}
