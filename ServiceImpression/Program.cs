﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceImpression.Data;

namespace ServiceImpression
{
    class Program
    {
        static void Main(string[] args)
        {
            ImpressionService serveur = new ImpressionService();
            Imprimante imp = new Imprimante("imp1", 0.05f);
            serveur.AjouterImprimante(imp);
            Imprimante imp2 = new Imprimante("imp2", 0.01f);
            serveur.AjouterImprimante(imp2);

            int nbData = 1000000;
            byte[] fakeData = new byte[nbData];
            for (int i = 0; i < nbData; i++)
            {
                fakeData[i] = 1;
            }

            for (int i = 0; i < 5; i++)
            {
                Document doc = new Document("doc" + i, fakeData);
                serveur.AjouterDocument(doc);
            }

            serveur.Lancer();
        }
    }
}