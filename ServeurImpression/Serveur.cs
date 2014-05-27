using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ServeurImpression
{
    class Serveur
    {
        public List<Imprimante> Imprimantes;

        public void AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(Document doc)
        {
            string nomImprimante = ImprimanteQuiPrendLeMoinsDeTemps(doc).Nom;
            Imprimante imp = RechercherImprimanteParLeNom(nomImprimante);
            imp.AjouterDocumentAImprimer(doc);
        }

        public void SupprimerLeDocumentEnAttente(Document doc)
        {
            foreach (Imprimante imp in Imprimantes)
            {
                if(imp.GetDocumentParId(doc.Id) != null )
                {
                    imp.SupprimerDocument(doc.Id);
                    break;
                }
            }
        }

        public Imprimante ImprimanteQuiPrendLeMoinsDeTemps(Document doc) 
        {
            Imprimante Imp = null;
            float tmpMin = 1000000;
            foreach (Imprimante impremante in Imprimantes)
            {
                float tempImprimante = impremante.TempsPrévu(doc);
                if (tempImprimante < tmpMin)
                {
                    tmpMin = tempImprimante;
                    Imp = impremante;
                }
            }
            return Imp;
        }

        public Imprimante RechercherImprimanteParLeNom(string nom)
        {
            foreach (Imprimante imprimante in Imprimantes)
            {
                if (imprimante.Nom == nom)
                {
                    return imprimante;
                }
            }
            return null;
        }

    }
}
