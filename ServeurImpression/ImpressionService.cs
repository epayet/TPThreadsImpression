﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ServeurImpression
{
    public class ImpressionService
    {
        public List<Imprimante> Imprimantes;

        public ImpressionService() 
        {
            Imprimantes = new List<Imprimante>();
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
                } 
                else if(imprimante.GetDocumentParId(doc.Id) != null)
                {
                    imprimante.SupprimerDocument(doc.Id);
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

        //TODO Faire un thread qui orchestre tous les task au lieu d'un thread par task
        public void AjouterImprimante(Imprimante imprimante)
        {
            Imprimantes.Add(imprimante);
            Thread thread = new Thread(() => creerTacheImprimante(imprimante));
            thread.Start();
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

        private void creerTacheImprimante(Imprimante imprimante)
        {
            Task<int> taskImprimante = new Task<int>(imprimante.Travailler);
            taskImprimante.Start();
            int waitFor = taskImprimante.Result;
        }
    }
}