using ServeurImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return serveur;
        }
    }
}
