using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using clientForm.Properties;
using System.Collections;

namespace clientForm
{

    public partial class Messenger : Form
    {
        private static List<string> chat = new List<string> { };
        TcpClient photoSocket = new TcpClient();
        UdpClient textSocket = new UdpClient();
        StreamReader sr;
        StreamWriter sw;
        UdpClient udpReceiver;
        IPEndPoint ip;
        Image bmp;
        Thread udp;
        string address;
        IPEndPoint recvIp;
        private bool isSend;
        private int count;
        private string Myname;
        private string passMessage;
        private string myIp;

        public Messenger()
        {
            InitializeComponent();
            ChatBox.Text = "";
            this.KeyPreview = true;
            reTryTcp.Enabled = false;
            count = 0;
            inputBox.Enabled = false;

            linkLabel1.Enabled = false;
            linkLabel1.Visible = true;
            linkLabel1.Text = "沒有圖片";
            sendImageButton.Enabled = false;
            ifade_Olustur();

        }
        static Hashtable ifadeler;
        public void ifade_Olustur()
        {
            ifadeler = new Hashtable(20);
            ifadeler.Add(":)", Resources.smile);
            ifadeler.Add(":|", Resources.expresionless);
            ifadeler.Add(":3", Resources.Kissing_face);
            ifadeler.Add(":X", Resources.whilte_eye);
            ifadeler.Add(":P", Resources.Tongue_Out_Emoji);
            ifadeler.Add(":O", Resources.surprised);
            ifadeler.Add(":(", Resources.verySad);
            ifadeler.Add("(:", Resources.Upside_Down_Face_Emoji);
            ifadeler.Add(":D", Resources.Smiling_Face_Emoji);
            ifadeler.Add(">D<", Resources.Smiling_Face_with_Tightly_Closed_eyes);
            ifadeler.Add("):P", Resources.Smirk_Face_Emoji);
            ifadeler.Add(">P<", Resources.Tongue_Out_Emoji_with_Tightly_Closed_Eyes);
            ifadeler.Add("O)O", Resources.Sunglasses_Emoji);
            ifadeler.Add("<3", Resources.Heart_Eyes_Emoji);
            ifadeler.Add("|3:", Resources.Thinking_Face_Emoji);
            ifadeler.Add("X:", Resources.veryAngry);
            ifadeler.Add("POOP", Resources.Poop_Emoji);
            ifadeler.Add(":E", Resources.Tears_of_Joy_Emoji);
            ifadeler.Add("ZZZ", Resources.Sleeping_Emoji);
            ifadeler.Add("3><", Resources.Hugging_Face_Emoji);
            ifadeler.Add("(OO3", Resources.OMG_Face_Emoji);

        }
        public void ifade_Ekle()
        {
            foreach (string ifade in ifadeler.Keys)
            {
                while (ChatBox.Text.Contains(ifade))
                {
                    int ind = ChatBox.Text.IndexOf(ifade);
                    ChatBox.Select(ind, ifade.Length);
                    Clipboard.SetImage((Image)ifadeler[ifade]);
                    ChatBox.Paste();
                }
            }
        }
        private void Messenger_Load(object sender, EventArgs e)
        {

        }

