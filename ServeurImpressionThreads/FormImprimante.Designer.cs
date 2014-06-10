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
            this.SuspendLayout();
            // 
            // progressBarImpression
            // 
            this.progressBarImpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarImpression.Location = new System.Drawing.Point(44, 52);
            this.progressBarImpression.Name = "progressBarImpression";
            this.progressBarImpression.Size = new System.Drawing.Size(272, 23);
            this.progressBarImpression.TabIndex = 0;
            // 
            // listBoxImpressionsImprimante
            // 
            this.listBoxImpressionsImprimante.FormattingEnabled = true;
            this.listBoxImpressionsImprimante.ItemHeight = 16;
            this.listBoxImpressionsImprimante.Location = new System.Drawing.Point(44, 102);
            this.listBoxImpressionsImprimante.Name = "listBoxImpressionsImprimante";
            this.listBoxImpressionsImprimante.Size = new System.Drawing.Size(272, 84);
            this.listBoxImpressionsImprimante.TabIndex = 1;
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar.Location = new System.Drawing.Point(44, 13);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(161, 25);
            this.labelProgressBar.TabIndex = 2;
            this.labelProgressBar.Text = "Fichier en cours :";
            // 
            // backgroundWorkerImprimante
            // 
            this.backgroundWorkerImprimante.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImprimante_DoWork);
            this.backgroundWorkerImprimante.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerImprimante_ProgressChanged);
            // 
            // FormImprimante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 201);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.listBoxImpressionsImprimante);
            this.Controls.Add(this.progressBarImpression);
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
    }
}