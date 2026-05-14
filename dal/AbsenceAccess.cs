using MediaTek86.Model;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.dal
{
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        /// <param name="access"></param>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne la liste des absences d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, a.idmotif as idmotif, m.libelle as libelle ";
                req += "FROM personnel p JOIN absence a ON(p.idpersonnel = a.idpersonnel) JOIN motif m ON(a.idmotif = m.idmotif) ";
                req += "WHERE p.idpersonnel = @idPersonnel ORDER BY a.datedebut DESC;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@idPersonnel", personnel.IdPersonnel}
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        Log.Debug("AbsenceAccess.GetLesAbsences nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("AbsenceAccess.GetLesAbsences Motif : idmotif={0} libelle={1}", record[3], record[4]);
                            Log.Debug("AbsenceAccess.GetLesAbsences Absence : idpersonnel={0} datedebut={1} datefin={2} ", record[0], record[1], record[2]);
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.GetLesAbsences catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "UPDATE absence ";
                req += "SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@datedebut", absence.DateDebut},
                    {"@datefin", absence.DateFin},
                    {"@idmotif", absence.Motif.IdMotif },
                    {"@idpersonnel", absence.IdPersonnel }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.UpdateAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande à ajouter une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) ";
                req += "VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut},
                    { "@datefin", absence.DateFin},
                    { "@idmotif", absence.Motif.IdMotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.AddAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM absence WHERE datedebut = @datedebut AND idpersonnel = @idpersonnel; ";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.DelAbsencecatch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Vérification si un créneau est déjà occupé par une absence pour un personnel donné
        /// </summary>
        /// <param name="absence"></param>
        /// <returns></returns>
        public Boolean DispoAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "SELECT * FROM absence WHERE ((@datedebut BETWEEN datedebut AND datefin) OR (@datefin BETWEEN datedebut AND datefin)) ";
                req += "AND idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin }
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null && records.Count > 0)
                    {
                        return false;
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.DispoAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }                
            }
            return true;
        }
    }
}
