// See https://aka.ms/new-console-template for more information
using System;

namespace DİZİKULLANIMI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];
            // Dizilere değer atama ve erişim
            renkler[0]="Mavi";
            dizi[3]= 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            // döngüler dizi kullanımı
            //klavyeden girilen m tame sayının ortalamasını hesaplayan program
            Console.Write("lütfen dizinin eleman sayyisini giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for(int i = 0; i< diziUzunlugu; i++)
           {
              Console.Write("lütfen {0}. sayyisi giriniz:"); 
              sayiDizisi[i] = int.Parse(Console.ReadLine());

           } 
            int toplam =0;
            foreach (var sayi in sayiDizisi)
                toplam +=sayi;
                
                Console.WriteLine("ortalam :" + toplam/diziUzunlugu);
      
        }  


    }
}
