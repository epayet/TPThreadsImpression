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
            this.SuspendLayout();
            // 
            // listBoxFichierAImprimer
            // 
            this.listBoxFichierAImprimer.FormattingEnabled = true;
            this.listBoxFichierAImprimer.Location = new System.Drawing.Point(34, 65);
            this.listBoxFichierAImprimer.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFichierAImprimer.Name = "listBoxFichierAImprimer";
            this.listBoxFichierAImprimer.Size = new System.Drawing.Size(269, 95);
            this.listBoxFichierAImprimer.TabIndex = 0;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(31, 30);
            this.labelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(317, 20);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Veuillez sélectionner les fichiers à imprimer :";
            // 
            // buttonAjouterFichier
            // 
            this.buttonAjouterFichier.Location = new System.Drawing.Point(316, 65);
            this.buttonAjouterFichier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterFichier.Name = "buttonAjouterFichier";
            this.buttonAjouterFichier.Size = new System.Drawing.Size(70, 29);
            this.buttonAjouterFichier.TabIndex = 2;
            this.buttonAjouterFichier.Text = "Ajouter";
            this.buttonAjouterFichier.UseVisualStyleBackColor = true;
            this.buttonAjouterFichier.Click += new System.EventHandler(this.buttonAjouterFichier_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 192);
            this.Controls.Add(this.buttonAjouterFichier);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.listBoxFichierAImprimer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClient";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFichierAImprimer;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Button buttonAjouterFichier;
    }
}

