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


namespace Client
{
    public partial class Form1 : Form
    {

    

       
        Socket client;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"),9050);           

        }

        private void button5_Click(object sender, EventArgs e)
        {

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            client.Connect(ipep);
            byte[] data;
            data = new byte[1024];
            client.Receive(data);
            listBox1.Items.Add("server:" + Encoding.ASCII.GetString(data));

        }
    }
}
