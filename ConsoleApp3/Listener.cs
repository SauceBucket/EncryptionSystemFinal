using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Connection
{
    class Listener
    {
        
        //Method for listening for connections from TCPClient.
        //Only arguments are recievers localIP which will take from GUI
        //settings options or an eventual getLocalIP method.
        // And savePath where the reciever wants to save the incoming file.
        static void Recieve(string localIP, string savePath)
        {
            // Buffer for reading data
            byte[] fileArray = null;
            
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                //Keep port at 13000 for continuity.
                int port = 13000;
                IPAddress localAddr = IPAddress.Parse(localIP);

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
