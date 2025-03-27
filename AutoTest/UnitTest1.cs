using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using autoapp;
using System.Collections.Generic;
using System.IO;

namespace AutoTest
{
    [TestClass]
    public class AutoAppProgramTest
    {
        /*
        public List<Auto> autok = new List<Auto>();
        public void AdatBeolvas()
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
        public List<Auto> TesztAdatok()
        {
            return new List<Auto>
            {
            new Auto(1,"Toyota","Corolla",2022,"Fehér",10,20000),
            new Auto(2,"Ford","Focus",2020,"Fekete",20,25000),
            new Auto(3,"BMW","X5",2018,"Szürke",30,50000)
            };
        }*/

        [TestMethod]
        public void Test_5_Feladat_AutoListaMeret()
        {
            AutoAppProgram.AdatBeolvas();
            int result = AutoAppProgram.Feladat5();
            Assert.AreEqual(15, result);
        }
        /*
        [TestMethod]
        public void Test_6_Feladat_AtlagEladas()
        {
            var autok = TesztAdatok();
            double osszEladas = 0;
            foreach (var auto in autok)
            {
                osszEladas += auto.EladottDb;
            }
            double atlag = autok.Count > 0 ? osszEladas / autok.Count : 0;
            Assert.AreEqual(20.0, atlag, 0.1);
        }

        [TestMethod]
        public void Test_7_Feladat_Utolso5Ev()
        {
            var autok = TesztAdatok();
            int aktualisEv = 2025; // Teszt miatt fix évszám
            var ujAutok = new List<Auto>();

            foreach (var auto in autok)
            {
                if (auto.GyartasiEv >= aktualisEv - 5)
                {
                    ujAutok.Add(auto);
                }
            }

            Assert.AreEqual(2, ujAutok.Count);
        }

        [TestMethod]
        public void Test_8_Feladat_MarkaEladasok()
        {
            var autok = TesztAdatok();
            var markaEladasok = new Dictionary<string, int>();
            foreach (var auto in autok)
            {
                if (!markaEladasok.ContainsKey(auto.Marka))
                {
                    markaEladasok[auto.Marka] = 0;
                }
                markaEladasok[auto.Marka] += auto.EladottDb;
            }

            Assert.AreEqual(10, markaEladasok["Toyota"]);
            Assert.AreEqual(20, markaEladasok["Ford"]);
            Assert.AreEqual(30, markaEladasok["BMW"]);
        }*/
    }
}
