namespace MediaTek86
{
    partial class MediaTek
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnModificationPerso = new System.Windows.Forms.Button();
            this.BtnSuppPerso = new System.Windows.Forms.Button();
            this.btnAjoutPerso = new System.Windows.Forms.Button();
            this.btnSuppAbsence = new System.Windows.Forms.Button();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnModificationAbsence = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.txtbPrenom = new System.Windows.Forms.TextBox();
            this.txtbTel = new System.Windows.Forms.TextBox();
            this.txtbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.btnValiderPerso = new System.Windows.Forms.Button();
            this.grbModifPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPerso = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.grbAbsences = new System.Windows.Forms.GroupBox();
            this.grbModifAbsences = new System.Windows.Forms.GroupBox();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.btnValiderAbsence = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.grbPersonel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.grbModifPersonnel.SuspendLayout();
            this.grbAbsences.SuspendLayout();
            this.grbModifAbsences.SuspendLayout();
            this.grbPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(688, 202);
            this.dgvPersonnel.TabIndex = 0;
            this.dgvPersonnel.SelectionChanged += new System.EventHandler(this.dgvPersonnel_SelectionChanged);
            // 
            // btnModificationPerso
            // 
            this.btnModificationPerso.Location = new System.Drawing.Point(735, 53);
            this.btnModificationPerso.Name = "btnModificationPerso";
            this.btnModificationPerso.Size = new System.Drawing.Size(75, 23);
            this.btnModificationPerso.TabIndex = 2;
            this.btnModificationPerso.Text = "Modification";
            this.btnModificationPerso.UseVisualStyleBackColor = true;
            this.btnModificationPerso.Click += new System.EventHandler(this.btnModificationPerso_Click);
            // 
            // BtnSuppPerso
            // 
            this.BtnSuppPerso.Location = new System.Drawing.Point(735, 171);
            this.BtnSuppPerso.Name = "BtnSuppPerso";
            this.BtnSuppPerso.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppPerso.TabIndex = 3;
            this.BtnSuppPerso.Text = "Supprimer";
            this.BtnSuppPerso.UseVisualStyleBackColor = true;
            this.BtnSuppPerso.Click += new System.EventHandler(this.BtnSuppPerso_Click);
            // 
            // btnAjoutPerso
            // 
            this.btnAjoutPerso.Location = new System.Drawing.Point(735, 111);
            this.btnAjoutPerso.Name = "btnAjoutPerso";
            this.btnAjoutPerso.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutPerso.TabIndex = 3;
            this.btnAjoutPerso.Text = "Ajout";
            this.btnAjoutPerso.UseVisualStyleBackColor = true;
            this.btnAjoutPerso.Click += new System.EventHandler(this.btnAjoutPerso_Click);
            // 
            // btnSuppAbsence
            // 
            this.btnSuppAbsence.Location = new System.Drawing.Point(731, 168);
            this.btnSuppAbsence.Name = "btnSuppAbsence";
            this.btnSuppAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnSuppAbsence.TabIndex = 7;
            this.btnSuppAbsence.Text = "Supprimer";
            this.btnSuppAbsence.UseVisualStyleBackColor = true;
            this.btnSuppAbsence.Click += new System.EventHandler(this.btnSuppAbsence_Click);
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(731, 110);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutAbsence.TabIndex = 6;
            this.btnAjoutAbsence.Text = "Ajout";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAjoutAbsence.Click += new System.EventHandler(this.btnAjoutAbsence_Click);
            // 
            // btnModificationAbsence
            // 
            this.btnModificationAbsence.Location = new System.Drawing.Point(731, 52);
            this.btnModificationAbsence.Name = "btnModificationAbsence";
            this.btnModificationAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnModificationAbsence.TabIndex = 5;
            this.btnModificationAbsence.Text = "Modification";
            this.btnModificationAbsence.UseVisualStyleBackColor = true;
            this.btnModificationAbsence.Click += new System.EventHandler(this.btnModificationAbsence_Click);
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(9, 19);
            this.dgvAbsence.MultiSelect = false;
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsence.Size = new System.Drawing.Size(688, 202);
            this.dgvAbsence.TabIndex = 8;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 57);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 10;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(61, 22);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(156, 20);
            this.txtbNom.TabIndex = 11;
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Location = new System.Drawing.Point(61, 54);
            this.txtbPrenom.Name = "txtbPrenom";
            this.txtbPrenom.Size = new System.Drawing.Size(156, 20);
            this.txtbPrenom.TabIndex = 12;
            // 
            // txtbTel
            // 
            this.txtbTel.Location = new System.Drawing.Point(316, 22);
            this.txtbTel.Name = "txtbTel";
            this.txtbTel.Size = new System.Drawing.Size(156, 20);
            this.txtbTel.TabIndex = 13;
            // 
            // txtbMail
            // 
            this.txtbMail.Location = new System.Drawing.Point(316, 57);
            this.txtbMail.Name = "txtbMail";
            this.txtbMail.Size = new System.Drawing.Size(156, 20);
            this.txtbMail.TabIndex = 16;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(262, 60);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(262, 25);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "Tel :";
            // 
            // btnValiderPerso
            // 
            this.btnValiderPerso.Location = new System.Drawing.Point(731, 22);
            this.btnValiderPerso.Name = "btnValiderPerso";
            this.btnValiderPerso.Size = new System.Drawing.Size(75, 23);
            this.btnValiderPerso.TabIndex = 17;
            this.btnValiderPerso.Text = "Valider";
            this.btnValiderPerso.UseVisualStyleBackColor = true;
            this.btnValiderPerso.Click += new System.EventHandler(this.btnValiderPerso_Click);
            // 
            // grbModifPersonnel
            // 
            this.grbModifPersonnel.Controls.Add(this.btnAnnulerPerso);
            this.grbModifPersonnel.Controls.Add(this.btnValiderPerso);
            this.grbModifPersonnel.Controls.Add(this.cboService);
            this.grbModifPersonnel.Controls.Add(this.lblService);
            this.grbModifPersonnel.Controls.Add(this.txtbMail);
            this.grbModifPersonnel.Controls.Add(this.lblNom);
            this.grbModifPersonnel.Controls.Add(this.lblMail);
            this.grbModifPersonnel.Controls.Add(this.lblPrenom);
            this.grbModifPersonnel.Controls.Add(this.lblTel);
            this.grbModifPersonnel.Controls.Add(this.txtbPrenom);
            this.grbModifPersonnel.Controls.Add(this.txtbTel);
            this.grbModifPersonnel.Controls.Add(this.txtbNom);
            this.grbModifPersonnel.Enabled = false;
            this.grbModifPersonnel.Location = new System.Drawing.Point(16, 246);
            this.grbModifPersonnel.Name = "grbModifPersonnel";
            this.grbModifPersonnel.Size = new System.Drawing.Size(825, 100);
            this.grbModifPersonnel.TabIndex = 18;
            this.grbModifPersonnel.TabStop = false;
            this.grbModifPersonnel.Text = "Modification / Ajout de personnel";
            // 
            // btnAnnulerPerso
            // 
            this.btnAnnulerPerso.Location = new System.Drawing.Point(731, 57);
            this.btnAnnulerPerso.Name = "btnAnnulerPerso";
            this.btnAnnulerPerso.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerPerso.TabIndex = 18;
            this.btnAnnulerPerso.Text = "Annuler";
            this.btnAnnulerPerso.UseVisualStyleBackColor = true;
            this.btnAnnulerPerso.Click += new System.EventHandler(this.btnAnnulerPerso_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(558, 22);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(121, 21);
            this.cboService.TabIndex = 7;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(502, 25);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 6;
            this.lblService.Text = "Service :";
            // 
            // grbAbsences
            // 
            this.grbAbsences.Controls.Add(this.dgvAbsence);
            this.grbAbsences.Controls.Add(this.btnSuppAbsence);
            this.grbAbsences.Controls.Add(this.btnModificationAbsence);
            this.grbAbsences.Controls.Add(this.btnAjoutAbsence);
            this.grbAbsences.Location = new System.Drawing.Point(16, 353);
            this.grbAbsences.Name = "grbAbsences";
            this.grbAbsences.Size = new System.Drawing.Size(825, 228);
            this.grbAbsences.TabIndex = 19;
            this.grbAbsences.TabStop = false;
            this.grbAbsences.Text = "Gestion des absences";
            // 
            // grbModifAbsences
            // 
            this.grbModifAbsences.Controls.Add(this.btnAnnulerAbsence);
            this.grbModifAbsences.Controls.Add(this.btnValiderAbsence);
            this.grbModifAbsences.Controls.Add(this.cboMotif);
            this.grbModifAbsences.Controls.Add(this.lblMotif);
            this.grbModifAbsences.Controls.Add(this.lblDateFin);
            this.grbModifAbsences.Controls.Add(this.lblDateDebut);
            this.grbModifAbsences.Controls.Add(this.dtpFin);
            this.grbModifAbsences.Controls.Add(this.dtpDebut);
            this.grbModifAbsences.Enabled = false;
            this.grbModifAbsences.Location = new System.Drawing.Point(12, 587);
            this.grbModifAbsences.Name = "grbModifAbsences";
            this.grbModifAbsences.Size = new System.Drawing.Size(825, 100);
            this.grbModifAbsences.TabIndex = 20;
            this.grbModifAbsences.TabStop = false;
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(735, 62);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerAbsence.TabIndex = 19;
            this.btnAnnulerAbsence.Text = "Annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulerAbsence.Click += new System.EventHandler(this.btnAnnulerAbsence_Click);
            // 
            // btnValiderAbsence
            // 
            this.btnValiderAbsence.Location = new System.Drawing.Point(735, 27);
            this.btnValiderAbsence.Name = "btnValiderAbsence";
            this.btnValiderAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnValiderAbsence.TabIndex = 21;
            this.btnValiderAbsence.Text = "Valider";
            this.btnValiderAbsence.UseVisualStyleBackColor = true;
            this.btnValiderAbsence.Click += new System.EventHandler(this.btnValiderAbsence_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(399, 32);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 21);
            this.cboMotif.TabIndex = 5;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(343, 35);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "Motif :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(6, 65);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(65, 13);
            this.lblDateFin.TabIndex = 3;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(6, 32);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(81, 13);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // dtpFin
            // 
            this.dtpFin.Checked = false;
            this.dtpFin.Location = new System.Drawing.Point(101, 65);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 1;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Checked = false;
            this.dtpDebut.CustomFormat = "";
            this.dtpDebut.Location = new System.Drawing.Point(101, 32);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 1;
            // 
            // grbPersonel
            // 
            this.grbPersonel.Controls.Add(this.dgvPersonnel);
            this.grbPersonel.Controls.Add(this.btnAjoutPerso);
            this.grbPersonel.Controls.Add(this.btnModificationPerso);
            this.grbPersonel.Controls.Add(this.BtnSuppPerso);
            this.grbPersonel.Location = new System.Drawing.Point(12, 13);
            this.grbPersonel.Name = "grbPersonel";
            this.grbPersonel.Size = new System.Drawing.Size(825, 227);
            this.grbPersonel.TabIndex = 21;
            this.grbPersonel.TabStop = false;
            this.grbPersonel.Text = "Gestion du personnel";
            // 
            // MediaTek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 713);
            this.Controls.Add(this.grbModifAbsences);
            this.Controls.Add(this.grbModifPersonnel);
            this.Controls.Add(this.grbAbsences);
            this.Controls.Add(this.grbPersonel);
            this.Name = "MediaTek";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.grbModifPersonnel.ResumeLayout(false);
            this.grbModifPersonnel.PerformLayout();
            this.grbAbsences.ResumeLayout(false);
            this.grbModifAbsences.ResumeLayout(false);
            this.grbModifAbsences.PerformLayout();
            this.grbPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnModificationPerso;
        private System.Windows.Forms.Button BtnSuppPerso;
        private System.Windows.Forms.Button btnAjoutPerso;
        private System.Windows.Forms.Button btnSuppAbsence;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnModificationAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.TextBox txtbPrenom;
        private System.Windows.Forms.TextBox txtbTel;
        private System.Windows.Forms.TextBox txtbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Button btnValiderPerso;
        private System.Windows.Forms.GroupBox grbModifPersonnel;
        private System.Windows.Forms.GroupBox grbAbsences;
        private System.Windows.Forms.GroupBox grbModifAbsences;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnValiderAbsence;
        private System.Windows.Forms.GroupBox grbPersonel;
        private System.Windows.Forms.Button btnAnnulerPerso;
        private System.Windows.Forms.Button btnAnnulerAbsence;
    }
}

