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

            WebServiceImpressionClient webServiceClient = new WebServiceImpressionClient();

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
    }
}
