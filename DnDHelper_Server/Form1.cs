using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDHelper_Server
{
    public partial class Form1 : Form
    {

        //Declare and Initialize the IP Adress
        static IPAddress ipAd = IPAddress.Parse("192.168.0.11");

        //Declare and Initilize the Port Number;
        static int PortNumber = 8888;

        /* Initializes the Listener */
        TcpListener ServerListener = new TcpListener(ipAd, PortNumber);
        TcpClient clientSocket = default(TcpClient);

        Action<string> Del_UpdateChat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Del_UpdateChat = UpdateChat;
            Thread ThreadingServer = new Thread(StartServer);
            ThreadingServer.Start();

        }

        private void UpdateChat(string teste)
        {
            Main_Chat_History_txtBx.Text += Environment.NewLine + teste;
        }

        private void StartServer()
        {
            ServerListener.Start();
            Invoke(Del_UpdateChat, "Looking for connections.");
            clientSocket = ServerListener.AcceptTcpClient();
            Invoke(Del_UpdateChat, "Connection Found.");

            while (true)
            {
                try
                {

                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[20];
                    networkStream.Read(bytesFrom, 0, 20);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    Invoke(Del_UpdateChat, "Client: " + dataFromClient);

                    string serverResponse = "Received!";
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                }
                catch
                {
                    ServerListener.Stop();
                    ServerListener.Start();
                    Invoke(Del_UpdateChat, "Server waiting connections!");
                    clientSocket = ServerListener.AcceptTcpClient();
                    Invoke(Del_UpdateChat, "Server ready!");
                }

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {        
            string newMessage = Main_Chat_Message_txtBx.Text;
            Invoke(Del_UpdateChat, "Server: " + newMessage);

            NetworkStream networkStream = clientSocket.GetStream();

            Byte[] sendBytes = Encoding.ASCII.GetBytes(newMessage);
            networkStream.Write(sendBytes, 0, sendBytes.Length);
            networkStream.Flush();

            Main_Chat_Message_txtBx.Clear();

        }
    }
}