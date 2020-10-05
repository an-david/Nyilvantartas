using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyilvantartas
{
    class Gepjarmu
    {
        string rendszam;
        string tipus;
        string gyartmany;
        string teljesitmeny;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Gyartmany { get => gyartmany; set => gyartmany = value; }
        public string Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }

        public Gepjarmu(string rendszam, string tipus, string gyartmany, string teljesitmeny)
        {
            Rendszam = rendszam;
            Tipus = tipus;
            Gyartmany = gyartmany;
            Teljesitmeny = teljesitmeny;
        }

        public override string ToString()
        {
            return rendszam + " " + tipus + " " + gyartmany + " " + teljesitmeny;
        }
    }
}
