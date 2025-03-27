using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoapp
{
    public class Auto
    {
        /*
        public int sorszam;
        public string marka;
        public string modell;
        public int gyartasiEv;
        public string szin;
        public int eladottDb;
        public int ar;

        public Auto(int sorszam, string marka, string modell, int gyartasiEv, string szin, int eladottDb, int ar)
        {
           this.sorszam = sorszam;
           this.marka = marka;
           this.modell = modell;
           this.gyartasiEv = gyartasiEv;
           this.szin = szin;
           this.eladottDb = eladottDb;
           this.ar = ar;
        }
        */
        // ...vagy tulajdonságok alapján

        /*Használhatunk tulajdonságokat(properties) privát mezők helyett
        Ha az osztálynak getter és setter metódusokat szeretnénk biztosítani, akkor érdemes az adathozzáférést tulajdonságokon keresztül megvalósítani.*/

        // Tulajdonságok
        public int Sorszam { get; set; }
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int GyartasiEv { get; set; }
        public string Szin { get; set; }
        public int EladottDb { get; set; }
        public int Ar { get; set; }

        public Auto(int sorszam, string marka, string modell, int gyartasiEv, string szin, int eladottDb, int ar)
        {
            Sorszam = sorszam;
            Marka = marka;
            Modell = modell;
            GyartasiEv = gyartasiEv;
            Szin = szin;
            EladottDb = eladottDb;
            Ar = ar;
        }


    }
}
