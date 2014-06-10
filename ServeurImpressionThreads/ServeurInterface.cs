using ServeurImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpressionThreads
{
    public class ServeurInterface
    {
        Serveur monServeur;

        public ServeurInterface()
        {
            monServeur = new Serveur();
        }

        public void AjouterDocument(Document monDoc)
        {
            try
            {
                monServeur.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(monDoc);
            }
            catch (NullReferenceException)
            {
                Console.Write("baaah");
            }
        }

        public void SupprimerDocument(Document monDoc)
        {
            //monServeur.AnnulerImpression(monDoc);
        }
    }
}
