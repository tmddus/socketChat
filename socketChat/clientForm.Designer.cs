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
            this.label1.Location = new System.Drawing.Point(152, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "접속 채팅방 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT";
            // 
            // IPLb
            // 
            this.IPLb.Location = new System.Drawing.Point(70, 59);
            this.IPLb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IPLb.Name = "IPLb";
            this.IPLb.Size = new System.Drawing.Size(170, 25);
            this.IPLb.TabIndex = 3;
            // 
            // PortLb
            // 
            this.PortLb.Location = new System.Drawing.Point(70, 96);
            this.PortLb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortLb.Name = "PortLb";
            this.PortLb.Size = new System.Drawing.Size(170, 25);
            this.PortLb.TabIndex = 4;
            // 
            // conBtn
            // 
            this.conBtn.Location = new System.Drawing.Point(259, 56);
            this.conBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(86, 66);
            this.conBtn.TabIndex = 5;
            this.conBtn.Text = "연결";
            this.conBtn.UseVisualStyleBackColor = true;
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(352, 56);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(86, 66);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "종료";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // chatMsg
            // 
            this.chatMsg.Location = new System.Drawing.Point(16, 590);
            this.chatMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatMsg.Name = "chatMsg";
            this.chatMsg.Size = new System.Drawing.Size(329, 25);
            this.chatMsg.TabIndex = 8;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(352, 588);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(78, 29);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "전송";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(70, 158);
            this.myIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.myIP.Name = "myIP";
            this.myIP.ReadOnly = true;
            this.myIP.Size = new System.Drawing.Size(258, 25);
            this.myIP.TabIndex = 10;
            // 
            // myName
            // 
            this.myName.Location = new System.Drawing.Point(70, 200);
            this.myName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(258, 25);
            this.myName.TabIndex = 11;
            // 
            // changeName
            // 
            this.changeName.Location = new System.Drawing.Point(344, 200);
            this.changeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(86, 29);
            this.changeName.TabIndex = 12;
            this.changeName.Text = "변경";
            this.changeName.UseVisualStyleBackColor = true;
            this.changeName.Click += new System.EventHandler(this.changeName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "내 IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "이름";
            // 
            // chatArea
            // 
            this.chatArea.FormattingEnabled = true;
            this.chatArea.ItemHeight = 15;
            this.chatArea.Location = new System.Drawing.Point(16, 234);
            this.chatArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatArea.Name = "chatArea";
            this.chatArea.Size = new System.Drawing.Size(413, 334);
            this.chatArea.TabIndex = 15;
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 634);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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