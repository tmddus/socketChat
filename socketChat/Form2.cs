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
        Thread thread;

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
            currentPort = portLb.Text; // 접속 포트 설정
            chatArea.Items.Add("대 기 중 . . ."); // 대기 중
            serverStart(currentIP, int.Parse(currentPort), 10); // 서버 시작, 함수로 이동

        }


        public void serverStart(string host, int port, int backlog)
        {
            this.listen = new Socket(AddressFamily.InterNetwork, 
                SocketType.Stream, ProtocolType.Tcp); // 접속 소켓 생성
            IPAddress address = IPAddress.Parse(host); 
            IPEndPoint end = new IPEndPoint(address, port); 
            // ip주소를long 으로 변환하여 end point 생성

            try
            {
                listen.Bind(end);
                listen.Listen(backlog);  
                client = listen.Accept(); // 클라이언트 대기 시작
               
                cliName = ((IPEndPoint)client.RemoteEndPoint).Address.ToString();
                // 클라이언트 이름 임시 설정
                chatArea.Items.Add(cliName + "님이 입장하셨습니다");
                isConn = true; // 연결을 알려주는 변수 true로 설정
                thread = new Thread(do_receive);
                thread.Start();
                // thread 시작
                
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
                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);  //인코딩과 GetStrin

                    if (data.IndexOf("<eof>") > -1)
                        break;
                }

                data = data.Substring(0, data.Length - 5);

                if (data.Contains("<changeName>")) // 이름을 변경한 경우
                {
                    nameChange(data.Replace("<changeName>", ""));
                    //처리할 함수 호출
                    data = "";
                    //data 변수 초기화
                }

                if (data.Contains("<exit>")) // 클라이언트와의 접속이 끊긴 경우
                {
                    isConn = false; // 접속을 false로 만들고
                    chatArea.Items.Add(data.Replace("<exit>", ""));
                    //서버와의 연결이 끊겼다는 메시지 출력
                    break;
                    //while문에서 빠져나감
                }

                Invoke((MethodInvoker)delegate // thread 안전을 위해 사용
                {
                    chatArea.Items.Add(data);  //클라에게 받은 문자 chatArea(listBox)에 넣어줌
                }
                );
                data = "";  //초기화
            }
        }

        public void nameChange(string name) // 이름이 바뀌었을 때 처리할 함수
        {
            chatArea.Items.Add(cliName + "님이 " + name + "으로 변경하셨습니다");
            cliName = name;
        }


        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (isConn == false) // 접속이 안돼있으면 전송버튼 눌리지 않음
            {
                MessageBox.Show("클라이언트가 연결되지 않았습니다!");
                return;
            }
            string send_msg = server_name + " : " + chatMsg.Text ;
            byte[] chat = Encoding.UTF8.GetBytes(send_msg + "<eof>");
            int sendInt = client.Send(chat);
            chatMsg.Clear();

            chatArea.Items.Add(send_msg);


        }

        private void changeName_Click(object sender, EventArgs e)
        {
            string chName = myName.Text.ToString();
            byte[] chat = Encoding.UTF8.GetBytes(server_name + "님이 " + chName + "으로 변경하셨습니다<eof>");
            int sendInt = client.Send(chat);
            chatArea.Items.Add(server_name + "님이 " + chName + "으로 변경하셨습니다");
            server_name = chName;
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            byte[] chat = Encoding.UTF8.GetBytes("<exit>서버와의 연결이 끊겼습니다<eof>");
            int sendInt = client.Send(chat);
            chatArea.Items.Add("서버를 닫았습니다");

            isConn = false;
            thread.Abort();
            Application.ExitThread();
            Application.Exit();
        }
    }
}
