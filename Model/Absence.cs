using System;

namespace MediaTek86.Model
{
    public class Absence
    {
        public int IdPersonnel { get; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Motif Motif { get; set; }

        /// <summary>
        /// Valorise les propriétés de la classe Absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.IdPersonnel = idpersonnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = motif;
        }
    }
}
