using System;
using System.Collections.Generic;
using MediaTek86.Model;
using Serilog;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les services
    /// </summary>
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les profils des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select * from service order by nom";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("ServiceAccess.GetLesServices nb records={1}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("ServiceAccess.GetLesServices idservice={0} nom={1}", record[0], record[1]);
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ServiceAccess.GetLesServices catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}
