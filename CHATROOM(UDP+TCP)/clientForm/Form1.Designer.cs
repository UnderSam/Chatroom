namespace clientForm
{
    partial class Messenger
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.joinChat = new System.Windows.Forms.Button();
            this.reTryTcp = new System.Windows.Forms.Button();
            this.sendImageButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.emojiFlag = new System.Windows.Forms.Button();
            this.emojiBox = new System.Windows.Forms.GroupBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.emoji7 = new System.Windows.Forms.PictureBox();
            this.emoji2 = new System.Windows.Forms.PictureBox();
            this.emoji1 = new System.Windows.Forms.PictureBox();
            this.emoji4 = new System.Windows.Forms.PictureBox();
            this.emoji3 = new System.Windows.Forms.PictureBox();
            this.emoji6 = new System.Windows.Forms.PictureBox();
            this.emoji5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emojiBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputBox.Location = new System.Drawing.Point(11, 724);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(801, 51);
            this.inputBox.TabIndex = 1;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isEnter);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isShift);
            // 
            // joinChat
            // 
            this.joinChat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.joinChat.Location = new System.Drawing.Point(844, 13);
            this.joinChat.Name = "joinChat";
            this.joinChat.Size = new System.Drawing.Size(139, 119);
            this.joinChat.TabIndex = 2;
            this.joinChat.Text = "加入聊天";
            this.joinChat.UseVisualStyleBackColor = true;
            this.joinChat.Click += new System.EventHandler(this.joinChat_Click);
            // 
            // reTryTcp
            // 
            this.reTryTcp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reTryTcp.Location = new System.Drawing.Point(844, 183);
            this.reTryTcp.Name = "reTryTcp";
            this.reTryTcp.Size = new System.Drawing.Size(139, 125);
            this.reTryTcp.TabIndex = 3;
            this.reTryTcp.Text = "重試TCP連線";
            this.reTryTcp.UseVisualStyleBackColor = true;
            this.reTryTcp.Click += new System.EventHandler(this.reconnected_tcp_click);
            // 
            // sendImageButton
            // 
            this.sendImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendImageButton.Location = new System.Drawing.Point(844, 345);
            this.sendImageButton.Name = "sendImageButton";
            this.sendImageButton.Size = new System.Drawing.Size(139, 119);
            this.sendImageButton.TabIndex = 5;
            this.sendImageButton.Text = "傳送圖片";
            this.sendImageButton.UseVisualStyleBackColor = true;
            this.sendImageButton.Click += new System.EventHandler(this.sendImageButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Title = "開檔";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(838, 615);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 32);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // ChatBox
            // 
            this.ChatBox.Cursor = System.Windows.Forms.Cursors.No;
            this.ChatBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChatBox.Location = new System.Drawing.Point(12, 12);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(800, 647);
            this.ChatBox.TabIndex = 9;
            this.ChatBox.Text = "";
            this.ChatBox.Click += new System.EventHandler(this.changeFocus);
            this.ChatBox.TextChanged += new System.EventHandler(this.schrollBar);
            // 
            // emojiFlag
            // 
            this.emojiFlag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emojiFlag.Location = new System.Drawing.Point(11, 681);
            this.emojiFlag.Name = "emojiFlag";
            this.emojiFlag.Size = new System.Drawing.Size(139, 37);
            this.emojiFlag.TabIndex = 10;
            this.emojiFlag.Text = "表情符號";
            this.emojiFlag.UseVisualStyleBackColor = true;
            this.emojiFlag.Click += new System.EventHandler(this.emojiFlag_Click);
            // 
            // emojiBox
            // 
            this.emojiBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emojiBox.Controls.Add(this.pictureBox9);
            this.emojiBox.Controls.Add(this.pictureBox10);
            this.emojiBox.Controls.Add(this.pictureBox11);
            this.emojiBox.Controls.Add(this.pictureBox12);
            this.emojiBox.Controls.Add(this.pictureBox13);
            this.emojiBox.Controls.Add(this.pictureBox14);
            this.emojiBox.Controls.Add(this.pictureBox15);
            this.emojiBox.Controls.Add(this.pictureBox2);
            this.emojiBox.Controls.Add(this.pictureBox3);
            this.emojiBox.Controls.Add(this.pictureBox4);
            this.emojiBox.Controls.Add(this.pictureBox5);
            this.emojiBox.Controls.Add(this.pictureBox6);
            this.emojiBox.Controls.Add(this.pictureBox7);
            this.emojiBox.Controls.Add(this.pictureBox8);
            this.emojiBox.Controls.Add(this.emoji7);
            this.emojiBox.Controls.Add(this.emoji2);
            this.emojiBox.Controls.Add(this.emoji1);
            this.emojiBox.Controls.Add(this.emoji4);
            this.emojiBox.Controls.Add(this.emoji3);
            this.emojiBox.Controls.Add(this.emoji6);
            this.emojiBox.Controls.Add(this.emoji5);
            this.emojiBox.Location = new System.Drawing.Point(12, 423);
            this.emojiBox.Name = "emojiBox";
            this.emojiBox.Size = new System.Drawing.Size(506, 252);
            this.emojiBox.TabIndex = 18;
            this.emojiBox.TabStop = false;
            this.emojiBox.Text = "表情符號";
            this.emojiBox.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::clientForm.Properties.Resources.OMG_Face_Emoji;
            this.pictureBox9.Location = new System.Drawing.Point(435, 194);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(43, 42);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "21";
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::clientForm.Properties.Resources.veryAngry;
            this.pictureBox10.Location = new System.Drawing.Point(84, 194);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(43, 42);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "16";
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::clientForm.Properties.Resources.Thinking_Face_Emoji;
            this.pictureBox11.Location = new System.Drawing.Point(17, 194);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(43, 42);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "15";
            this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::clientForm.Properties.Resources.Tears_of_Joy_Emoji;
            this.pictureBox12.Location = new System.Drawing.Point(223, 194);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(43, 42);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 28;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "18";
            this.pictureBox12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Image = global::clientForm.Properties.Resources.Poop_Emoji;
            this.pictureBox13.Location = new System.Drawing.Point(156, 194);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(43, 42);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 27;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "17";
            this.pictureBox13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox14.Image = global::clientForm.Properties.Resources.Hugging_Face_Emoji;
            this.pictureBox14.Location = new System.Drawing.Point(365, 194);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(43, 42);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 30;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "20";
            this.pictureBox14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = global::clientForm.Properties.Resources.Sleeping_Emoji;
            this.pictureBox15.Location = new System.Drawing.Point(295, 194);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(43, 42);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 29;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "19";
            this.pictureBox15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::clientForm.Properties.Resources.Heart_Eyes_Emoji;
            this.pictureBox2.Location = new System.Drawing.Point(435, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "14";
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::clientForm.Properties.Resources.Smiling_Face_Emoji;
            this.pictureBox3.Location = new System.Drawing.Point(84, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "9";
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::clientForm.Properties.Resources.Upside_Down_Face_Emoji;
            this.pictureBox4.Location = new System.Drawing.Point(17, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "8";
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::clientForm.Properties.Resources.Smirk_Face_Emoji;
            this.pictureBox5.Location = new System.Drawing.Point(223, 116);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "11";
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::clientForm.Properties.Resources.Smiling_Face_with_Tightly_Closed_eyes;
            this.pictureBox6.Location = new System.Drawing.Point(156, 116);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "10";
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::clientForm.Properties.Resources.Sunglasses_Emoji;
            this.pictureBox7.Location = new System.Drawing.Point(365, 116);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(43, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "13";
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::clientForm.Properties.Resources.Tongue_Out_Emoji_with_Tightly_Closed_Eyes;
            this.pictureBox8.Location = new System.Drawing.Point(295, 116);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(43, 42);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "12";
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // emoji7
            // 
            this.emoji7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emoji7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji7.Image = global::clientForm.Properties.Resources.whilte_eye;
            this.emoji7.Location = new System.Drawing.Point(435, 37);
            this.emoji7.Name = "emoji7";
            this.emoji7.Size = new System.Drawing.Size(43, 42);
            this.emoji7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji7.TabIndex = 17;
            this.emoji7.TabStop = false;
            this.emoji7.Tag = "7";
            this.emoji7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // emoji2
            // 
            this.emoji2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emoji2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji2.Image = global::clientForm.Properties.Resources.Kissing_face;
            this.emoji2.Location = new System.Drawing.Point(84, 37);
            this.emoji2.Name = "emoji2";
            this.emoji2.Size = new System.Drawing.Size(43, 42);
            this.emoji2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji2.TabIndex = 12;
            this.emoji2.TabStop = false;
            this.emoji2.Tag = "2";
            this.emoji2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // emoji1
            // 
            this.emoji1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emoji1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji1.Image = global::clientForm.Properties.Resources.smile;
            this.emoji1.Location = new System.Drawing.Point(17, 37);
            this.emoji1.Name = "emoji1";
            this.emoji1.Size = new System.Drawing.Size(43, 42);
            this.emoji1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji1.TabIndex = 11;
            this.emoji1.TabStop = false;
            this.emoji1.Tag = "1";
            this.emoji1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // emoji4
            // 
            this.emoji4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emoji4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji4.Image = global::clientForm.Properties.Resources.surprised;
            this.emoji4.Location = new System.Drawing.Point(223, 37);
            this.emoji4.Name = "emoji4";
            this.emoji4.Size = new System.Drawing.Size(43, 42);
            this.emoji4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji4.TabIndex = 14;
            this.emoji4.TabStop = false;
            this.emoji4.Tag = "4";
            this.emoji4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // emoji3
            // 
            this.emoji3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emoji3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji3.Image = global::clientForm.Properties.Resources.expresionless;
            this.emoji3.Location = new System.Drawing.Point(156, 37);
            this.emoji3.Name = "emoji3";
            this.emoji3.Size = new System.Drawing.Size(43, 42);
            this.emoji3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji3.TabIndex = 13;
            this.emoji3.TabStop = false;
            this.emoji3.Tag = "3";
            this.emoji3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // emoji6
            // 
            this.emoji6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emoji6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji6.Image = global::clientForm.Properties.Resources.verySad;
            this.emoji6.Location = new System.Drawing.Point(365, 37);
            this.emoji6.Name = "emoji6";
            this.emoji6.Size = new System.Drawing.Size(43, 42);
            this.emoji6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji6.TabIndex = 16;
            this.emoji6.TabStop = false;
            this.emoji6.Tag = "6";
            this.emoji6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // emoji5
            // 
            this.emoji5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emoji5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emoji5.Image = global::clientForm.Properties.Resources.Tongue_Out_Emoji;
            this.emoji5.Location = new System.Drawing.Point(295, 37);
            this.emoji5.Name = "emoji5";
            this.emoji5.Size = new System.Drawing.Size(43, 42);
            this.emoji5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji5.TabIndex = 15;
            this.emoji5.TabStop = false;
            this.emoji5.Tag = "5";
            this.emoji5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickemoji);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(836, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 863);
            this.Controls.Add(this.emojiBox);
            this.Controls.Add(this.emojiFlag);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendImageButton);
            this.Controls.Add(this.reTryTcp);
            this.Controls.Add(this.joinChat);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.ChatBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Messenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.beforClosed);
            this.Load += new System.EventHandler(this.Messenger_Load);
            this.emojiBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button joinChat;
        private System.Windows.Forms.Button reTryTcp;
        private System.Windows.Forms.Button sendImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button emojiFlag;
        private System.Windows.Forms.PictureBox emoji1;
        private System.Windows.Forms.PictureBox emoji2;
        private System.Windows.Forms.PictureBox emoji3;
        private System.Windows.Forms.PictureBox emoji4;
        private System.Windows.Forms.PictureBox emoji5;
        private System.Windows.Forms.PictureBox emoji6;
        private System.Windows.Forms.PictureBox emoji7;
        private System.Windows.Forms.GroupBox emojiBox;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

