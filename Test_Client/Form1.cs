using DALServerDB;
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

namespace Test_Client
{
    public partial class Form1 : Form
    {
        int portSend = 5556;
        int portRecive = 5555;

        TreeGedaLib.User user;

        TcpClient clientTcp = null;
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();

            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(localAddr, portRecive);
            server.Start();

            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    byte[] buff = new byte[1024];
                    MemoryStream ms = new MemoryStream();

                    do
                    {
                        int bytes = stream.Read(buff, 0, buff.Length);
                        ms.Append(buff);
                    }
                    while (stream.DataAvailable);


                    var binForm = new BinaryFormatter();
                    ms.Position = 0;
                    user = (TreeGedaLib.User)binForm.Deserialize(ms);

                    ms.Close();

                    if (user.Id > 0)
                    {
                        TreeGedaLib.User uu = user;

                        Form_Main main = new Form_Main(uu);
                        Invoke(new Action(() => { this.Hide(); }));
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                        btn_SignIn.Invoke(new Action(() => { btn_SignIn.Enabled = true; }));
                    }

                }
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Login.Text) || String.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("Enter login and password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            clientTcp = new TcpClient();
            clientTcp.Connect("localhost", portSend);
            stream = clientTcp.GetStream();

            TreeGedaLib.User u = new TreeGedaLib.User();
            u.Login = textBox_Login.Text;
            u.Password = textBox_Password.Text;

            byte[] data;


            using (var ms = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                binForm.Serialize(ms, u);

                data = ms.ToArray();
            }


            stream.Write(data, 0, data.Length);
            stream.Close();
            btn_SignIn.Enabled = false;

        }
    }
}
