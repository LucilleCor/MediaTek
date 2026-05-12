namespace MediaTek86.Model
{
    public class Motif
    {
        public string IdMotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés de la classe Motif
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(string idmotif, string libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le libelle)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }

}
