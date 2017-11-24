using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


public class ClientData
{
    private TcpClient tcpclient;
    private string name;
    private Socket socket;

    public ClientData(string name,TcpClient tc,string tip)
    {
        this.socket = tc.Client;
        this.Name = name;
        this.Tcpclient = tc;
        this.Ip = tip;
    }
    private string ip;

    public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

    public TcpClient Tcpclient
        {
            get
            {
                return tcpclient;
            }

            set
            {
                tcpclient = value;
            }
        }

    public Socket Socket
        {
            get
            {
                return socket;
            }

            set
            {
                socket = value;
            }
        }

    public string Ip
    {
        get
        {
            return ip;
        }

        set
        {
            ip = value;
        }
    }
}

