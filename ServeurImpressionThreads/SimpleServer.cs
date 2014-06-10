using ServeurImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpressionThreads
{
    public class SimpleServeur : ServeurCommunication
    {
        private ImpressionService monServeur;

        public SimpleServeur()
        {
            monServeur = new ImpressionService();
        }

        public void AjouterDocument(Document monDoc)
        {
            monServeur.AjouterDocument(monDoc);
        }

        public void SupprimerDocument(Document monDoc)
        {
            //monServeur.AnnulerImpression(monDoc);
        }
    }
}
