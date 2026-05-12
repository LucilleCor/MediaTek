namespace MediaTek86.Model
{
    /// <summary>
    /// Classe métier interne pour la gestion de l'authentification du responsable
    /// </summary>
    public class Responsable
    {
        public string login { get; }
        public string pwd { get; }

        /// <summary>
        /// Constructeur de la classe Responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

    }
}
