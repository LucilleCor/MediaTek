using MediaTek86.Model;
using Serilog;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les motifs d'absence
    /// </summary>
    public class MotifAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public MotifAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les profils des motifs d'absence
        /// </summary>
        /// <returns></returns>
        public List<Motif>GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            if (access.Manager != null)
            {
                string req = "select * from motif order by libelle";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("MotifAccess.GetLesMotifs nb records={1}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("MotifAccess.GetLesMotifs idmotif={0} libelle={1}", record[0], record[1]);
                            Motif motif = new Motif((int)record[0], (string)record[1]);
                            lesMotifs.Add(motif);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("MotifAccess.GetLesMotifs catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesMotifs;
        }
    }
}
