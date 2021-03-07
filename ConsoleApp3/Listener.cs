using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Connection
{
    class Listener
    {
        static void Recieve()
        {
            // Buffer for reading data
            byte[] fileArray = null;

            //User input save location. GUI input from Browse...
            string savePath = "";

            //Get local ip somehow...
            //string localIP = null;          

            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                int port = 13000;
                IPAddress localAddr = IPAddress.Parse("192.168.0.202");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(fileArray, 0, fileArray.Length)) != 0)
                    {
                        File.WriteAllBytes(savePath, fileArray);
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

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
    }
}
