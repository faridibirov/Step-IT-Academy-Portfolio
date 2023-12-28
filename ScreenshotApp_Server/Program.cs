using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    [DllImport("user32.dll")]
    static extern bool SetProcessDPIAware();

    static Size GetMonitorSize()
    {
        IntPtr hwnd = Process.GetCurrentProcess().MainWindowHandle;
        using Graphics g = Graphics.FromHwnd(hwnd);
        return new Size((int)g.VisibleClipBounds.Width, (int)g.VisibleClipBounds.Height);
    }

    static byte[] Compress(byte[] data)
    {
        using MemoryStream output = new MemoryStream();
        using GZipStream compressor = new GZipStream(output, CompressionMode.Compress);
        compressor.Write(data, 0, data.Length);
        compressor.Close();
        return output.ToArray();
    }

    static Bitmap TakeScreenshot(Size size)
    {
        Bitmap bmp = new Bitmap(size.Width, size.Height);
        using Graphics graphics = Graphics.FromImage(bmp);
        graphics.CopyFromScreen(Point.Empty, Point.Empty, bmp.Size);
        return bmp;
    }

    static void Client(EndPoint endPoint, byte[] buffer, int bytesReceivedCount, Socket? listener)
    {
        SetProcessDPIAware();
        Size monitorSize = GetMonitorSize();
        using Bitmap bitmap = TakeScreenshot(monitorSize);

        using MemoryStream memoryStream = new MemoryStream();
        bitmap.Save(memoryStream, ImageFormat.Jpeg);

        byte[] bytesToSend = memoryStream.ToArray();

        bytesToSend = Compress(bytesToSend);

        for (int i = 0; i < bytesToSend.Length; i += 4096)
        {
            int bytesToSendCount = Math.Min(4096, bytesToSend.Length - i);
            byte[] chunk = new byte[bytesToSendCount];
            Array.Copy(bytesToSend, i, chunk, 0, bytesToSendCount);
            listener.SendTo(chunk, endPoint);
        }

        Console.WriteLine("Screenshot sent to client.");
    }

    static void Main(string[] args)
    {
        var listener = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Dgram,
            ProtocolType.Udp);

        IPAddress.TryParse("127.0.0.1", out var ip);
        var listenerEP = new IPEndPoint(ip, 27001);
        listener.Bind(listenerEP);

        byte[] buffer = new byte[65535];

        EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);

        while (true)
        {
            int bytesReceivedCount = listener.ReceiveFrom(buffer, ref endPoint);

            Thread clientThread = new Thread(() => Client(endPoint, buffer, bytesReceivedCount, listener));
            clientThread.Start();
        }
    }
}
