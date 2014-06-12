namespace ServeurImpressionThreads
{
    partial class FormImprimante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarImpression = new System.Windows.Forms.ProgressBar();
            this.listBoxImpressionsImprimante = new System.Windows.Forms.ListBox();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.backgroundWorkerImprimante = new System.ComponentModel.BackgroundWorker();
            this.boutonAnulerImpression = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBarImpression
            // 
            this.progressBarImpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarImpression.Location = new System.Drawing.Point(33, 42);
            this.progressBarImpression.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarImpression.Name = "progressBarImpression";
            this.progressBarImpression.Size = new System.Drawing.Size(275, 19);
            this.progressBarImpression.TabIndex = 0;
            // 
            // listBoxImpressionsImprimante
            // 
            this.listBoxImpressionsImprimante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxImpressionsImprimante.FormattingEnabled = true;
            this.listBoxImpressionsImprimante.Location = new System.Drawing.Point(33, 83);
            this.listBoxImpressionsImprimante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxImpressionsImprimante.Name = "listBoxImpressionsImprimante";
            this.listBoxImpressionsImprimante.Size = new System.Drawing.Size(204, 69);
            this.listBoxImpressionsImprimante.TabIndex = 1;
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar.Location = new System.Drawing.Point(33, 11);
            this.labelProgressBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(129, 20);
            this.labelProgressBar.TabIndex = 2;
            this.labelProgressBar.Text = "Fichier en cours :";
            // 
            // backgroundWorkerImprimante
            // 
            this.backgroundWorkerImprimante.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImprimante_DoWork);
            this.backgroundWorkerImprimante.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerImprimante_ProgressChanged);
            // 
            // boutonAnulerImpression
            // 
            this.boutonAnulerImpression.Location = new System.Drawing.Point(256, 83);
            this.boutonAnulerImpression.Name = "boutonAnulerImpression";
            this.boutonAnulerImpression.Size = new System.Drawing.Size(75, 23);
            this.boutonAnulerImpression.TabIndex = 3;
            this.boutonAnulerImpression.Text = "Annuler";
            this.boutonAnulerImpression.UseVisualStyleBackColor = true;
            this.boutonAnulerImpression.Click += new System.EventHandler(this.boutonAnulerImpression_Click);
            // 
            // FormImprimante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 215);
            this.Controls.Add(this.boutonAnulerImpression);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.listBoxImpressionsImprimante);
            this.Controls.Add(this.progressBarImpression);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormImprimante";
            this.Text = "Imprimante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarImpression;
        private System.Windows.Forms.ListBox listBoxImpressionsImprimante;
        private System.Windows.Forms.Label labelProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerImprimante;
        private System.Windows.Forms.Button boutonAnulerImpression;
    }
}