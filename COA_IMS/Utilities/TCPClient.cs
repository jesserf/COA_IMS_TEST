using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_IMS.Utilities
{
    internal class TCPClient
    {
        private static TcpClient client;

        public static event EventHandler<string> MessageReceived;

        public static async Task ConnectAsync(string ipAddressString, int port)
        {
            Console.WriteLine("Help");
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(ipAddressString, port);
                _ = Task.Run(ReceiveMessagesAsync); // Start receiving messages in a background task
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to server: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task SendAsync(string message)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message: {ex.Message}");
            }
        }

        private static async Task ReceiveMessagesAsync()
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] data = new byte[256];
                while (true)
                {
                    int bytesRead = await stream.ReadAsync(data, 0, data.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    string message = Encoding.ASCII.GetString(data, 0, bytesRead);
                    OnMessageReceived(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving messages: {ex.Message}");
            }
        }

        private static void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(null, message);
        }

        public static void Disconnect()
        {
            try
            {
                if (client != null)
                {
                    client.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error disconnecting from server: {ex.Message}");
            }
        }

    }
}
