using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace autoapp
{
    public class AutoAppProgram
    {
        public static List<Auto> autok = new List<Auto>();
        static void Main(string[] args)
        {
            AdatBeolvas();
            Feladat5(autok);
            Feladat6(autok);
            Feladat7();
            Feladat8();
            Console.ReadKey();
        }

        public static void Feladat8()
        {
            Console.WriteLine("8. feladat: Legsikeresebb márkák listája az eldott darabszám alapján:");
            List<string> markak = new List<string>();
            List<int> eladasok = new List<int>();
            foreach (var auto in autok)
            {
                int index = markak.IndexOf(auto.Marka);
                if (index == -1)
                {
                    markak.Add(auto.Marka);
                    eladasok.Add(auto.EladottDb);
                }
                else
                {
                    eladasok[index] += auto.EladottDb;
                }
            }
            for (int i = 0; i < markak.Count; i++)
            {
                Console.WriteLine($"\t-{markak[i]}: {eladasok[i]} darab");
            }


        }

        public static void Feladat7()
        {
            Console.WriteLine("7. feladat");
            int aktualisEv = DateTime.Now.Year;
            foreach (var auto in autok)
            {
                if (auto.GyartasiEv >= aktualisEv - 5)
                {
                    Console.WriteLine($"\t-{auto.Marka} {auto.Modell} ({auto.GyartasiEv})");
                }
            }
        }

        public static double Feladat6(List<Auto> autok)
        {
            Console.Write("6. feladat: ");
            var atlagEladas = autok.Average(auto => auto.EladottDb);
            Console.WriteLine($"Az autók esetében az átlagosan eladott darabszám {Math.Round(atlagEladas, 1)}");
            return atlagEladas;
            /*
            int osszEladas = 0;
            foreach (var auto in autok)
            {
                osszEladas += auto.EladottDb;
            }
            double atlagEladas = osszEladas / autok.Count;
            Console.WriteLine($"Az autók esetében az átlagosan eladott darabszám {Math.Round(atlagEladas,1)}");
            */
        }

        public static int Feladat5(List<Auto> autok)
        {

            Console.Write("5. feladat: ");
            Console.WriteLine($"{autok.Count} autó található a listában.");
            return autok.Count;
        }

        public static void AdatBeolvas()
        {
            using (StreamReader reader = new StreamReader("autok.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string[] sor = reader.ReadLine().Split(';');
                    Auto auto = new Auto(int.Parse(sor[0]), sor[1], sor[2], int.Parse(sor[3]), sor[4], int.Parse(sor[5]), int.Parse(sor[6]));
                    autok.Add(auto);
                }

            }
        }
    }
}
