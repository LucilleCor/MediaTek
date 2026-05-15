using MediaTek86.Controlleur;
using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.Vue
{
    /// <summary>
    /// Fenêtre principale de l'application, elle permet de gérer les personnels et leurs absences
    /// </summary>
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
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotif = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";
        /// <summary>
        /// Booléen pour savoir si une modification de personnel est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Booléen pour savoir si une modification d'absence est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;


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
            RemplirListeMotif();
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
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affichage de la liste des services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controlleur.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
        }

        /// <summary>
        /// Affichage de la liste des motifs
        /// </summary>
        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controlleur.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotif;
        }

        /// <summary>
        /// Affichage de la liste des absence d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        private void RemplirListeAbsence(Personnel personnel)
        {
            List<Absence> lesAbsences = controlleur.GetLesAbsences(personnel);
            bdgAbsence.DataSource = lesAbsences;
            dgvAbsence.DataSource = bdgAbsence;
            dgvAbsence.Columns["IdPersonnel"].Visible = false;
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
                grbAbsences.Enabled = false;
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
            grbAbsences.Enabled = false;
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
                Service service = (Service)bdgService.List[bdgService.Position];
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
                grbAbsences.Enabled = true;
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
                grbAbsences.Enabled = true;
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

        /// <summary>
        /// Changement de l'affichage de la liste des absences suivant le personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                RemplirListeAbsence(personnel);
            }
        }


        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificationAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0) 
            {
                EnCoursModificationAbsence(true);
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dtpDebut.Value = absence.DateDebut;
                dtpFin.Value = absence.DateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Libelle);            
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            EnCoursModificationAbsence(false);
            grbPersonel.Enabled = false;
        }

        /// <summary>
        /// Demande la suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controlleur.DelAbsence(absence);
                    RemplirListeAbsence(personnel);    
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Valider la demande d'ajout ou de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderAbsence_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            if (dtpDebut.Value.Date < dtpFin.Value.Date)
            {
                Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                Absence absence = new Absence(personnel.IdPersonnel, dtpDebut.Value, dtpFin.Value, motif);
                Absence ancienneAbsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (enCoursDeModifAbsence)
                {
                    controlleur.DelAbsence(ancienneAbsence);
                    if (controlleur.DispoAbsence(absence))
                    {
                        controlleur.AddAbsence(absence);
                        EnCoursModificationAbsence(false);
                    }
                    else
                    {
                        MessageBox.Show("Il existe déjà une absence pour ce personnel à ces dates.", titreFenetreInformation);
                        controlleur.AddAbsence(ancienneAbsence);
                    }
                }
                else
                {
                    if (controlleur.DispoAbsence(absence))
                    {
                        controlleur.AddAbsence(absence);

                    }
                    else
                    {
                        MessageBox.Show("Il existe déjà une absence pour ce personnel à ces dates.", titreFenetreInformation);
                    }
                }
            }
            else
            {
                MessageBox.Show("La date de début ne peut pas être ultérieure à la date de fin.", titreFenetreInformation);
            }
            RemplirListeAbsence(personnel);
            grbModifAbsences.Text = "";
            grbPersonel.Enabled = true;
            grbModifAbsences.Enabled = false;
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'une absence
        /// Vide les catégories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModificationAbsence(false);
                grbModifAbsences.Enabled = false;
                grbAbsences.Enabled = true;
                grbPersonel.Enabled = true;
                grbModifAbsences.Text = "";
            }
        }

        /// <summary>
        /// Modification de l'affichage suivant si modification ou ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModificationAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbAbsences.Enabled = !modif;
            grbPersonel.Enabled = false;
            grbModifAbsences.Enabled = true;
            if (modif)
            {
                grbModifAbsences.Text = "Modification d'une absence";
            }
            else 
            {
                grbModifAbsences.Text = "Ajout d'une absence";
                dtpDebut.Value = DateTime.Now;
                dtpFin.Value = DateTime.Now;
            }
        }

    }
}
