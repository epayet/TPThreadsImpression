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
        //En public juste pour les tests
        public Serveur monServeur;

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

        public List<Imprimante> GetImprimantes()
        {
            return monServeur.Imprimantes;
        }
    }
}
