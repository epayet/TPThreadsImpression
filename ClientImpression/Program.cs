using ServeurImpressionThreads.WebServiceImpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeurImpressionThreads
{
    static class Program
    {
        private static TcpListener server = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WebServiceImpressionClient webServiceClient = CreerWebServiceClient();

            Dictionary<string, FormImprimante> formsImprimantes = CreerFenetresImprimantes(webServiceClient);

            EventNotifier notifier = new EventNotifier(formsImprimantes);
            Thread threadTcp = new Thread(() => ecouterTcp(notifier, webServiceClient));
            threadTcp.Start();
            
            Application.Run(new FormClient(webServiceClient, formsImprimantes));
            server.Stop();
        }

        private static Dictionary<string, FormImprimante> CreerFenetresImprimantes(WebServiceImpressionClient webServiceClient)
        {
            Dictionary<string, FormImprimante> listeForms = new Dictionary<string, FormImprimante>();
            foreach (ImprimanteMessage uneImp in webServiceClient.GetImprimantes())
            {
                FormImprimante maFormImp = new FormImprimante(uneImp, webServiceClient);
                maFormImp.Show();
                listeForms.Add(uneImp.Nom, maFormImp);
            }
            return listeForms;
        }

        private static WebServiceImpressionClient CreerWebServiceClient()
        {
            WebServiceImpressionClient client = new WebServiceImpressionClient();
            ImprimanteMessage imp1 = new ImprimanteMessage
            {
                Nom = "Imp1",
                PagesParMinute = 0.03f
            };
            client.AjouterImprimante(imp1);
            ImprimanteMessage imp2 = new ImprimanteMessage
            {
                Nom = "Imp2",
                PagesParMinute = 0.01f
            };
            client.AjouterImprimante(imp2);
            return client;
        }

        private static void ecouterTcp(EventNotifier notifier, WebServiceImpressionClient webServiceClient)
        {
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                webServiceClient.AjouterTcpListener(new TcpListenerMessage
                {
                    Addresse = "127.0.0.1",
                    Port = port
                });

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        notifier.Notify(data);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }
        }
    }
}
