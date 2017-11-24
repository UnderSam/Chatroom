using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
using System.Threading;
using System.IO;

namespace server
{
    class Program
    {
        
        static IPEndPoint ip = new IPEndPoint(IPAddress.Any, 9487);
       
        static IPEndPoint ipGp = new IPEndPoint(IPAddress.Broadcast, 9487);
        static int numberOfClient = 0;

        static UdpClient udpClientSocket = new UdpClient();
        static UdpClient udpReceiver = new UdpClient();
        //static List<TcpClient> clientSockets = new List<TcpClient> { };
        static List<ClientData> clientSockets = new List<ClientData> { };
        //CallBack
        static bool triger = false;
        private static bool clientDisconnet;

        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(9487);  //server的socket(listener)
            udpClientSocket.EnableBroadcast = true;

            serverSocket.Start();
            Console.WriteLine("等待連線中......");

            BackgroundWorker[] bw = new BackgroundWorker[100]; // 一個bkw階一個client

            TcpClient tempclient;  //accept的東西丟到tempclient
            string tempName;
            byte[] bytes = Encoding.ASCII.GetBytes("Server Open Message");
            string tempIp;


            udpReceiver.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpReceiver.Client.Bind(ip);

            try
            {
                udpReceiver.BeginReceive(new AsyncCallback(recv), null);
            }
            catch (Exception e)
            {
               Console.WriteLine(e.ToString());
            }


            while (true)
            {
                //開背景執行
                bw[numberOfClient] = new BackgroundWorker();
                bw[numberOfClient].WorkerReportsProgress = true; // 沒用到
                bw[numberOfClient].WorkerSupportsCancellation = true; //可以終止這個worker
                bw[numberOfClient].DoWork += Bw_DoWork; //可以寫response  如果觸發就去progress
                bw[numberOfClient].ProgressChanged += Bw_ProgressChanged;  // +=會自己變出thread函氏
                bw[numberOfClient].RunWorkerCompleted += Bw_RunWorkerCompleted;
                //接client
                tempclient = serverSocket.AcceptTcpClient();

                
                Thread.Sleep(1000);
                if (tempclient.Connected)  //判斷是否有連到
                {
                    StreamReader srin = new StreamReader(tempclient.GetStream());
                    
                    tempName = srin.ReadLine();
                    tempIp = srin.ReadLine();
                    ClientData tempData = new ClientData(tempName, tempclient,tempIp);
                    clientSockets.Add(tempData);
                    Console.WriteLine("TCP client連到囉(Name : "+tempName+" , IP = "+tempIp+" )\n");
                    bw[numberOfClient].RunWorkerAsync(tempData); //讀到這行就開始坐do work的事情
                    numberOfClient++;
                }
            }
        }

        private static void recv(IAsyncResult res)
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 9487);
            
            byte[] received = udpReceiver.EndReceive(res, ref RemoteIpEndPoint);
            if (!clientDisconnet)
            {
                Console.Write("broadcast : "+Encoding.UTF8.GetString(received));
                udpClientSocket.Send(received, received.Length, ipGp);
                byte[] wasted = udpReceiver.Receive(ref RemoteIpEndPoint); //把給自己的pkt吃掉
            }
            else
            {

                clientDisconnet = false;
            }
            udpReceiver.BeginReceive(new AsyncCallback(recv), null);
        }
       

        private static void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private static void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private static void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backw = sender as BackgroundWorker;
            ClientData tempclient = e.Argument as ClientData;
            byte[] recvImag;
            int senderBuffer;
            string isEnd_orPassImage;
            while (true)
            {
                NetworkStream ns = tempclient.Tcpclient.GetStream();
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);


                try
                {
                    isEnd_orPassImage = sr.ReadLine();
                    if (isEnd_orPassImage == "end" || isEnd_orPassImage == null)
                    {
                        //string disconMessage = sr.ReadLine();
                        //Console.WriteLine(disconMessage);
                        Console.WriteLine("A Client is disconnected");
                        break;
                    }
                    senderBuffer = int.Parse(isEnd_orPassImage);

                    if (ns.CanRead)
                    {
                        Console.WriteLine("size: " + senderBuffer.ToString());
                        recvImag = new byte[senderBuffer];


                        int count = senderBuffer;
                        int read, offset = 0;

                        while (count > 0 && ((read = ns.Read(recvImag, offset, count))) > 0)
                        {
                            offset += read;
                            count -= read;
                        }
                        if (count != 0) throw new EndOfStreamException();


                        Console.WriteLine("client sent a photo (size :" + recvImag.Length.ToString() + " )");

                        ns.Flush();

                        for (int i = 0; i < numberOfClient; i++)
                        {
                            if (clientSockets[i] != tempclient)
                            {
                                ns = clientSockets[i].Tcpclient.GetStream();
                                sw = new StreamWriter(ns);
                                sr = new StreamReader(ns);
                                sw.WriteLine(senderBuffer.ToString());
                                sw.Flush();
                                ns.Write(recvImag, 0, recvImag.Length); //送回去
                                ns.Flush();
                            }
                        }
                        Console.WriteLine("you send it back");
                        Thread.Sleep(1000);
                    }
                }
                catch
                {
                    if (SocketExtensions.IsConnected(tempclient.Socket) == false)
                    {
                       
                        string dicString = "Client " + tempclient.Name + " is disconnected ( " + tempclient.Ip + " )";

                        byte[] sendB = Encoding.UTF8.GetBytes(dicString);
                        udpClientSocket.Send(sendB, sendB.Length, ipGp);
                        clientDisconnet = true;
                        Console.WriteLine("broadcast : " + dicString);

                        clientSockets.Remove(tempclient);
                        if(clientSockets.Count==0)
                        {
                            Console.WriteLine("No Client is Online Now.....");
                        }
                    }
                }

            }
        }
    }
}
