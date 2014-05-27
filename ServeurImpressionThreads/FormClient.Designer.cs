namespace ServeurImpressionThreads
{
    partial class FormClient
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
            this.listBoxFichierAImprimer = new System.Windows.Forms.ListBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.buttonAjouterFichier = new System.Windows.Forms.Button();
            this.listBoxEnCours = new System.Windows.Forms.ListBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonInfos = new System.Windows.Forms.Button();
            this.labelListeImpressionEnCours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFichierAImprimer
            // 
            this.listBoxFichierAImprimer.FormattingEnabled = true;
            this.listBoxFichierAImprimer.ItemHeight = 16;
            this.listBoxFichierAImprimer.Location = new System.Drawing.Point(46, 80);
            this.listBoxFichierAImprimer.Name = "listBoxFichierAImprimer";
            this.listBoxFichierAImprimer.Size = new System.Drawing.Size(357, 116);
            this.listBoxFichierAImprimer.TabIndex = 0;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(41, 37);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(393, 25);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Veuillez sélectionner les fichiers à imprimer :";
            // 
            // buttonAjouterFichier
            // 
            this.buttonAjouterFichier.Location = new System.Drawing.Point(422, 80);
            this.buttonAjouterFichier.Name = "buttonAjouterFichier";
            this.buttonAjouterFichier.Size = new System.Drawing.Size(94, 36);
            this.buttonAjouterFichier.TabIndex = 2;
            this.buttonAjouterFichier.Text = "Ajouter";
            this.buttonAjouterFichier.UseVisualStyleBackColor = true;
            this.buttonAjouterFichier.Click += new System.EventHandler(this.buttonAjouterFichier_Click);
            // 
            // listBoxEnCours
            // 
            this.listBoxEnCours.FormattingEnabled = true;
            this.listBoxEnCours.ItemHeight = 16;
            this.listBoxEnCours.Location = new System.Drawing.Point(46, 261);
            this.listBoxEnCours.Name = "listBoxEnCours";
            this.listBoxEnCours.Size = new System.Drawing.Size(211, 100);
            this.listBoxEnCours.TabIndex = 3;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(422, 123);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(94, 36);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonInfos
            // 
            this.buttonInfos.Location = new System.Drawing.Point(422, 165);
            this.buttonInfos.Name = "buttonInfos";
            this.buttonInfos.Size = new System.Drawing.Size(94, 34);
            this.buttonInfos.TabIndex = 5;
            this.buttonInfos.Text = "Infos";
            this.buttonInfos.UseVisualStyleBackColor = true;
            this.buttonInfos.Click += new System.EventHandler(this.buttonInfos_Click);
            // 
            // labelListeImpressionEnCours
            // 
            this.labelListeImpressionEnCours.AutoSize = true;
            this.labelListeImpressionEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeImpressionEnCours.Location = new System.Drawing.Point(43, 220);
            this.labelListeImpressionEnCours.Name = "labelListeImpressionEnCours";
            this.labelListeImpressionEnCours.Size = new System.Drawing.Size(290, 25);
            this.labelListeImpressionEnCours.TabIndex = 6;
            this.labelListeImpressionEnCours.Text = "Liste des impressions en cours :";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 418);
            this.Controls.Add(this.labelListeImpressionEnCours);
            this.Controls.Add(this.buttonInfos);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.listBoxEnCours);
            this.Controls.Add(this.buttonAjouterFichier);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.listBoxFichierAImprimer);
            this.Name = "FormClient";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFichierAImprimer;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Button buttonAjouterFichier;
        private System.Windows.Forms.ListBox listBoxEnCours;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonInfos;
        private System.Windows.Forms.Label labelListeImpressionEnCours;
    }
}

