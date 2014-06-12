﻿using ServiceImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceImpression.Data;
using ServeurImpressionThreads.Serveur;

namespace ServeurImpressionThreads
{
    static class Program
    {
        private static IServeur monServeurComm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            monServeurComm = ServeurFactory.Create(ServeurStrategie.SIMPLE);
            List<Imprimante> listeImprimantes = new List<Imprimante>();
            List<FormImprimante> listeFormsImprimantes = new List<FormImprimante>();
            listeFormsImprimantes = CreerFenetresImprimantes(listeImprimantes);
            Application.Run(new FormClient(monServeurComm, listeFormsImprimantes));
        }

        private static List<FormImprimante> CreerFenetresImprimantes(List<Imprimante> listeImprimantes)
        {
            listeImprimantes.Clear();
            List<FormImprimante> listeForms = new List<FormImprimante>();
            foreach (Imprimante uneImp in monServeurComm.GetImprimantes())
            {
                FormImprimante maFormImp = new FormImprimante(uneImp);
                maFormImp.Name = uneImp.Nom;
                maFormImp.Show();
                listeForms.Add(maFormImp);
            }
            return listeForms;
        }
    }
}
