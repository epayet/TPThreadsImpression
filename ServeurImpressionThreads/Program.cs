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
        private static ServeurCommunication monServeurComm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            monServeurComm = ServeurFactory.Create();
            CreerFenetresImprimantes();
            Application.Run(new FormClient(monServeurComm));
            
        }

        private static void CreerFenetresImprimantes()
        {
            foreach (Imprimante uneImp in monServeurComm.GetImprimantes())
            {
                FormImprimante maFormImp = new FormImprimante(uneImp);
                maFormImp.Show();
            }
        }
    }
}
