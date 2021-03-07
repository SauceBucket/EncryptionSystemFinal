using System;
using System.Net.Sockets;
using System.IO;

namespace Connection
{
    class Client
    {
        static void Connect(string server, string path)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpListener
                // connected to the same address as specified by the server, port
                // combination.
                int port = 13000;
                TcpClient client = new TcpClient(server, port);

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
