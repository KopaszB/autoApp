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
        static List<Auto> autok = new List<Auto>();
        static void Main(string[] args)
        {
            AdatBeolvas();
            AdatKiir();
            Feladat5(); 
            Feladat6();
            Feladat7();
            //Feladat8();


            Console.ReadKey();
        }

        

        static void Feladat7()
        {
            Console.WriteLine("7. feladat");
            int aktualisEv = DateTime.Now.Year;
            foreach (var auto in autok)
            {
                if (auto.GyartasiEv >= aktualisEv - 5)
                {
                    Console.WriteLine($"{auto.Marka} {auto.Modell} ({auto.GyartasiEv})");
                }
            }
        }

        static void Feladat6()
        {
            Console.Write("6. feladat: ");
            var atlagEladas = autok.Average(auto => auto.EladottDb);
            Console.WriteLine($"Az autók esetében az átlagosan eladott darabszám {Math.Round(atlagEladas, 1)}");
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

        public static int Feladat5()
        {
            
            //Console.Write("5. feladat: ");
            //Console.WriteLine($"{autok.Count} autó található a listában.");
            return autok.Count;
        }

        static void AdatKiir()
        {
            foreach (var item in autok)
            {
                Console.WriteLine($"{item.Sorszam,2} {item.Marka,15} {item.Modell,10}");
            }
            
        }

        public static void AdatBeolvas()
        {
            using (StreamReader reader = new StreamReader("autok.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string[] sor = reader.ReadLine().Split(';');
                    Auto auto = new Auto(int.Parse(sor[0]),sor[1],sor[2], int.Parse(sor[3]),sor[4], int.Parse(sor[5]), int.Parse(sor[6]));
                    autok.Add(auto);
                }

            }
        }
    }
}
