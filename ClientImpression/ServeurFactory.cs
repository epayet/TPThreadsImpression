using ServiceImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceImpression.Data;

namespace ServeurImpressionThreads
{
    class ServeurFactory
    {
        public static ServeurCommunication Create()
        {
            //Lancer serveurs
            SimpleServeur serveur = new SimpleServeur();

            Imprimante Imp = new Imprimante("imp1", 2);
            serveur.monServeur.AjouterImprimante(Imp);
            Imprimante Imp2 = new Imprimante("imp2", 3);
            serveur.monServeur.AjouterImprimante(Imp2);
            return serveur;
        }
    }
}
