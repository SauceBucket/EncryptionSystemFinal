//Code copied and altered from https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.tcpclient?view=net-5.0
using System;
using System.Net.Sockets;
using System.IO;

namespace Connection
{
    class Client
    {
        public void Connect(string recieversIP, string path)
        {
            try
            {
                //Constant Port
                int port = 13000;

                // Create a TcpClient.
                TcpClient client = new TcpClient(recieversIP, port);

                // Get a client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                //Convert File from parameter "path" to Byte Array for sending.
                byte[] fileArray = File.ReadAllBytes(path);

                // Send the message to the connected TcpServer.
                stream.Write(fileArray, 0, fileArray.Length);

                Console.WriteLine("Sent: File");

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
    }
}
