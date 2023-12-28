using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScreenshotApp_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonshot_Click(object sender, EventArgs e)
        {
            try
            {
                Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                EndPoint localEP = new IPEndPoint(IPAddress.Any, 0);
                EndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 27001);

                udpClient.Bind(localEP);

                byte[] bytesToSend = Encoding.ASCII.GetBytes("Take screenshot");

                udpClient.SendTo(bytesToSend, serverEP);

                byte[] bytesReceived = new byte[65535];
                int bytesReceivedCount = udpClient.ReceiveFrom(bytesReceived, ref serverEP);

                byte[] decompressedBytes = Decompress(bytesReceived, bytesReceivedCount);
                MemoryStream memoryStream = new MemoryStream(decompressedBytes);
                Image image = Image.FromStream(memoryStream);
                pictureBox1.Image = image;

                udpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        static byte[] Decompress(byte[] data, int count)
        {
            using MemoryStream input = new MemoryStream(data, 0, count);
            using GZipStream decompressor = new GZipStream(input, CompressionMode.Decompress);
            using MemoryStream output = new MemoryStream();
            decompressor.CopyTo(output);
            return output.ToArray();
        }

    }



}
