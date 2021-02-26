using NSec.Cryptography;
using System;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\Users\\Pizza\\source\\repos\\CMakeProject2\\CMakeProject2";
            Span<byte> filetest = new byte[100000];

            if (File.Exists(path)) {
                byte[] fileb = File.ReadAllBytes(path);
                int count = 0;
                foreach (byte b in fileb)
                {
                    filetest[count] = b;
                    count++;
                }


            }
            

            AeadAlgorithm x= AeadAlgorithm.Aes256Gcm;
            
            Span<int> num = new int[1];
            Sha256 alg= new Sha256();    // dont use sha im stupid
            Key a= Key.Create(alg);
            Nonce n = new Nonce();
            if(!filetest.IsEmpty)
            x.Encrypt(a, n,null, filetest);
            Console.WriteLine("Program dead everyone clap");
        }
    }
}
