namespace MediaTek86.Model
{
    /// <summary>
    /// Classe métier interne pour la gestion de l'authentification du responsable
    /// </summary>
    public class Responsable
    {
        public string Login { get; }
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés de la classe Responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }

    }
}
