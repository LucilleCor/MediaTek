namespace MediaTek86.Model
{
    public class Motif
    {
        public int IdService { get;}
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés de la classe Motif
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Motif(int idservice, string nom)
        {
            this.IdService = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Défnit l'information à afficher (juste le libellé)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
