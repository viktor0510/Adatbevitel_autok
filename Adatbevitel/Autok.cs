using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbevitel
{
    class Autok
    {
        string Rendszam;
        int Teljesitmeny;
        string Gyartmany;
        string Tipus;

        public string Rendszám { get => Rendszam; }
        public int Teljesítmény { get => Teljesitmeny; set => Teljesitmeny = value; }
        public string Gyártmány { get => Gyartmany; set => Gyartmany = value; }
        public string Típus { get => Tipus; set => Tipus = value; }

        public Autok(string Rendszam, int Teljesitmeny, string Gyartmany, string Tipus)
        {
            this.Rendszam = Rendszam;
            this.Teljesítmény = Teljesitmeny;
            this.Gyártmány = Gyartmany;
            this.Típus = Tipus;
        }

        public override string ToString()
        {
            return Rendszam + " (" + Teljesitmeny + "lóerő)";
        }
    }
}
