using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ServeurImpressionThreads.WebServiceImpression;

namespace ServeurImpressionThreads
{
    public partial class FormImprimante : Form
    {
        private Imprimante monImprimante;
        private WebServiceImpressionClient webServiceClient;

        public FormImprimante(Imprimante uneImprimante, WebServiceImpressionClient webServiceClient)
        {
            InitializeComponent();
            monImprimante = uneImprimante;
            this.webServiceClient = webServiceClient;
            this.Text = uneImprimante.Nom;
            this.Name = uneImprimante.Nom;
        }

        private void FormImprimante_Load(object sender, EventArgs e)
        {
            listBoxImpressionsImprimante.Items.Clear();
            backgroundWorkerImprimante.RunWorkerAsync();
        }

        private void backgroundWorkerImprimante_DoWork(object sender, DoWorkEventArgs e)
        {
            MAJProgressBar(e);
        }

        private void backgroundWorkerImprimante_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarImpression.Value = e.ProgressPercentage;
        }

        public void MAJListeDocuments()
        {
            listBoxImpressionsImprimante.Items.Clear();
            for (int i = 0; i < monImprimante.DocumentsEnAttente.Count; i++)
            {
                listBoxImpressionsImprimante.Items.Add(monImprimante.DocumentsEnAttente[i].ToString());
            }
        }

        void MAJProgressBar(DoWorkEventArgs e)
        {
            if (backgroundWorkerImprimante.CancellationPending == false)
            {
                //Met à jour la progressbar suivant le fichier en cours d'impression
                int nombrePagesTotalDocument = webServiceClient.GetDocumentNbPages(monImprimante.DocumentsEnAttente[0]);
                double pourcentage = 0;
                for (int i = 0; i < nombrePagesTotalDocument; i++)
                {
                    //MAJ du % de la progressBar
                    float tempsPrevu = webServiceClient.GetTempsPrevuPourImpression(monImprimante, monImprimante.DocumentsEnAttente[0]);
                    pourcentage = tempsPrevu / i * 100;
                    backgroundWorkerImprimante.ReportProgress((int)pourcentage);

                    //Sleep (pendant le temps d'imrpession d'une page)
                    float tempsImpressionUnePageDuDoc = tempsPrevu / nombrePagesTotalDocument * 1000;
                    Thread.Sleep((int)tempsImpressionUnePageDuDoc);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorkerImprimante_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Quand doc imprimé, enlève doc de la liste
            if (e.Cancelled == false)
            {
                if (listBoxImpressionsImprimante.Items.Count != 0)
                {
                    listBoxImpressionsImprimante.Items.Remove(listBoxImpressionsImprimante.Items[0]);
                }
            }
            else
                MessageBox.Show("Opération annulée");
        }

        private void boutonAnulerImpression_Click(object sender, EventArgs e)
        {
            listBoxImpressionsImprimante.Items.Remove(listBoxImpressionsImprimante.SelectedItem);
            //monImprimante.AnnulerImpression(listBoxImpressionsImprimante.SelectedItem);
        }

    }
}
