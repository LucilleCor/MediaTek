using MediaTek86.dal;
using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Controlleur
{
    /// <summary>
    /// Controleur de FrmMediaTek
    /// </summary>
    public class FrmMediaTekControlleur
    {
        /// <summary>
        /// Boolean pour savoir si une modification d'un personnel est demandée
        /// </summary>
        private Boolean EnCoursModifPersonnel = false;
        /// <summary>
        /// Objet d'accès aux opérations possible sur les personnels
        /// </summary>
        private readonly PersonnelAccess personnelaccess;
        /// <summary>
        /// Objet d'accès aux opérations possible sur les services
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// Objet d'accès aux opérations possible sur les motifs d'absence
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmMediaTekControlleur()
        {
            serviceAccess = new ServiceAccess();
            personnelaccess = new PersonnelAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelaccess.GetLesPersonnels();
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelaccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelaccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelaccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne la liste des services
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne la liste des motifs d'absence
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }
    }
}
