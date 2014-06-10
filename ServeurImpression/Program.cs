using System;
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
            Imprimante Imp = new Imprimante("imp1", 0.05f);
            serv.AjouterImprimante(Imp);

            int nbData = 1000000;
            byte[] fakeData = new byte[nbData];
            for (int i = 0; i < nbData; i++)
            {
                fakeData[i] = 1;
            }
            Document doc = new Document("doc1", fakeData);
            serv.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(doc);
            Document doc2 = new Document("doc2", fakeData);
            serv.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(doc2);
        }
    }
}
