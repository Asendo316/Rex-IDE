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
using System.Diagnostics;

namespace Rex
{
    public partial class RexEditor : Form
    {
        public int maxLC = 1;
        Socket sck;
        EndPoint epLocal, epRemote;
        public RexEditor()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            localIp.Text = GetlocalIp();
            peerIp.Text=GetlocalIp();
        }
        private string GetlocalIp()
        {
            IPHostEntry  host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size= sck.EndReceiveFrom (aResult, ref epRemote);
                if (size>0)
                {
                    byte[] recievedData = new byte[1464];
                    recievedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recievedMessage = eEncoding.GetString(recievedData);
                    chatLog.Items.Add("Peer: "+recievedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch(Exception e)
            {

            }
        }

        #region Editor and General
        private void RexEditor_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region MainMenu
        private void file_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void file_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void file_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void file_Exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void edit_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void edit_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void edit_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void edit_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void edit_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void edit_SelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }
        
        private void Mm_Tools_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
         #endregion


        #region Toolbar
        private void tb_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tb_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {
            build.Enabled = true;
            stop.Enabled  = true;
            tb_Start.Enabled = true;
            Save();
        }

        private void tb_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void tb_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tb_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tb_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void tb_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void tb_Start_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileCompiler= new OpenFileDialog();
            fileCompiler.Title = "Select Class to Run";
            fileCompiler.Filter = "Class files|*.class";
            fileCompiler.InitialDirectory = @"C:\";
            if (fileCompiler.ShowDialog() == DialogResult.OK)
            {
                output.Visible = true;
                var onlyFileName = System.IO.Path.GetFileNameWithoutExtension(fileCompiler.FileName);
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow =false;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine("cd C:\\Users\\" + Environment.UserName.ToString() + "\\Documents");
                cmd.StandardInput.WriteLine("java "+ onlyFileName);
               // cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                string display = cmd.StandardOutput.ReadToEnd();
                output.Text = display;
                cmd.WaitForExit();
                
            }

        }
        private void build_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be sure to save your work before building");
            OpenFileDialog fileCompiler = new OpenFileDialog();
            fileCompiler.Title = "Select Class to Compile";
            fileCompiler.Filter = "Java files|*.java";
            fileCompiler.InitialDirectory = @"C:\Users\" + Environment.UserName.ToString() + "\\Documents";
            if (fileCompiler.ShowDialog() == DialogResult.OK)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = @"C:\WINDOWS\system32\cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine("cd C:\\Users\\" + Environment.UserName.ToString() + "\\Documents");
                cmd.StandardInput.WriteLine("javac " + fileCompiler.FileName);
                cmd.StandardInput.WriteLine("java " + fileCompiler.FileName);
                //cmd.StandardInput.Flush();
                //cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());

            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            output.Visible = false;
        }
        #endregion

        #region contextmenu

        private void rc_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void rc_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void rc_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void rc_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void rc_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void rc_Sketch_Click_1(object sender, EventArgs e)
        {

        }

        private void rc_Share_Click_1(object sender, EventArgs e)
        {

        }

        private void rc_About_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        #endregion

        #region Methods
        void New()
        {
            Document.Clear();
        }

        void Open()
        {

            OpenFileDialog fileOpener = new OpenFileDialog();
            fileOpener.Title = "Select Class";
            fileOpener.Filter = "Java files|*.java";
            fileOpener.InitialDirectory = @"C:\";
            if (fileOpener.ShowDialog() == DialogResult.OK)
             {
                 Document.LoadFile(fileOpener.FileName, RichTextBoxStreamType.PlainText);
             }
        }
        void Save()
        {
            if (saveWork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveFileDialog fileSaver = new SaveFileDialog();
                    fileSaver.Title = "Save File As";
                    fileSaver.Filter = "Java files|*.java";                                                                                
                    fileSaver.InitialDirectory = @"C:\Users\"+Environment.UserName.ToString()+"\\Documents";
                    if (fileSaver.ShowDialog() == DialogResult.OK)
                    {
                        Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Exit()
        {
            Application.Exit();
        }

        #endregion

        #region edit
        void Undo()
        {
            Document.Undo();
        }
        void Redo()
        {
            Document.Redo();
        }
        void Cut()
        {
            Document.Cut();
        }
        void Copy()
        {
            Document.Copy();
        }
        void Paste()
        {
            Document.Paste();
        }
        void SelectAll()
        {
            Document.SelectAll();
        }

        #endregion

        private void Document_KeyUp(object sender, KeyEventArgs e)
        {
            int linecount = Document.GetLineFromCharIndex(Document.TextLength) + 1;
            if(linecount != maxLC)
            {
                richTextBox1.Clear();
                for(int i = 1; i < linecount+1;i++)
                {
                    richTextBox1.AppendText(Convert.ToString(i)+"\n");
                }
                maxLC = linecount;
            }
        }

        private void Document_TextChanged(object sender, EventArgs e)
        {
            charCount.Text = "Characters in the current document: " + Document.TextLength.ToString();
            #region controlstructures
            this.CheckKeyword("while", Color.SteelBlue, 0);
            this.CheckKeyword("if", Color.SteelBlue, 0);
            this.CheckKeyword("true", Color.SteelBlue, 0);
            this.CheckKeyword("false", Color.SteelBlue, 0);
            this.CheckKeyword("else", Color.SteelBlue, 0);
            this.CheckKeyword("do", Color.SteelBlue, 0);
            this.CheckKeyword("switch", Color.SteelBlue, 0);
            this.CheckKeyword("case", Color.SteelBlue, 0);
            this.CheckKeyword("try", Color.SteelBlue, 0);
            this.CheckKeyword("catch", Color.SteelBlue, 0);
            this.CheckKeyword("finally", Color.SteelBlue, 0);
            this.CheckKeyword("break", Color.SteelBlue, 0);
            this.CheckKeyword("default", Color.SteelBlue, 0);
            this.CheckKeyword("public", Color.SteelBlue, 0);
            this.CheckKeyword("abstract", Color.SteelBlue , 0);
            this.CheckKeyword("boolean", Color.SteelBlue, 0);
            this.CheckKeyword("assert", Color.SteelBlue, 0);
            this.CheckKeyword("byte", Color.SteelBlue, 0);
            this.CheckKeyword("char", Color.SteelBlue, 0);
            this.CheckKeyword("class", Color.SteelBlue, 0);
            this.CheckKeyword("const", Color.SteelBlue, 0);
            this.CheckKeyword("continue", Color.SteelBlue, 0);
            this.CheckKeyword("default", Color.SteelBlue, 0);
            this.CheckKeyword("double", Color.SteelBlue, 0);
            this.CheckKeyword("enum", Color.SteelBlue, 0);
            this.CheckKeyword("extends", Color.SteelBlue, 0);
            this.CheckKeyword("final", Color.SteelBlue, 0);
            this.CheckKeyword("float", Color.SteelBlue, 0);
            this.CheckKeyword("for", Color.SteelBlue, 0);
            this.CheckKeyword("goto", Color.SteelBlue, 0);
            this.CheckKeyword("import", Color.SteelBlue, 0);
            this.CheckKeyword("static", Color.SteelBlue, 0);
            this.CheckKeyword("instanceof", Color.SteelBlue, 0);
            this.CheckKeyword("int", Color.SteelBlue, 0);
            this.CheckKeyword("char", Color.SteelBlue, 0);
            this.CheckKeyword("implements", Color.SteelBlue, 0);
            this.CheckKeyword("long", Color.SteelBlue, 0);
            this.CheckKeyword("native", Color.SteelBlue, 0);
            this.CheckKeyword("new", Color.SteelBlue, 0);
            this.CheckKeyword("package", Color.SteelBlue, 0);
            this.CheckKeyword("private", Color.SteelBlue, 0);
            this.CheckKeyword("protected", Color.SteelBlue, 0);
            this.CheckKeyword("return", Color.SteelBlue, 0);
            this.CheckKeyword("short", Color.SteelBlue, 0);
            this.CheckKeyword("super", Color.SteelBlue, 0);
            this.CheckKeyword("this", Color.SteelBlue, 0);
            this.CheckKeyword("synchronized", Color.SteelBlue, 0);
            this.CheckKeyword("Class", Color.SteelBlue, 0);
            this.CheckKeyword("throw", Color.SteelBlue, 0);
            this.CheckKeyword("throws", Color.SteelBlue, 0);
            this.CheckKeyword("transient", Color.SteelBlue, 0);
            this.CheckKeyword("void", Color.SteelBlue, 0);
            this.CheckKeyword("volatile", Color.SteelBlue, 0);
            this.CheckKeyword("null", Color.SteelBlue, 0);
            this.CheckKeyword("System", Color.SteelBlue, 0);
            this.CheckKeyword("out", Color.SteelBlue, 0);
            this.CheckKeyword("println", Color.SteelBlue, 0);
            this.CheckKeyword("String", Color.SteelBlue, 0);
            this.CheckKeyword("Scanner", Color.SteelBlue, 0);
            this.CheckKeyword("next", Color.SteelBlue, 0);
            this.CheckKeyword("replace", Color.SteelBlue, 0);
            this.CheckKeyword("Contains", Color.SteelBlue, 0);
            this.CheckKeyword("main", Color.SteelBlue, 0);
            this.CheckKeyword("charAt", Color.SteelBlue, 0);
            this.CheckKeyword("reverse", Color.SteelBlue, 0);
            this.CheckKeyword("toString", Color.SteelBlue, 0);
            this.CheckKeyword("lenght", Color.SteelBlue, 0);
            this.CheckKeyword("Math", Color.SteelBlue, 0);
            this.CheckKeyword(";", Color.Red, 0);

            #endregion
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.Document.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.Document.SelectionStart;
                while((index = this.Document.Text.IndexOf(word, (index+1)))!=-1)
                {
                    this.Document.Select((index + startIndex), word.Length);
                    this.Document.SelectionColor = color;
                    this.Document.Select(selectStart, 0);
                    this.Document.SelectionColor = Color.White;
                }
            }
        }

        private void illustrator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MiniPaint.exe");
        }

        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.github.com");
        }

        private void skype_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Skype.exe");
        }

        private void send_Click(object sender, EventArgs e)
        {
            try 
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(message.Text);
                sck.Send(msg);
                chatLog.Items.Add("You: "+message.Text);
                message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(localIp.Text), Convert.ToInt32(localPort.Text));
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(peerIp.Text), Convert.ToInt32(peerPort.Text));
                sck.Connect(epRemote);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                connect.Text = "Connected";
                connect.Enabled = false;
                send.Enabled = true;
                message.Focus();

            }
            catch (Exception ex)
            {

            }
        }

    }
}
