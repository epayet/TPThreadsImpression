using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ServeurImpression
{
    class ImprimanteRunner
    {
        public Imprimante Imprimante { get; set; }

        public void Run()
        {
            while (true)
            {
                if (Imprimante.PeutImprimer())
                {
                    Console.WriteLine("Imprimante %s commence à imprimer", Imprimante.Nom);
                    Document documentImprimé = Imprimante.Imprimer();
                    Console.WriteLine("Imprimante %s a imprimé le document %s", Imprimante.Nom, documentImprimé.Nom);
                }
                Thread.Sleep(3000);
            }
        }
    }
}
