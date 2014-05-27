using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeurImpressionThreads
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void buttonAjouterFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog monOpenFileDialog = new OpenFileDialog();
            monOpenFileDialog.Multiselect = true;
            monOpenFileDialog.RestoreDirectory = true;
            monOpenFileDialog.Title = "Choisissez les fichiers à imprimer";

            monOpenFileDialog.ShowDialog();
            String[] cheminsFichiers = monOpenFileDialog.FileNames;

            if (cheminsFichiers.Length != 0)
            {
                for (int i = 0; i < cheminsFichiers.Length; i++)
                {
                    listBoxFichierAImprimer.Items.Add(cheminsFichiers[i]);
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            listBoxFichierAImprimer.Items.Remove(listBoxFichierAImprimer.SelectedItem);
        }

        private void buttonInfos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBoxFichierAImprimer.SelectedItem.ToString());
        }

    }
}
