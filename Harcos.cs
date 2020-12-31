using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosokApplication
{
    class Harcos
    {
        int id;
        string nev;
        string letrehozas;

        public Harcos(int id, string nev, string letrehozas)
        {
            this.id = id;
            this.nev = nev;
            this.letrehozas = letrehozas;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Letrehozas { get => letrehozas; set => letrehozas = value; }

        public override string ToString()
        {
            return this.nev+" ("+this.letrehozas+")";
        }
    }
}
