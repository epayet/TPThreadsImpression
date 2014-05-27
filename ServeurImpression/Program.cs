﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeurImpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Serveur serv = new Serveur();
            Imprimante Imp = new Imprimante("imp1", 2);
            serv.AjouterImprimante(Imp);
            Document doc = new Document("doc1", new byte[10000]);
            serv.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(doc);
            Document doc2 = new Document("doc2", new byte[10000]);
            serv.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(doc2);
        }
    }
}
