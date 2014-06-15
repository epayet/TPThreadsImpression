using ServeurImpressionThreads.WebServiceImpression;
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

            WebServiceImpressionClient webServiceClient = CreerWebServiceClient();

            List<FormImprimante> formImprimantes = CreerFenetresImprimantes(webServiceClient);
            Application.Run(new FormClient(webServiceClient, formImprimantes));
        }

        private static List<FormImprimante> CreerFenetresImprimantes(WebServiceImpressionClient webServiceClient)
        {
            List<FormImprimante> listeForms = new List<FormImprimante>();
            foreach (Imprimante uneImp in webServiceClient.GetImprimantes())
            {
                FormImprimante maFormImp = new FormImprimante(uneImp, webServiceClient);
                maFormImp.Show();
                listeForms.Add(maFormImp);
            }
            return listeForms;
        }

        private static WebServiceImpressionClient CreerWebServiceClient()
        {
            WebServiceImpressionClient client = new WebServiceImpressionClient();
            Imprimante imp1 = new Imprimante
            {
                Nom = "Imp1",
                PagesParMinute = 0.01f
            };
            client.AjouterImprimante(imp1);
            Imprimante imp2 = new Imprimante
            {
                Nom = "Imp2",
                PagesParMinute = 0.1f
            };
            client.AjouterImprimante(imp2);
            return client;
        }
    }
}
