using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGedaLib;

namespace Test_Client
{
    public partial class Form1 : Form
    {

        User user;
        Socket sendSocket = null;
      
        bool flag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sendSocket.Connected || sendSocket == null) return;

                if (String.IsNullOrEmpty(textBox_Login.Text) || String.IsNullOrEmpty(textBox_Password.Text))
                {
                    MessageBox.Show("Enter login and password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Byte[] buff = new byte[1024];

                User user = new User();
                user.Login = textBox_Login.Text;
                user.Password = textBox_Password.Text;

                using (var ms = new MemoryStream())
                {
                    var binForm = new BinaryFormatter();
                    binForm.Serialize(ms, user);

                    buff = ms.ToArray();
                }

                Byte[] sendByte = new Byte[1024];
                sendSocket.Send(buff);

                Thread thread = new Thread(ReseiveServerMsg);
                thread.IsBackground = true;
                thread.Start(sendSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ReseiveServerMsg(Object sender)
        {
            while (flag)
            {
                Socket receiveSocket = sender as Socket;
                if (receiveSocket == null) throw new ArgumentException("Receive Socket Exception");
                Byte[] receiveByte = new Byte[1024];
                try
                {
                    Int32 nCount = receiveSocket.Receive(receiveByte);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        var bf = new BinaryFormatter();
                        ms.Write(receiveByte, 0, receiveByte.Length);
                        ms.Seek(0, SeekOrigin.Begin);

                        user = (User)bf.Deserialize(ms);

                        if (user.Id > 0)
                        {
                            flag = false;
                            Form_Main main = new Form_Main(user);
                            Invoke(new Action(() => { this.Hide(); }));
                            main.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("login or password is incorrect");
                        }
                    }
                }
                catch (SocketException se) { MessageBox.Show(se.Message); return; }

            }

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = ipHost.AddressList[1];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 33000);

            try
            {
                sendSocket.Connect(ipEndPoint);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
