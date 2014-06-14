using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using ServiceImpression.Data;

namespace ServiceImpression
{
    public class ImpressionService
    {
        public List<Imprimante> Imprimantes { get; private set; }
        private List<Imprimante> imprimanteASupprimer = new List<Imprimante>();
        private List<Imprimante> imprimanteAAjouter = new List<Imprimante>();

        public EventWaitHandle ImprimanteesModifiesEvent { get; private set; }

        Dictionary<Imprimante, Task> DicoImprimante = new Dictionary<Imprimante, Task>();
 
        public ImpressionService() 
        {
            Imprimantes = new List<Imprimante>();
            ImprimanteesModifiesEvent = new AutoResetEvent(false);
        }

        public void Lancer()
        {
            Thread thread = new Thread(creerTachesImprimantes);
            thread.Start();
        }

        public Imprimante AjouterDocument(Document doc)
        {
            if(Imprimantes.Count == 0)
                throw new Exception("Le serveur ne contient pas encore d'imprimantes. Document non ajouté");

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
            imprimanteAAjouter.Add(imprimante);
            ImprimanteesModifiesEvent.Set();

        }

        public void SupprimerImprimante(Imprimante imprimante)
        {
           
            lock(Imprimantes)
            {
                imprimanteASupprimer.Add(imprimante);
                ImprimanteesModifiesEvent.Set();
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
            while(true)
            {
                ImprimanteesModifiesEvent.WaitOne();
                foreach (Imprimante newImprimante in imprimanteAAjouter)
                {
                    Imprimantes.Add(newImprimante);
                    Task tache = new Task(newImprimante.Travailler);
                    tache.Start();
                    
                    imprimanteAAjouter.Remove(newImprimante);
                }

                foreach (Imprimante oldImprimante in imprimanteASupprimer)
                {
                    Imprimantes.Remove(oldImprimante);
                    imprimanteASupprimer.Remove(oldImprimante);
                    oldImprimante.ArreterImprimante();
                }
        }
        }
    }
}
