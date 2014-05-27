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

        public Serveur() 
        {
            Imprimantes = new List<Imprimante>();
        }

        public void AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(Document doc)
        {
            string nomImprimante = imprimanteQuiPrendLeMoinsDeTemps(doc).Nom;
            Imprimante imp = RechercherImprimanteParLeNom(nomImprimante);
            imp.AjouterDocumentAImprimer(doc);
        }

        public void SupprimerLeDocumentEnAttente(Document doc)
        {
            foreach (Imprimante imp in Imprimantes)
            {
                if(imp.GetDocumentParId(doc.Id) != null)
                {
                    imp.SupprimerDocument(doc.Id);
                    break;
                }
            }
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

        public void AjouterImprimante(Imprimante imprimante)
        {
            Imprimantes.Add(imprimante);
            ImprimanteRunner imprimanteRunner = new ImprimanteRunner
            {
                Imprimante = imprimante
            };
            Task taskImprimante = new Task(imprimanteRunner.Run);
        }

        private Imprimante imprimanteQuiPrendLeMoinsDeTemps(Document doc)
        {
            Imprimante Imp = Imprimantes.First();
            float tmpMin = Imprimantes.First().TempsPrévu(doc);
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

    }
}
