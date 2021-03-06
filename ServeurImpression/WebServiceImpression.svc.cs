﻿using ServeurImpression.Message;
using ServiceImpression;
using ServiceImpression.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServeurImpression.Assembleur;
using ServiceImpression.Evenement.Listeners;

namespace ServeurImpression
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] 
    public class WebServiceImpression : IWebServiceImpression
    {
        private ImpressionService _impressionService;
        private ImpressionService impressionService
        {
            get
            {
                if (_impressionService == null)
                {
                    _impressionService = new ImpressionService();
                    _impressionService.AjouterEventListener(new WCFConsoleLogEventListener());
                    System.Diagnostics.Debug.WriteLine("instance");
                }
                return _impressionService;
            }
            set
            {
                _impressionService = value;
            }
        }

        public ImprimanteMessage AjouterDocument(DocumentMessage documentMessage)
        {
            Imprimante imprimante = impressionService.AjouterDocument(documentMessage.ToDocument());
            return imprimante.ToImprimanteMessage();
        }

        public void SupprimerDocument(DocumentMessage documentMessage)
        {
            impressionService.SupprimerDocument(documentMessage.Id);
        }

        public List<ImprimanteMessage> GetImprimantes()
        {
            return impressionService.GetImprimantes().ToImprimanteMessage();
        }

        public ImprimanteMessage GetImprimante(string nom)
        {
            return impressionService.GetImprimante(nom).ToImprimanteMessage();
        }

        public void AjouterImprimante(ImprimanteMessage imprimanteMessage)
        {
            impressionService.AjouterImprimante(imprimanteMessage.ToImprimante());
        }

        public void SupprimerImprimante(ImprimanteMessage imprimanteMessage)
        {
            impressionService.SupprimerImprimante(imprimanteMessage.Nom);
        }

        public int GetDocumentNbPages(DocumentMessage documentMessage)
        {
            return documentMessage.ToDocument().GetNbPages();
        }

        public float GetTempsPrevuPourImpression(ImprimanteMessage imprimanteMessage, DocumentMessage documentMessage)
        {
            return impressionService.GetImprimante(imprimanteMessage.Nom).GetTempsPrévuPourDoc(documentMessage.ToDocument());
        }

        public void AjouterTcpListener(TcpListenerMessage listenerMessage)
        {
            TcpClientListener listener = new TcpClientListener(listenerMessage.Addresse, listenerMessage.Port);
            impressionService.AjouterEventListener(listener);
        }
    }
}
