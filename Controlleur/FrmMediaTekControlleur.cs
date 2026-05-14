using MediaTek86.dal;
using MediaTek86.Model;
using System;
using System.Collections.Generic;

namespace MediaTek86.Controlleur
{
    /// <summary>
    /// Controleur de FrmMediaTek
    /// </summary>
    public class FrmMediaTekControlleur
    {
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
        /// Objet d'accès aux opérations possible sur les absences
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmMediaTekControlleur()
        {
            serviceAccess = new ServiceAccess();
            personnelaccess = new PersonnelAccess();
            motifAccess = new MotifAccess();
            absenceAccess = new AbsenceAccess();
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
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelaccess.DelPersonnel(personnel);
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
        /// Récupère et retourne la liste des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne la liste des motifs d'absence
        /// </summary>
        /// <returns></returns>
        public List<Motif>GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Récupère et retourne la liste des absence d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(Personnel personnel) 
        {
            return absenceAccess.GetLesAbsences(personnel);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence absence) 
        { 
            absenceAccess.UpdateAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Vérification si une absence existe déjà sur les dates
        /// </summary>
        /// <param name="absence"></param>
        /// <returns></returns>
        public Boolean DispoAbsence(Absence absence)
        {
            return absenceAccess.DispoAbsence(absence);
        }
    }
}
