namespace MediaTek86.Model
{
    public class Service
    {
        public int IdService { get;}
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés de la classe Service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="libelle"></param>
        public Service(int idservice, string libelle)
        {
            this.IdService = idservice;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Défnit l'information à afficher (juste le libellé)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
