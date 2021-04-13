//Code based off of code from https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.tcplistener?view=net-5.0
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace EncryptionSystem
{
    class Listener
    {
        public void Receive(string localIP, string savePath)
        {
            // Buffer for reading data
            byte[] fileArray = new byte[16];
            TcpListener server = null;

            try
            {
                // Set the TcpListener on port 13000.
                int port = 13000;
                IPAddress localAddr = IPAddress.Parse(localIP);

                //Set up the recieving connection.
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Enter the listening loop.
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    //Console.WriteLine("Connected!");

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    //(11 chosen for the test file) FIX getFileLength before the recieve
                    while ((i = stream.Read(fileArray, 0, 16)) != 0)
                    {
                        File.WriteAllBytes(savePath, fileArray);
                    }

                    // Shutdown and end connection
                    client.Close();
                    break;
                }
            }
            catch (SocketException e)
            {
                //Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            //Console.WriteLine("\nHit enter to continue...");
            //Console.Read();
        }
    }
}

