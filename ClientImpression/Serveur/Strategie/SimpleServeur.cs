using ServiceImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceImpression.Data;

namespace ServeurImpressionThreads.Serveur.Strategie
{
    public class SimpleServeur : IServeur
    {
        public ImpressionService monServeur;

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

        public List<Imprimante> GetImprimantes()
        {
            return monServeur.Imprimantes;
        }

        
    }
}
