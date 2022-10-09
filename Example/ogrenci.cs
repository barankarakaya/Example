using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class ogrenci
    {
        private int ogrno;
        private string isim;
        private string Soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

         public ogrenci(int _ogrno,string _isim, string _Soyisim,int _vize1,int _vize2, int _final,string _okulIsmi)
        {
            ogrno = _ogrno;
            isim = _isim;
            Soyisim = _Soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }


        public double OgrenciNotuBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin Okulu :"+okulIsmi);
        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası :"+ogrno);
            Console.WriteLine("Öğrenci Adı :"+isim);
            Console.WriteLine("Öğrenci soyadı :"+Soyisim);
            Console.WriteLine("Öğrenci vize1 Notu :"+vize1);
            Console.WriteLine("Öğrenci vize2 Notu :"+vize2);
            Console.WriteLine("Öğrenci final Notu :"+final);
            Console.WriteLine("Öğrenci okul Adı :"+okulIsmi);
        }
    }
}
