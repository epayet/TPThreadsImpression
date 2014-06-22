using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServeurImpressionThreads;
using System.IO;
using ServeurImpressionThreads.WebServiceImpression;

namespace ServeurImpressionThreads
{
    public partial class FormClient : Form
    {
        private Dictionary<string, FormImprimante> listeFormsImprimantes;
        private WebServiceImpressionClient webServiceClient;

        public FormClient(WebServiceImpressionClient webServiceClient, Dictionary<string, FormImprimante> listeFormsImp)
        {
            InitializeComponent();
            this.webServiceClient = webServiceClient;
            listeFormsImprimantes = listeFormsImp;
        }

        private void buttonAjouterFichier_Click(object sender, EventArgs e)
        {
            List<String> cheminsFichiers = demanderFichiers();

            foreach (string cheminFichier in cheminsFichiers)
            {
                string nomFichier = cheminFichier.Split('\\').Last();
                byte[] contenu = File.ReadAllBytes(cheminFichier);
                DocumentMessage doc = creerDocument(nomFichier, contenu);

                listBoxFichierAImprimer.Items.Add(nomFichier);
                ImprimanteMessage imp = webServiceClient.AjouterDocument(doc);
                
                FormImprimante formImprimante;
                listeFormsImprimantes.TryGetValue(imp.Nom, out formImprimante);
                //formImprimante.MAJImprimante();
            }
        }

        private DocumentMessage creerDocument(string cheminFichier, byte[] contenu)
        {
            DocumentMessage doc = new DocumentMessage
            {
                Nom = cheminFichier,
                Contenu = contenu
            };
            return doc;
        }

        private List<string> demanderFichiers()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Choisissez les fichiers à imprimer";

            openFileDialog.ShowDialog();
            return new List<string> (openFileDialog.FileNames);
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            listBoxFichierAImprimer.Items.Remove(listBoxFichierAImprimer.SelectedItem);
            //monServeur.SupprimerDocument(listBoxFichierAImprimer.SelectedItem.ToString());
        }
    }
}
