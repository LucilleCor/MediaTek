using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    public class Motif
    {
        public int IdMotif { get; set; }
        public string Libelle { get; set; }
        public Motif(int id, string libelle)
        {
            IdMotif = id;
            Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
