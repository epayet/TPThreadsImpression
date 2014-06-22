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
        private ImprimanteMessage imprimante;
        private WebServiceImpressionClient webServiceClient;

        public FormImprimante(ImprimanteMessage imprimante, WebServiceImpressionClient webServiceClient)
        {
            InitializeComponent();
            this.imprimante = imprimante;
            this.webServiceClient = webServiceClient;
            this.Text = imprimante.Nom;
            this.Name = imprimante.Nom;
        }

        public void MAJImprimante()
        {
            ImprimanteMessage impMessage = webServiceClient.GetImprimante(this.Name);
            if (impMessage.DocumentEnCours != null)
            {
                labelNomFichierEnCours.Invoke(new Action(() => labelNomFichierEnCours.Text = impMessage.DocumentEnCours.Nom));

                //labelNomFichierEnCours.Text = impMessage.DocumentEnCours.Nom;
                progressBarImpression.Invoke(new Action(() => progressBarImpression.Maximum = webServiceClient.GetDocumentNbPages(impMessage.DocumentEnCours)));

                //progressBarImpression.Maximum = webServiceClient.GetDocumentNbPages(impMessage.DocumentEnCours);
            }
            listBoxDocumentsEnAttente.Invoke(new Action(() => listBoxDocumentsEnAttente.Items.Clear()));

            //listBoxDocumentsEnAttente.Items.Clear();
            foreach (DocumentMessage documentEnAttente in impMessage.DocumentsEnAttente)
            {
                listBoxDocumentsEnAttente.Invoke(new Action(() =>  listBoxDocumentsEnAttente.Items.Add(documentEnAttente.Nom)));

                //listBoxDocumentsEnAttente.Items.Add(documentEnAttente.Nom);
            }
            isReady = true;
            imprimante = impMessage;
        }

        private void boutonAnulerImpression_Click(object sender, EventArgs e)
        {
            listBoxDocumentsEnAttente.Items.Remove(listBoxDocumentsEnAttente.SelectedItem);
            DocumentMessage documentASupprimer = getDocument(listBoxDocumentsEnAttente.SelectedItem.ToString());
            webServiceClient.SupprimerDocument(documentASupprimer);
        }

        private DocumentMessage getDocument(string nom)
        {
            foreach (DocumentMessage documentEnAttente in imprimante.DocumentsEnAttente)
            {
                if (documentEnAttente.Nom == nom)
                    return documentEnAttente;
            }
            return null;
        }


        public void DebutImpression()
        {
            MAJImprimante();
            pagesImprimees = 0;
        }

        public void FinImpression()
        {
            isReady = false;
        }

        public void ImpressionPage()
        {
            pagesImprimees++;
            if(isReady)
                progressBarImpression.Invoke(new Action(() => progressBarImpression.Value = pagesImprimees));
            
        }

        public int pagesImprimees { get; set; }

        public bool isReady { get; set; }
    }
}
