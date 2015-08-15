using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SokobanGame
{
    public delegate void deRecv(byte data);

    abstract class Phone
    {
        protected NetworkStream ns;
        protected string host;
        protected int port;
        public deRecv Recv;

        public void Start()
        {
            Thread thread = new Thread(Waiter);
            thread.IsBackground = true;
            thread.Start();
        }

        private void Waiter() // для ожидание вызова и переподключения
        {
            while (true)
            {
                Connect();
                while (true)
                {
                    try
                    {
                        int data = ns.ReadByte();
                        if (data != -1)
                            Recv((byte)data);
                    }
                    catch
                    {
                        Thread.Sleep(100);
                        break;
                    }
                }
            }
        }

        abstract public void Connect();

        public bool Send(byte data)  // для отправки данных
        {
            try
            {
                ns.WriteByte(data);
                return true;
            }
            catch
            {
                Thread.Sleep(100);
                return false;
            }
        }
    }

    class PhoneServer : Phone
    {
        public PhoneServer(int port)
        {
            this.port = port;
        }

        override public void Connect()
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
                ns = client.GetStream();
            }
            catch (Exception ex)
            {
            }
        }
    }

    class PhoneClient : Phone
    {
        public PhoneClient(string host, int port)
        {
            this.host = host;
            this.port = port;
        }

        override public void Connect()
        {
            try
            {
                TcpClient client = new TcpClient(host, port);
                ns = client.GetStream();
            }
            catch (Exception ex)
            {
            }
        }
    }
}

