using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using System.Threading;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Sockets;
using UnityEditor.VersionControl;
public class ConnectToOPC : MonoBehaviour
{
    private Process myprocess;
    private int port;
    private IPAddress localAddr;
    private TcpListener listener;
    private TcpClient client;
    private NetworkStream stream;
    private string s;
    private bool close = false;
    private string outStr;
    [SerializeField] private SensorBase[] sensors;
    public string[] Str;

    void Awake()
    {
        myprocess = new Process();
        myprocess.StartInfo.FileName = "C:\\Users\\Hotking\\OneDrive\\Документы\\c####\\clientOPCUA\\clientOPCUA\\bin\\Debug\\clientOPCUA.exe";
        myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
        myprocess.Start();
        port = 13000;
        localAddr = IPAddress.Parse("127.0.0.1");
        listener = new TcpListener(localAddr, port);
        listener.Start();
    }

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            close = true;
            stream.Close();
            myprocess.Kill();
        }
        if (!close)
            Server();
    }

    void Server()
    {
        client = listener.AcceptTcpClient();
        stream = client.GetStream();
        byte[] data = new byte[1024];
        int bytes = stream.Read(data, 0, data.Length);
        Str = Encoding.UTF8.GetString(data).Split(' ');
        WriteValues();
    }

    private void WriteValues()
    {
        stream = client.GetStream();
        outStr = "";
        for (int i = 0; i < sensors.Length; i++)
        {
            outStr += sensors[i].Value.ToString() + " ";
        }

        byte[] data = Encoding.UTF8.GetBytes(outStr);
        try
        {
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                var remoteEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
                socket.Connect(remoteEndpoint);

                socket.Send(data);
            }
        }
        catch (Exception ex)
        {
            
        }
    }
}
