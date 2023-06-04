using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DeTai02
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private UdpClient udpClient;
        IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
        String ipAddress = "127.0.0.1";
        public void Receive()
        {
            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] receiveMess = udpClient.Receive(ref remoteEP);
                String message = Encoding.UTF8.GetString(receiveMess);
                textBoxReceive.Text = message;
            }
        }
        private void textBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    serverEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
                    udpClient = new UdpClient();
                    string[] from = comboBox_From.Text.Split(':');
                    string[] to = comboBox_To.Text.Split(':'); ;
                    string mess = from[1] + "," + to[1] + "," + textBoxSend.Text;
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(mess);
                    udpClient.Send(sendBytes, sendBytes.Length, serverEndpoint);
                    Thread.Sleep(200);
                    Thread thread = new Thread(new ThreadStart(Receive));
                    thread.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
