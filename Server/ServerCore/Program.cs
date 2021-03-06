﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerCore
{
    class Program
    {
        private static SocketListener _serverSocket = new SocketListener();


        static void Main(string[] args)
        {
            // 여기서 불리는 callback은 별도의 쓰레드 풀에서 돈다.
            _serverSocket.InitSocket(OnConnected);
            while (true) {
                    
            }
        }

        public static void OnConnected(Socket _clientSocket) 
        {
            var session = new Session();
            session.Start(_clientSocket);

            Thread.Sleep(2000);

            session.Disconnect();
        }
    }
}
