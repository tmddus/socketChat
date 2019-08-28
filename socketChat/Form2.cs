using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace socketChat
{
    public partial class serverForm : Form
    {

        Socket listen; 
        Socket client;  // 소켓 선언부
        bool isConn; // 클라이언트와 서버가 연결되었는지 저장하는 변수.
        string cliName;
        string server_name;

        byte[] b = new byte[1024];
        string data;


        String currentIP;
        String currentPort;
        public serverForm()
        {
            isConn = false; // 처음에는 false로 초기화
            InitializeComponent();
            currentIP = getMyIp(); // 현재 pc의 아이피를 가져옴
            IPlb.Text = currentIP; // 화면에 아이피 표시
            myName.Text = currentIP; // 처음에 임시로 이름 정하기
            server_name = currentIP;
        }



        private void makeBtn_Click(object sender, EventArgs e)
        {
            currentPort = portLb.Text;
           serverStart(currentIP, int.Parse(currentPort), 10);

        }


        public void serverStart(string host, int port, int backlog)
        {
            this.listen = new Socket(AddressFamily.InterNetwork, 
                SocketType.Stream, ProtocolType.Tcp);
            IPAddress address = IPAddress.Parse(host);
            IPEndPoint end = new IPEndPoint(address, port);
            
            try
            {
                listen.Bind(end);
                listen.Listen(backlog);

                chatArea.Items.Add("참여자를 기다립니다.");  
                client = listen.Accept(); // 클라이언트 대기 시작
               
                cliName = ((IPEndPoint)client.RemoteEndPoint).Address.ToString();
                chatArea.Items.Add(cliName + "님이 입장하셨습니다");
                isConn = true;
                Thread thread = new Thread(do_receive);
                thread.Start();
                
            }
            catch (Exception e)
            {}
           


        }

        void do_receive()//do receive 함수입니다. 이 함수가 채팅서버의 결정적인 함수입니다.
        {
            while (isConn)
            {
                while (true)
                {
                    byte[] bytes = new byte[1024];  //바이트 배열 선언
                    int bytesRec = client.Receive(bytes);
                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);  //인코딩과 GetString
                    if (data.IndexOf("<eof>") > -1)
                        break;
                }

                data = data.Substring(0, data.Length - 5);
                Invoke((MethodInvoker)delegate
                {
                    chatArea.Items.Add(data);  //클라에게 받은 문자 chatArea(listBox)에 넣어줌
                }
                );
                data = "";  //초기화
            }
        }


        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (isConn == false)
            {
                MessageBox.Show("클라이언트가 연결되지 않았습니다!");
                return;
            }
            string send_msg = server_name + " : " + chatMsg.Text + "<eof>";
            byte[] chat = Encoding.UTF8.GetBytes(send_msg);
            int sendInt = client.Send(chat);
            chatMsg.Clear();

            chatArea.Items.Add(send_msg);


        }

        private void changeName_Click(object sender, EventArgs e)
        {
            string chName = myName.Text.ToString();
            byte[] chat = Encoding.UTF8.GetBytes(server_name + "님이 " + chName + "으로 변경하셨습니다");
            int sendInt = client.Send(chat);
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
    }
}
