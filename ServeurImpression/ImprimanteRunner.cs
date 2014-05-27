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
                if(Imprimante.PeutImprimer())
                    Imprimante.Imprimer();
                Thread.Sleep(3000);
            }
        }
    }
}
