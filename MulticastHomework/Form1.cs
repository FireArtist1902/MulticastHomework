using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MulticastHomework
{
    public partial class Form1 : Form
    {

        int localProt = 8001;
        IPAddress broadcastAdaress = Dns.GetHostAddresses(Dns.GetHostName())[1];
        string? name = Name.Text;

        public Form1()
        {
            InitializeComponent();
            Name.Text = "Vadym";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(SendMessage);
        }

        async Task SendMessage()
        {
            using var sender = new UdpClient();
            while (true)
            {
                string? mess = Message.Text;
                if (string.IsNullOrEmpty(mess)) break;
                mess = $"{name}: {mess}";
                byte[] buff = Encoding.UTF8.GetBytes(mess);
                await sender.SendAsync(buff, new IPEndPoint(broadcastAdaress, localProt));
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using var receiver = new UdpClient(localProt);
            receiver.JoinMulticastGroup(broadcastAdaress);
            while (true)
            {
                var result = await receiver.ReceiveAsync();
                string mess = Encoding.UTF8.GetString(result.Buffer);
                Messager.Text = $"receive: {mess}";
            }
        }
    }
}