﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    class Kepesseg
    {
        int id;
        string nev;
        string leiras;
        int harcos_id;
       

        

        public Kepesseg(int id, string nev, string leiras, int harcos_id)
        {
            this.Id = id;
            this.Nev = nev;
            this.Leiras = leiras;
            this.Harcos_id = harcos_id;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Harcos_id { get => harcos_id; set => harcos_id = value; }

        public override string ToString()
        {
            return this.nev;
        }

        
    }
}
