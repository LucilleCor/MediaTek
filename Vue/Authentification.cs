using MediaTek86.Controlleur;
using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.Vue
{
    /// <summary>
    /// Fenêtre d'authentification (seuls les responsable peuvent acceder)
    /// </summary>
    public partial class Authentification : Form
    {
        /// <summary>
        /// controleur de la fenêtre d'authentification
        /// </summary>
        private FrmAuthentificationControlleur controlleur;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public Authentification()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controlleur = new FrmAuthentificationControlleur();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            String login = txtbLogin.Text;
            String pwd = txtbPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else 
            { 
                Responsable responsable = new Responsable(login, pwd);
                if (controlleur.ControleAuthentification(responsable)) 
                {
                    MediaTek frm = new MediaTek();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect.", "Information");
                }
            }
        }
    }
}
