using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyPhone
{
    class Program
    {
        static int port = 8000;
        static string host = "127.0.0.1";
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.WriteLine("STOP");
            Console.ReadKey();
        }

        public void Run()
        {
            Console.Write("1: Server 2: Client > ");
            string t = Console.ReadLine();

            Phone phone;

            if (t == "1")
                phone = new PhoneServer(port);
            else
                phone = new PhoneClient(host, port);
            phone.Recv += Recv;
            phone.Start();

            while (true)
            {
                phone.Send((byte)rand.Next(10, 100));
                Thread.Sleep(2000);
            }
        }

        public void Recv(byte data)
        {
            Console.WriteLine("Recv " + data.ToString());
        }
    }
}
