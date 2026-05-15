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

        /// <summary>
        /// Valorise les propriétés de la classe Motif
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Motif(int id, string libelle)
        {
            IdMotif = id;
            Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le libelle)
        /// </summary>
        /// <returns>libelle</returns>
        public override string ToString()
        {
            return Libelle;
        }
    }
}
