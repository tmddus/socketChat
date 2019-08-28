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

namespace socketChat
{
    public partial class clientForm : Form
    {
        Socket client;
        bool isConn;
        byte[] bytes = new byte[1024];
        string data;
        string myIp_str;
        string cliName;
        string sevName;




        public clientForm()
        {
            InitializeComponent();
            isConn = false;
            myIp_str = getMyIp();
            myIP.Text = myIp_str;
            myName.Text = myIp_str; // 임시로 설정
            cliName = myIp_str;
        }

        private void conBtn_Click(object sender, EventArgs e)
        {
            if(isConn == true)
            {
                MessageBox.Show("이미 연결이 되어있습니다");
                return;
            }
            client = new Socket(AddressFamily.InterNetwork, 
                SocketType.Stream, ProtocolType.IP);
            client.Connect(new IPEndPoint(IPAddress.Parse(IPLb.Text), int.Parse(PortLb.Text)));
            chatArea.Items.Add(IPLb.Text + " : " + PortLb.Text +  "서버에 연결이 되었습니다");
            isConn = true;

            Thread thread = new Thread(do_receive);
            thread.Start();

           
        }


    void do_receive()
        {
            while (isConn)
            {
                while (true)
                {
                    byte[] bytes = new byte[1024];
                    int bytesRec = client.Receive(bytes);
                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<eof>") > -1)
                        break;
                }
                data = data.Substring(0, data.Length - 5);
                Invoke((MethodInvoker)delegate
                {
                    chatArea.Items.Add(data);
                }
                );
                data = "";
            }
        }





        private string getMyIp() // 현재 pc의 아이피를 구하는 메서드
        {

            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }

            return localIP;

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (isConn == false)
            {
                MessageBox.Show("서버에 연결되지 않았습니다");
                return;
            }
            string send_msg = cliName + " : " + chatMsg.Text + "<eof>";
            byte[] chat = Encoding.UTF8.GetBytes(send_msg);
            int sendInt = client.Send(chat);
            chatMsg.Clear();

            chatArea.Items.Add(send_msg);
        }
    }
}
