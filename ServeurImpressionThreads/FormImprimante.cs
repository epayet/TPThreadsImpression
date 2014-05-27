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
    public partial class FormImprimante : Form
    {
        String nomImprimante = "";
        int vitesse = 0;

        public FormImprimante()
        {
            InitializeComponent();
        }

        public FormImprimante(String p_nomImprimante, int p_vitesse)
        {
            InitializeComponent();
            this.vitesse = p_vitesse;
            this.nomImprimante = p_nomImprimante;
            this.Text = "Imprimante " + this.nomImprimante;
        }

        void MAJProgressBar(int nbPages)
        {
            if (backgroundWorkerImprimante.CancellationPending == false)
            {
                for (int i = 0; i < nbPages; i++)
                {
                    double pourcentage = 0;
                    pourcentage = i / vitesse * 100;
                    backgroundWorkerImprimante.ReportProgress((int)pourcentage);
                }
            }
        }
    }
}
