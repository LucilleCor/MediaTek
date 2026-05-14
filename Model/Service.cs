using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    public class Service
    {
        public int IdService { get; }
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés de la classe Service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.IdService = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom</returns>
        public override string ToString()
        {
            return this.Nom;

        }
    }
}
