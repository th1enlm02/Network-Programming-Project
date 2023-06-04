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

namespace DeTai05
{
    public partial class FTP : Form
    {
        public FTP()
        {
            InitializeComponent();
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string ipAddress = textBoxIPAddress.Text; // Địa chỉ IP của máy tính cần kiểm tra
            int port = 21; // Cổng FTP mặc định
            try
            {
                // Tạo socket và kết nối tới địa chỉ IP và cổng
                using (var client = new TcpClient())
                {
                    client.Connect(ipAddress, port);
                    if (client.Connected)
                    {
                        Message msg = new Message();
                        msg.labelCaption.Text = "Notification";
                        msg.bunifuLabelText.Text = "FTP service is running.";
                        msg.ShowDialog();
                    }
                    else
                    {
                        Message msg = new Message();
                        msg.labelCaption.Text = "Notification";
                        msg.bunifuLabelText.Text = "Can not connect to FTP service.";
                        msg.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Message msg = new Message();
                msg.labelCaption.Text = "Error";
                msg.bunifuLabelText.Text = ex.Message;
                msg.ShowDialog();
            }
        }
        private void textBoxIPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCheck.PerformClick();
            }
        }
    }
}