        delegate void PrintHandler(RichTextBox tb, string data);
        public static void Print(RichTextBox tb, string data)
        {
            //判斷這個TextBox的物件是否在同一個執行緒上
            if (tb.InvokeRequired)
            {
                //當InvokeRequired為true時，表示在不同的執行緒上，所以進行委派的動作!!
                PrintHandler ph = new PrintHandler(Print);
                tb.Invoke(ph, tb, data);
            }
            else
            {
                //表示在同一個執行緒上了，所以可以正常的呼叫到這個TextBox物件

                chat.Add(data);

                tb.AppendText(data);

                try
                {
                    foreach (string ifade in ifadeler.Keys)
                    {
                        while (tb.Text.Contains(ifade))
                        {
                            int ind = tb.Text.IndexOf(ifade);
                            tb.Select(ind, ifade.Length);
                            Clipboard.SetImage((Image)ifadeler[ifade]);
                            tb.Paste();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                data = String.Empty;
            }
        }
        private void isEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                passMessage = "(" + myIp + ")" + Myname + " : " + inputBox.Text + "\n";


                byte[] sendBuffer = Encoding.UTF8.GetBytes(passMessage);
                string result = Encoding.UTF8.GetString(sendBuffer);

                textSocket.Send(sendBuffer, sendBuffer.Length, ip);

                inputBox.Clear();

            }
        }


        private void isShift(object sender, KeyPressEventArgs e)
        {

        }

        private void joinChat_Click(object sender, EventArgs e)
        {
            char[] delimiter = { '/' };
            string get = Microsoft.VisualBasic.Interaction.InputBox("格式:ID/IP"
                , "輸入你的名字以及要連的IP位置", "吳承儒/192.168.1.102");
            try
            {
                string[] afterSplit = get.Split(delimiter);
                Myname = afterSplit[0];
                address = afterSplit[1];
                if (Myname != "" && address != "")
                {
                    InitNetwork();
                    joinChat.Enabled = false;
                    string helloMessage = "(" + myIp + ")" + Myname + " 加入聊天室..\n";
                    inputBox.Enabled = true;

                    Thread.Sleep(500);
                    byte[] sendBuffer = Encoding.UTF8.GetBytes(helloMessage);
                    string result = Encoding.UTF8.GetString(sendBuffer);

                    sendImageButton.Enabled = true;
                    textSocket.Send(sendBuffer, sendBuffer.Length, ip);

                }
            }
            catch { }
        }
        private void InitNetwork()
        {
            udpReceiver = new UdpClient();
            udpReceiver.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpReceiver.Client.Bind(new IPEndPoint(IPAddress.Any, 9487));

            ip = new IPEndPoint(IPAddress.Parse(address), 9487);
            try
            {
                photoSocket.Connect(address, 9487);
            }
            catch
            {
                MessageBox.Show("Server端未開啟TCP服務");
                reTryTcp.Enabled = true;
            }

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIp = ip.ToString();
                }
            }
            sw = new StreamWriter(photoSocket.GetStream());
            sw.WriteLine(Myname);
            sw.Flush();
            Thread.Sleep(100);
            sw.WriteLine(myIp);
            sw.Flush();

            udp = new Thread(new ThreadStart(recv));
            udp.SetApartmentState(ApartmentState.STA);
            udp.Start();

            BackgroundWorker tcpRecv = new BackgroundWorker();
            tcpRecv.WorkerReportsProgress = true;
            tcpRecv.WorkerSupportsCancellation = true;
            tcpRecv.DoWork += TcpRecv_DoWork;
            tcpRecv.ProgressChanged += TcpRecv_ProgressChanged;
            tcpRecv.RunWorkerCompleted += TcpRecv_RunWorkerCompleted;
            tcpRecv.RunWorkerAsync(photoSocket);


        }

        private void TcpRecv_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void TcpRecv_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void recv() //測試用Thread
        {
            UdpClient tempUdp = udpReceiver;
            while (true)
            {
                recvIp = new IPEndPoint(IPAddress.Any, 9487);
                byte[] recvBuffer = tempUdp.Receive(ref recvIp);
                string data = Encoding.UTF8.GetString(recvBuffer);
                Print(ChatBox, data);
            }
        }


