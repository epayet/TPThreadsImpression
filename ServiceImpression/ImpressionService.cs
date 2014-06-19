using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using ServiceImpression.Data;
using System.Collections.Concurrent;

namespace ServiceImpression
{
    public class ImpressionService
    {
        public ConcurrentDictionary<string, Imprimante> Imprimantes { get; private set; }

        public ImpressionService()
        {
            Imprimantes = new ConcurrentDictionary<string, Imprimante>();
        }

        public Imprimante AjouterDocument(Document doc)
        {
            if(Imprimantes.Count == 0)
                throw new Exception("Le serveur ne contient pas encore d'imprimantes. Document non ajouté");

            if (string.IsNullOrEmpty(doc.Id))
                doc.GenererId();

            Imprimante imprimante = imprimanteQuiPrendLeMoinsDeTemps(doc);
            imprimante.AjouterDocument(doc);
            return imprimante;
        }

        public void SupprimerDocument(string id)
        {
            foreach (KeyValuePair<string, Imprimante> imprimanteCleValeur in Imprimantes)
            {
                Imprimante imprimante = imprimanteCleValeur.Value;
                if (imprimante.EstEnCoursDImpression(id))
                {
                    imprimante.AnnulerImpression();
                    break;
                } 
                else if(imprimante.GetDocument(id) != null)
                {
                    imprimante.SupprimerDocumentEnAttente(id);
                    break;
                }
            }
        }

        public Imprimante GetImprimante(string nom)
        {
            Imprimante imprimante;
            Imprimantes.TryGetValue(nom, out imprimante);
            return imprimante;
        }

        public void AjouterImprimante(Imprimante nouvelleImprimante)
        {
            Imprimantes.TryAdd(nouvelleImprimante.Nom, nouvelleImprimante);
            Task tacheImprimante = new Task(nouvelleImprimante.Travailler);
            tacheImprimante.Start();
        }

        public void SupprimerImprimante(string nom)
        {
            Imprimante imprimante = GetImprimante(nom);
            imprimante.Arreter();
            Imprimantes.TryRemove(nom, out imprimante);
        }

        public List<Imprimante> GetImprimantes()
        {
            List<Imprimante> imprimantes = new List<Imprimante>();
            foreach (KeyValuePair<string, Imprimante> imprimanteCleValeur in Imprimantes)
            {
                imprimantes.Add(imprimanteCleValeur.Value);
            }
            return imprimantes;
        }

        private Imprimante imprimanteQuiPrendLeMoinsDeTemps(Document doc)
        {
            Imprimante premiereImprimante = Imprimantes.First().Value;
            Imprimante imprimanteLaPlusRapide = premiereImprimante;
            float tmpMin = premiereImprimante.TempsPrévu(doc);
            foreach (KeyValuePair<string, Imprimante> imprimanteCleValeur in Imprimantes)
            {
                Imprimante imprimante = imprimanteCleValeur.Value;
                float tmpImprimante = imprimante.TempsPrévu(doc);
                if (tmpImprimante < tmpMin)
                {
                    tmpMin = tmpImprimante;
                    imprimanteLaPlusRapide = imprimante;
                }
            }
            return imprimanteLaPlusRapide;
        }
    }
}
