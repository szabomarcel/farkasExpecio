using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farkasExpecio
{
    internal class Program
    {
        struct Adatok
        {
            public int napszam;
            public int radios;
            public string uzenet;
        }
        static void Main(string[] args)
        {
            Adatok seged;
            List<Adatok> list = new List<Adatok>();
            string sor;
            StreamReader sr = new StreamReader("veetel.txt");
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                seged.napszam = Convert.ToInt32(sor.Split(' ')[0]);
                seged.radios = Convert.ToInt32(sor.Split(' ')[1]);
                seged.uzenet = sr.ReadLine();
                list.Add(seged);
            }
            sr.Close();
            feladat_2();
            feladat_3();
            feladat_4();
            feladat_5();
            feladat_6();
            feladat_7();
            Console.ReadLine();
        }

        private static void feladat_7()
        {
            Console.WriteLine("7.feladat");
        }

        private static void feladat_6()
        {
           
        }

        private static void feladat_5()
        {
            
        }

        private static void feladat_4()
        {
            Console.WriteLine("4.feladat");
        }

        private static void feladat_3()
        {
            Console.WriteLine("3.feladat");
        }

        private static void feladat_2()
        {
            //Az első üzenet rögzítője: 13 Az utolsó üzenet rögzítője: 18
            Console.WriteLine("2.feladat: ");
            Console.WriteLine("Az első üzenet rögzítője:{}", list[0].radios);
            Console.WriteLine("Az utoldós üzenet rögzítője: {}", list[list.Count - 1].radios);
        }
    }
}
