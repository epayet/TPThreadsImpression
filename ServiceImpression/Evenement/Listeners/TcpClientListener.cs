using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServiceImpression.Evenement.Listeners
{
    public class TcpClientListener : EventListener
    {
        public int port { get; set; }

        public string addresse { get; set; }

        public TcpClientListener(string addresse, int port) : base(addresse + port)
        {
            this.addresse = addresse;
            this.port = port;
        }

        public override void DebutImpression(Data.Imprimante imprimante)
        {
            this.Envoyer("" + imprimante.Nom + ":" + "DebutImpression");
        }

        public override void ImpressionPage(Data.Imprimante imprimante, int nbPagesImprimees)
        {
            this.Envoyer("" + imprimante.Nom + ":" + "ImpressionPage");
        }

        public override void FinImpression(Data.Imprimante imprimante, Data.Document DocumentEnCours)
        {
            this.Envoyer("" + imprimante.Nom + ":" + "FinImpression");
        }

        private void Envoyer(string message)
        {
            TcpClient client = new TcpClient(addresse, port);

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            NetworkStream stream = client.GetStream();

            // Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length);

            // Close everything.
            stream.Close();
            client.Close();
        }
    }
}
