using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turkcell_Yarisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turkcell Bilgi Yarışması");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            int soru=1;
            string cevap;
            if (soru == 1)
            {
                Console.WriteLine("Türkiye'nin Başkenti Neresidir?");
                Console.WriteLine();
                Console.WriteLine("A) İstanbul");
                Console.WriteLine("B) Ankara");
                Console.WriteLine("C) İzmir");
                Console.WriteLine("D) Bursa");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap=="b" || cevap=="B")
                {
                    Console.WriteLine("Doğru Cevabı Seçtiniz");
                    soru = soru + 1;
                }
                else
                {
                    Console.Write(" Yanlış Cevap Puanınız: 0");
                }
            }
            if (soru==2)
            {
                Console.WriteLine("İstanbul Kaç Yılında Fethedildi?");
                Console.WriteLine();
                Console.WriteLine("A) 1451");
                Console.WriteLine("B) 1452");
                Console.WriteLine("C) 1453");
                Console.WriteLine("D) 1454");
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap=="c"|| cevap=="C")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Yanlış Cevabı Seçtiniz Puanınız:1");
                }
            }
            if (soru==3)
            {
                Console.WriteLine("Peygamber Efendimizin Annesinin Adı Nedir?");
                Console.WriteLine();
                Console.WriteLine("A) Fatma");
                Console.WriteLine("B) Amine");
                Console.WriteLine("C) Ayşe");
                Console.WriteLine("D) Halime");
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap=="d"||cevap=="D")
                {
                    Console.WriteLine("Doğru Cevabı Seçtiniz Puanınız: 3");
                }
                else
                {
                    Console.WriteLine("Yanlış Cevabı Seçtiniz Puanınız:2");
                }
            }


            Console.Read();
        }
    }
}
