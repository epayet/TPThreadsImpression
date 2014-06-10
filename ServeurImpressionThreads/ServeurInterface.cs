using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpressionThreads
{
    public class ServeurInterface
    {
        public void AjouterDocument(Document monDoc)
        {
            //call ServeurImpression.ajouterDoc
        }

        public void SupprimerDocument(String cheminFichier)
        {
            //call ServeurImpression.supprimerDoc
        }
    }
}
