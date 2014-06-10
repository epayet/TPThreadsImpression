using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServeurImpression;

namespace ServeurImpressionThreads
{
    public partial class FormImprimante : Form
    {
        Imprimante monImprimante;

        public FormImprimante(Imprimante uneImprimante)
        {
            InitializeComponent();
            monImprimante = uneImprimante;
        }

        private void FormImprimante_Load(object sender, EventArgs e)
        {
            backgroundWorkerImprimante.RunWorkerAsync();
        }

        private void backgroundWorkerImprimante_DoWork(object sender, DoWorkEventArgs e)
        {
            MAJProgressBar();
        }

        private void backgroundWorkerImprimante_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarImpression.Value = e.ProgressPercentage;
        }

        void MAJListeDocuments()
        {
            for (int i = 0; i < monImprimante.DocumentsEnAttente.Count; i++)
            {
                listBoxImpressionsImprimante.Items.Add(monImprimante.DocumentsEnAttente[i].ToString());
            }
        }

        void MAJProgressBar()
        {
            if (backgroundWorkerImprimante.CancellationPending == false)
            {
                //Met à jour la progressbar suivant le fichier en cours d'impression
                for (int i = 0; i < monImprimante.TempsPrévu(monImprimante.DocumentsEnAttente[0]); i++)
                {
                    double pourcentage = 0;
                    pourcentage = i / vitesse * 100;
                    backgroundWorkerImprimante.ReportProgress((int)pourcentage);
                }
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
                else
                {

                }
            }
            else
                MessageBox.Show("Opération annulée");
        }

    }
}
