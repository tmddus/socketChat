namespace socketChat
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.joinChat = new System.Windows.Forms.Button();
            this.makeChat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // joinChat
            // 
            this.joinChat.BackgroundImage = global::socketChat.Properties.Resources.joinChatBtn;
            this.joinChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.joinChat.CausesValidation = false;
            this.joinChat.Location = new System.Drawing.Point(439, 342);
            this.joinChat.Name = "joinChat";
            this.joinChat.Size = new System.Drawing.Size(215, 63);
            this.joinChat.TabIndex = 2;
            this.joinChat.UseVisualStyleBackColor = true;
            this.joinChat.Click += new System.EventHandler(this.joinChat_Click);
            // 
            // makeChat
            // 
            this.makeChat.BackgroundImage = global::socketChat.Properties.Resources.makechatBtn;
            this.makeChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makeChat.CausesValidation = false;
            this.makeChat.Location = new System.Drawing.Point(100, 342);
            this.makeChat.Name = "makeChat";
            this.makeChat.Size = new System.Drawing.Size(215, 63);
            this.makeChat.TabIndex = 1;
            this.makeChat.UseVisualStyleBackColor = true;
            this.makeChat.Click += new System.EventHandler(this.makeChat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.joinChat);
            this.Controls.Add(this.makeChat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "소켓채팅프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button makeChat;
        private System.Windows.Forms.Button joinChat;
    }
}

