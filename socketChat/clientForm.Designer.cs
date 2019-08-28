namespace socketChat
{
    partial class clientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IPLb = new System.Windows.Forms.TextBox();
            this.PortLb = new System.Windows.Forms.TextBox();
            this.conBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.chatMsg = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.myIP = new System.Windows.Forms.TextBox();
            this.myName = new System.Windows.Forms.TextBox();
            this.changeName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chatArea = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "접속 채팅방 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT";
            // 
            // IPLb
            // 
            this.IPLb.Location = new System.Drawing.Point(61, 47);
            this.IPLb.Name = "IPLb";
            this.IPLb.Size = new System.Drawing.Size(149, 21);
            this.IPLb.TabIndex = 3;
            // 
            // PortLb
            // 
            this.PortLb.Location = new System.Drawing.Point(61, 77);
            this.PortLb.Name = "PortLb";
            this.PortLb.Size = new System.Drawing.Size(149, 21);
            this.PortLb.TabIndex = 4;
            // 
            // conBtn
            // 
            this.conBtn.Location = new System.Drawing.Point(227, 45);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(75, 53);
            this.conBtn.TabIndex = 5;
            this.conBtn.Text = "연결";
            this.conBtn.UseVisualStyleBackColor = true;
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(308, 45);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 53);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "종료";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // chatMsg
            // 
            this.chatMsg.Location = new System.Drawing.Point(14, 472);
            this.chatMsg.Name = "chatMsg";
            this.chatMsg.Size = new System.Drawing.Size(288, 21);
            this.chatMsg.TabIndex = 8;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(308, 470);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(68, 23);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "전송";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(61, 126);
            this.myIP.Name = "myIP";
            this.myIP.ReadOnly = true;
            this.myIP.Size = new System.Drawing.Size(226, 21);
            this.myIP.TabIndex = 10;
            // 
            // myName
            // 
            this.myName.Location = new System.Drawing.Point(61, 160);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(226, 21);
            this.myName.TabIndex = 11;
            // 
            // changeName
            // 
            this.changeName.Location = new System.Drawing.Point(301, 160);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(75, 23);
            this.changeName.TabIndex = 12;
            this.changeName.Text = "변경";
            this.changeName.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "내 IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "이름";
            // 
            // chatArea
            // 
            this.chatArea.FormattingEnabled = true;
            this.chatArea.ItemHeight = 12;
            this.chatArea.Location = new System.Drawing.Point(14, 187);
            this.chatArea.Name = "chatArea";
            this.chatArea.Size = new System.Drawing.Size(362, 268);
            this.chatArea.TabIndex = 15;
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 507);
            this.Controls.Add(this.chatArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changeName);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.myIP);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chatMsg);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.conBtn);
            this.Controls.Add(this.PortLb);
            this.Controls.Add(this.IPLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "clientForm";
            this.Text = "채팅 클라이언트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPLb;
        private System.Windows.Forms.TextBox PortLb;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox chatMsg;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox myIP;
        private System.Windows.Forms.TextBox myName;
        private System.Windows.Forms.Button changeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox chatArea;
    }
}