        private void TcpRecv_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bkw = sender as BackgroundWorker;
            TcpClient tempTCP = e.Argument as TcpClient;
            byte[] recvImag;
            while (true)
            {

                NetworkStream ns = tempTCP.GetStream();
                StreamReader hisr = new StreamReader(ns);


                int senderBuffer = int.Parse(hisr.ReadLine());

                if (ns.CanRead)
                {
                    recvImag = new byte[senderBuffer];

                    int count = senderBuffer;
                    int read, offset = 0;

                    while (count > 0 && ((read = ns.Read(recvImag, offset, count))) > 0)
                    {
                        offset += read;
                        count -= read;
                    }
                    if (count != 0) throw new EndOfStreamException();
                    ns.Flush();



                    try
                    {
                        Image picture = byteArrayToImage(recvImag);
                        if (pictureBox1.Disposing)
                        {
                            pictureBox1.Dispose();
                        }
                        pictureBox1.Image = picture;
                        linkLabel1.Text = "別人的圖片";
                        linkLabel1.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("file decrypt fail");
                    }

                }
            }
        }


        private void sendImageButton_Click(object sender, EventArgs e)
        {
            openFile.Filter = "PNG (*.png)|*.png|點陣圖 (*.bmp)|*.bmp|JPEG (*.JPG)|*.JPG|" + "GIF(*.GIF)|*.GIF|All File(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);
                byte[] filebyte = new byte[fs.Length];


                bmp = new Bitmap(fs);
                filebyte = ImageToByte(bmp);
                pictureBox1.Image = byteArrayToImage(filebyte);
                fs.Close();
                ////////////////////////

                NetworkStream ns = photoSocket.GetStream();

                StreamWriter hisw = new StreamWriter(ns);
                string hello = "(" + myIp + ")" + Myname + " 傳送了一張圖片\n";

                hisw.WriteLine(Convert.ToString(filebyte.Length));
                hisw.Flush();

                ns.Write(filebyte, 0, filebyte.Length);




                byte[] sendBuffer = Encoding.UTF8.GetBytes(hello);
                textSocket.Send(sendBuffer, sendBuffer.Length, ip);


                ////////////////////////
                linkLabel1.Text = "你的圖片";
                linkLabel1.Enabled = true;
                linkLabel1.Visible = true;
            }
        }

        private void reconnected_tcp_click(object sender, EventArgs e)
        {

            try
            {
                photoSocket.Connect(address, 9487);
                reTryTcp.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Server端仍未開啟TCP服務");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG (*.png)|*.png|點陣圖 (*.bmp)|*.bmp|JPEG (*.JPG)|*.JPG|" + "GIF(*.GIF)|*.GIF|All File(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void schrollBar(object sender, EventArgs e)
        {
            ChatBox.SelectionStart = ChatBox.TextLength;
            // Scrolls the contents of the control to the current caret position.
            ChatBox.ScrollToCaret();
        }

        private void changeFocus(object sender, EventArgs e)
        {
            inputBox.Focus();
        }

        private void beforClosed(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("確定離開嗎?", "離開", MessageBoxButtons.OKCancel);
            try
            {
                if (result == DialogResult.OK)
                {
                    udpReceiver.Close();
                    udp.Abort(); //停止接受UDP
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch { }
        }
        bool isFlag = false;
        private void emojiFlag_Click(object sender, EventArgs e)
        {
            isFlag = !isFlag;
            if (isFlag)
            {
                emojiBox.Visible = true;
            }
            else
            {
                emojiBox.Visible = false;
            }
        }

        private void clickemoji(object sender, MouseEventArgs e)
        {
            int isClick;
            isClick = int.Parse(((PictureBox)(sender)).Tag.ToString());
            switch (isClick)
            {
                case 1:
                    inputBox.Text += ":)";
                    break;
                case 2:
                    inputBox.Text += ":3";
                    break;
                case 3:
                    inputBox.Text += ":|";
                    break;
                case 4:
                    inputBox.Text += ":O";
                    break;
                case 5:
                    inputBox.Text += ":P";
                    break;
                case 6:
                    inputBox.Text += ":(";
                    break;
                case 7:
                    inputBox.Text += ":X";
                    break;
                case 8:
                    inputBox.Text += "(:";
                    break;
                case 9:
                    inputBox.Text += ":D";
                    break;
                case 10:
                    inputBox.Text += ">D<";
                    break;
                case 11:
                    inputBox.Text += "):P";
                    break;
                case 12:
                    inputBox.Text += ">P<";
                    break;
                case 13:
                    inputBox.Text += "O)O";
                    break;
                case 14:
                    inputBox.Text += "<3";
                    break;
                case 15:
                    inputBox.Text += "|3:";
                    break;
                case 16:
                    inputBox.Text += "X:";
                    break;
                case 17:
                    inputBox.Text += "POOP";
                    break;
                case 18:
                    inputBox.Text += ":E";
                    break;
                case 19:
                    inputBox.Text += "ZZZ";
                    break;
                case 20:
                    inputBox.Text += "3><";
                    break;
                case 21:
                    inputBox.Text += "(OO3";
                    break;
                default:
                    break;
            }

        }
    }
}
