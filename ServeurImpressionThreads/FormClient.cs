﻿using System;
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
using ServeurImpression;

namespace ServeurImpressionThreads
{
    public partial class FormClient : Form
    {
        ServeurInterface monServeur;

        public FormClient()
        {
            InitializeComponent();
            ServeurInterface monServeur = new ServeurInterface();
        }

        public byte[] ConvertirDocumentEnBytes(String CheminFichier)
        {
            byte[] contenu = File.ReadAllBytes(CheminFichier);
            return contenu;
        }


        private void buttonAjouterFichier_Click(object sender, EventArgs e)
        {
            //Ouvre une fenêtre de recherche et récupère les chemins des fichiers sélectionnés
            OpenFileDialog monOpenFileDialog = new OpenFileDialog();
            monOpenFileDialog.Multiselect = true;
            monOpenFileDialog.RestoreDirectory = true;
            monOpenFileDialog.Title = "Choisissez les fichiers à imprimer";

            monOpenFileDialog.ShowDialog();
            String[] cheminsFichiers = monOpenFileDialog.FileNames;

            //Envoie chaque fichier sélectionné au serveur
            if (cheminsFichiers.Length != 0)
            {
                for (int i = 0; i < cheminsFichiers.Length; i++)
                {
                    byte[] contenuDoc = ConvertirDocumentEnBytes(cheminsFichiers[i]);
                    Document monDoc = new Document(cheminsFichiers[i], contenuDoc);
                    listBoxFichierAImprimer.Items.Add(cheminsFichiers[i]);
                    monServeur.AjouterDocument(monDoc);
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            listBoxFichierAImprimer.Items.Remove(listBoxFichierAImprimer.SelectedItem);
            monServeur.SupprimerDocument(listBoxFichierAImprimer.SelectedItem.ToString());
        }

        

    }
}
