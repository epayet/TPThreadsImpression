using ServeurImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeurImpressionThreads
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormClient());

            //Lancer serveurs
            ServeurInterface serveur = new ServeurInterface();
            /*
             * Serveur serv = new Serveur();
            Imprimante Imp = new Imprimante("imp1", 2);
            serv.AjouterImprimante(Imp);
            Document doc = new Document("doc1", new byte[10000]);
            serv.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(doc);
            Document doc2 = new Document("doc2", new byte[10000]);
            serv.AjouterLeDocumentALImprimanteQuiPrendLeMoinsDeTemps(doc2);
            FormClient monFormClient = new FormClient();
            monFormClient.Show();*/
        }
    }
}
