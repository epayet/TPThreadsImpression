using ServeurImpression.Message;
using ServiceImpression.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServeurImpression.Assembleur
{
    public static class ServiceAssembleur
    {
        public static Document ToDocument(this DocumentMessage message)
        {
            return new Document(message.Nom, message.Contenu);
        }

        public static DocumentMessage ToDocumentMessage(this Document document)
        {
            return new DocumentMessage
            {
                Contenu = document.Contenu,
                Id = document.Id,
                Nom = document.Nom
            };
        }

        public static List<DocumentMessage> ToDocumentMessage(this List<Document> documents)
        {
            List<DocumentMessage> liste = new List<DocumentMessage>();
            foreach (Document document in documents)
            {
                liste.Add(document.ToDocumentMessage());
            }
            return liste;
        }

        public static Imprimante ToImprimante(this ImprimanteMessage message)
        {
            return new Imprimante(message.Nom, message.PagesParMinute);
        }

        public static ImprimanteMessage ToImprimanteMessage(this Imprimante imprimante)
        {
            return new ImprimanteMessage
            {
                Etat = imprimante.Etat,
                Nom = imprimante.Nom,
                PagesParMinute = imprimante.PagesParMinute,
                DocumentsEnAttente = imprimante.GetListeDocumentsEnAttente().ToDocumentMessage()
            };
        }

        public static List<ImprimanteMessage> ToImprimanteMessage(this List<Imprimante> imprimantes)
        {
            List<ImprimanteMessage> messages = new List<ImprimanteMessage>();
            foreach (Imprimante imprimante in imprimantes)
            {
                messages.Add(imprimante.ToImprimanteMessage());
            }
            return messages;
        }
    }
}