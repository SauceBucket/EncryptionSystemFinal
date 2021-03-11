using System;
using System.Collections.Generic;
using System.Text;

namespace Connection
{
    class Runner
    {
        static void Main(string[] args)
        {
            Client sender = new Client();
            Listener reciever = new Listener();

            //C# uses @ to deactivate delimiters (\) in the string.
            reciever.Recieve("192.168.0.202", @"C:\Users\richa\Downloads\hello.txt");

            //sender.Connect("24.144.139.67", "C:\\Users\richa\\Desktop\\shit\\league.txt");

        }
    }
}