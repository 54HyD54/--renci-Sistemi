using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öğrenci_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            bool devam = true;
            SistemMenüleri();
            string secim = "";
            Console.WriteLine();

            while (devam)
            {
                Console.Write("Lütfen Bir Menü Seçiniz: ");
                secim = Console.ReadLine();
                Console.WriteLine();

                if(secim == "1")
                {
                    OgrenciEkle();
                }
                else if(secim == "2")
                {
                    OgrenciListele();
                }
                else if(secim == "3")
                {
                    OgrenciSil();
                }
                else if(secim == "4")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Çıkış Yapılıyor...");
                    Console.ResetColor();
                    devam = false;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim Yaptınız!!");
                }
            }

        }

        static List<string> ogrenciler = new List<string>();

        static void SistemMenüleri()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Öğrenci Kayıt Sistemi");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1)Öğrenci Ekle\n2)Öğrencileri Listele\n3)Öğrenci Sil\n4)Çıkış");
            Console.ResetColor();
        }
        static void OgrenciEkle()
        {
            Console.Write("Lütfen Eklemek İstediğiniz Öğrenci İsmini Giriniz: ");
            string isim = Console.ReadLine();
            ogrenciler.Add(isim);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Öğrenci Başarıyla Eklendi!!");
            Console.ResetColor();
            Console.WriteLine();
        }
        static void OgrenciListele()
        {
            Console.WriteLine("ÖĞRENCİ İSİMLERİ");

            for(int i = 0; i < ogrenciler.Count; i++)
            {
                Console.WriteLine($"{i + 1}){ogrenciler[i]}");
            }
            Console.WriteLine();
        }
        static void OgrenciSil()
        {
            int i = 0;
            Console.WriteLine("ÖĞRENCİ İSİMLERİ");

            for (i = 0; i < ogrenciler.Count; i++)
            {
                Console.WriteLine($"{i + 1}){ogrenciler[i]}");
            }

            Console.WriteLine();
            Console.Write("Lütfen Silmek İstediğiniz Öğrencinin İsmini Giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine();
            if(ogrenciler.Contains(isim))
            {
                ogrenciler.Remove(isim);
                Console.WriteLine("Öğrenci Silindi!!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Hatalı İsim Girdiniz!!");
                Console.WriteLine();
            }
        }
    }
}
