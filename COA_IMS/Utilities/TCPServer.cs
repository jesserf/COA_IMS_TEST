using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace COA_IMS.Utilities
{
    internal class TCPServer
    {
        private TcpListener listener;
        private List<TcpClient> connectedClients = new List<TcpClient>();

        public event EventHandler<string> MessageReceived;

        public async Task StartServerAsync(string ipAddressString, int port)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ipAddressString);
                listener = new TcpListener(ipAddress, port);
                listener.Start();

                Console.WriteLine($"Server started. Listening for connections on {ipAddress}:{port}");

                while (true)
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();
                    connectedClients.Add(client);
                    Console.WriteLine(client);
                    _ = HandleClientAsync(client); // Start handling client asynchronously
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting server: {ex.Message}");
                //MessageBox.Show($"Error starting server: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Task StopServerAsync()
        {
            try
            {
                listener?.Stop();
                Console.WriteLine("Server stopped.");

                foreach (var client in connectedClients)
                {
                    client.GetStream().Dispose(); // Dispose of the stream
                    client.Close(); // Close the client
                }
                connectedClients.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error stopping server: {ex.Message}");
            }

            return Task.CompletedTask;
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;

                Console.WriteLine($"Client connected: {client.Client.RemoteEndPoint}");

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    OnMessageReceived(message); // Raise event for message received
                }

                Console.WriteLine($"Client disconnected: {client.Client.RemoteEndPoint}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error handling client: {ex.Message}");
            }
            finally
            {
                client.Close();
                connectedClients.Remove(client);
            }
        }

        public async Task SendMessageToAllClientsAsync(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            foreach (TcpClient client in connectedClients)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    await stream.WriteAsync(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending message to client: {ex.Message}");
                }
            }
        }

        // Method to raise the MessageReceived event
        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(this, message);
        }
    }
}
