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
        private Serveur monServeur;

        public SimpleServeur()
        {
            monServeur = new Serveur();
        }

        public void AjouterDocument(Document monDoc)
        {
            monServeur.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(monDoc);
        }

        public void SupprimerDocument(Document monDoc)
        {
            //monServeur.AnnulerImpression(monDoc);
        }
    }
}
