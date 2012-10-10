using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Konuk
    {

        public string ad, soyad;
        public string ana_dili;

        public Konuk() { }

        public void yazdir()
        {
            Console.WriteLine("Adı:" + ad + "\nSoyadı:" + soyad + "\nDili:" + ana_dili);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            string[,] matris ={{"luke","leia","anakin","padme","emre","ali","veli","duku","eto","frodo","sam","bilbo","legolas","arven","galadriel","james","sherlock","sabri","john","ernesto che"},
                                 {"skywalker","dost","bagins","palpatin","gorbaçov","sarıoğlu","lenin","stalin","putin","windu","bond","guevera","wayne","stark","conner","banner","parker","osborn","banner","baggins"}};

            string[] dil_dizisi = { "TR", "ENG", "GER", "FRE", "JAP", "CHN", "RUS" };

            Console.WriteLine("Konuk sayısını giriniz");
            int x = Convert.ToInt32(Console.ReadLine());
            nesne_dizi_olustur(x, matris, dil_dizisi);
            Console.ReadKey();


        }

        static void nesne_dizi_olustur(int n, string[,] k, string[] l)
        {

            Konuk[] konuklar = new Konuk[n];

            for (int i = 0; i < n; i++)
            {
                konuklar[i] = new Konuk();

                int a = random_sayi(20);
                int b = random_sayi(20);
                int c = random_sayi(6);

                konuklar[i].ad = k[0, a];
                konuklar[i].soyad = k[1, b];
                konuklar[i].ana_dili = l[c];
                konuklar[i].yazdir();


            }
            dizileri_yazdir(konuklar, n);
        }

        static void dizileri_yazdir(Konuk[] guests, int s)
        {
            for (int i = 0; i < s; i++)
            {
                guests[i].yazdir();
            }
        }

        static int random_sayi(int d)
        {

            Random rastgele = new Random((int)DateTime.Now.Ticks);
            int k = rastgele.Next(0, d);
            return k;
        }
    }
}






    





