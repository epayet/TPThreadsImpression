using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using ServiceImpression.Data;

namespace ServeurImpression
{
    public class ImpressionService
    {
        public List<Imprimante> Imprimantes { get; private set; }

        public ImpressionService() 
        {
            Imprimantes = new List<Imprimante>();
        }

        public void Lancer()
        {
            Thread thread = new Thread(creerTachesImprimantes);
            thread.Start();
        }

        public Imprimante AjouterDocument(Document doc)
        {
            Imprimante imprimante = imprimanteQuiPrendLeMoinsDeTemps(doc);
            imprimante.AjouterDocument(doc);
            return imprimante;
        }

        public void SupprimerDocument(Document doc)
        {
            foreach (Imprimante imprimante in Imprimantes)
            {
                if (imprimante.EstEnCoursDImpression(doc.Id))
                {
                    imprimante.AnnulerImpression();
                    break;
                } 
                else if(imprimante.GetDocumentParId(doc.Id) != null)
                {
                    imprimante.SupprimerDocumentEnAttente(doc.Id);
                    break;
                }
            }
        }

        public Imprimante RechercherImprimante(string nom)
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
            lock (Imprimantes)
            {
                Imprimantes.Add(imprimante);
            }
        }

        public void SupprimerImprimante(Imprimante imprimante)
        {
            lock(Imprimantes)
            {
                Imprimantes.Remove(imprimante);
            }
        }

        private Imprimante imprimanteQuiPrendLeMoinsDeTemps(Document doc)
        {
            Imprimante imprimanteLaPlusRapide = Imprimantes.First();
            float tmpMin = Imprimantes.First().TempsPrévu(doc);
            foreach (Imprimante imprimante in Imprimantes)
            {
                float tmpImprimante = imprimante.TempsPrévu(doc);
                if (tmpImprimante < tmpMin)
                {
                    tmpMin = tmpImprimante;
                    imprimanteLaPlusRapide = imprimante;
                }
            }
            return imprimanteLaPlusRapide;
        }

        private void creerTachesImprimantes()
        {
            foreach (Imprimante imprimante in Imprimantes)
            {
                Task tache = new Task(imprimante.Travailler);
                tache.Start();
            }

            //Eviter le while(true) qui consomme du CPU
            //On pourrait aussi faire un système de portique et faire un WaitOne pour quitter proprement
            Thread.Sleep(Timeout.Infinite);
            while(true)
            {

            }
        }
    }
}
