using System;
using MediaTek86.dal;
using MediaTek86.Model;
using Serilog;

namespace MediaTek86.Controlleur
{
    class FrmAuthentificationControlleur
    {
        /// <summary>
        /// Objet d'accès aux opérations possible
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmAuthentificationControlleur()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Controle l'authentification d'un responsable
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            try
            {
                return personnelAccess.ControleAuthentification(responsable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Log.Error("FrmAuthentificationControlleur.ControleAuthentification catch erreur={0}", e.Message);
                Environment.Exit(0);
                return false;
            }
        }
    }
}
