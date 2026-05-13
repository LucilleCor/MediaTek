using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.Controlleur;
using MediaTek86.Model;

namespace MediaTek86
{
    public partial class MediaTek : Form
    {
        /// <summary>
        /// Controlleur de la fenêtre
        /// </summary>
        private FrmMediaTekControlleur controlleur;
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;


        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public MediaTek()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controlleur = new FrmMediaTekControlleur();
            RemplirListePersonnel();
            RemplirListeService();
        }

        /// <summary>
        /// Affichage de la liste des personnels
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controlleur.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["IdPersonnel"].Visible = false;
            dgvPersonnel.Columns["Motif"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affichage de la liste des services
        /// </summary>
        private void RemplirListeService()
        {
            List<Motif> lesServices = controlleur.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
        }

        /// <summary>
        /// Demande de modification d'un personnel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificationPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursModificationPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtbNom.Text = personnel.Nom;
                txtbPrenom.Text = personnel.Prenom;
                txtbTel.Text = personnel.Tel;
                txtbMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutPerso_Click(object sender, EventArgs e)
        {
            EnCoursModificationPersonnel(false);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuppPerso_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controlleur.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Valider la demande d'ajout ou de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderPerso_Click(object sender, EventArgs e)
        {
            if (!txtbNom.Text.Equals("") && !txtbPrenom.Text.Equals("") && !txtbTel.Text.Equals("") && !txtbMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Motif service = (Motif)bdgService.List[bdgService.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtbNom.Text;
                    personnel.Prenom = txtbPrenom.Text;
                    personnel.Tel = txtbTel.Text;
                    personnel.Mail = txtbMail.Text;
                    personnel.Service = service;
                    controlleur.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtbNom.Text, txtbPrenom.Text, txtbTel.Text, txtbMail.Text, service);
                    controlleur.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursModificationPersonnel(false);
                grbModifPersonnel.Enabled = false;
                grbPersonel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Annuler la demande d'ajout ou de modification d'un personnel
        /// Vide les zones de saisie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPerso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModificationPersonnel(false);
                grbModifPersonnel.Enabled = false;
                grbPersonel.Enabled = true;
            }
        }
        
        /// <summary>
        /// Modification de l'affichage suivant si modification ou ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModificationPersonnel(Boolean modif)
        {
            grbModifPersonnel.Enabled = true;
            enCoursDeModifPersonnel = modif;
            grbPersonel.Enabled = !modif;
            if (modif)
            {
                grbModifPersonnel.Text = "Modification d'un personnel";
            }
            else
            {
                grbModifPersonnel.Text = "Ajout d'un personnel";
                txtbNom.Text = "";
                txtbPrenom.Text = "";
                txtbTel.Text = "";
                txtbMail.Text = "";
            }
        }


    }
}
