using System;
using MediaTek86.dal;
using MediaTek86.Model;
using Serilog;

namespace MediaTek86.Controlleur
{
    class FrmAuthentificationControlleur
    {
        private readonly PersonnelAccess personnelAccess;

        public FrmAuthentificationControlleur()
        {
            personnelAccess = new PersonnelAccess();
        }

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
