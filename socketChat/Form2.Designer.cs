namespace socketChat
{
    partial class serverForm
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
            this.IPlb = new System.Windows.Forms.TextBox();
            this.portLb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.makeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.chatMsg = new System.Windows.Forms.TextBox();
            this.myName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.changeName = new System.Windows.Forms.Button();
            this.chatArea = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IPlb
            // 
            this.IPlb.Location = new System.Drawing.Point(65, 42);
            this.IPlb.Name = "IPlb";
            this.IPlb.ReadOnly = true;
            this.IPlb.Size = new System.Drawing.Size(156, 21);
            this.IPlb.TabIndex = 0;
            // 
            // portLb
            // 
            this.portLb.Location = new System.Drawing.Point(65, 79);
            this.portLb.Name = "portLb";
            this.portLb.Size = new System.Drawing.Size(156, 21);
            this.portLb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(143, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "채팅방 정보";
            // 
            // makeBtn
            // 
            this.makeBtn.Location = new System.Drawing.Point(227, 42);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(65, 58);
            this.makeBtn.TabIndex = 5;
            this.makeBtn.Text = "열기";
            this.makeBtn.UseVisualStyleBackColor = true;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(298, 42);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(65, 58);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "닫기";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // chatMsg
            // 
            this.chatMsg.Location = new System.Drawing.Point(15, 464);
            this.chatMsg.Name = "chatMsg";
            this.chatMsg.Size = new System.Drawing.Size(277, 21);
            this.chatMsg.TabIndex = 7;
            // 
            // myName
            // 
            this.myName.Location = new System.Drawing.Point(65, 129);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(227, 21);
            this.myName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "내 이름";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(298, 463);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(65, 23);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "전송";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // changeName
            // 
            this.changeName.Location = new System.Drawing.Point(298, 129);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(65, 21);
            this.changeName.TabIndex = 12;
            this.changeName.Text = "변경";
            this.changeName.UseVisualStyleBackColor = true;
            this.changeName.Click += new System.EventHandler(this.changeName_Click);
            // 
            // chatArea
            // 
            this.chatArea.FormattingEnabled = true;
            this.chatArea.ItemHeight = 12;
            this.chatArea.Location = new System.Drawing.Point(15, 156);
            this.chatArea.Name = "chatArea";
            this.chatArea.Size = new System.Drawing.Size(348, 292);
            this.chatArea.TabIndex = 13;
            // 
            // serverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 507);
            this.Controls.Add(this.chatArea);
            this.Controls.Add(this.changeName);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.chatMsg);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.makeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portLb);
            this.Controls.Add(this.IPlb);
            this.Name = "serverForm";
            this.Text = "채팅서버";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPlb;
        private System.Windows.Forms.TextBox portLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button makeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox chatMsg;
        private System.Windows.Forms.TextBox myName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button changeName;
        private System.Windows.Forms.ListBox chatArea;
    }
}