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
    public partial class Form_ShowTests : Form
    {
        TreeGedaLib.User currentUser;

        List<TreeGedaLib.Test> tests = new List<TreeGedaLib.Test>();

        int portSend = 5557;
        int portRecive = 5558;

        int portSendRes = 5559;
        int portReciveRes = 5560;

        TcpClient clientTcp = null;
        NetworkStream stream;

        IPAddress localAddr = IPAddress.Parse("127.0.0.1");
        TcpListener server;
        TcpListener server2;

        public Form_ShowTests()
        {
            InitializeComponent();
        }

        public Form_ShowTests(TreeGedaLib.User _user)
        {
            InitializeComponent();
            currentUser = _user;

            server = new TcpListener(localAddr, portRecive);
            server.Start();
            server2 = new TcpListener(localAddr, portReciveRes);
            server2.Start();

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

                    tests = (List<TreeGedaLib.Test>)binForm.Deserialize(ms);

                    ms.Close();

                    if (tests.Count != 0)
                    {
                        dataGridView1.Invoke(new Action(() =>
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = tests;
                        }));
                    }


                }
            });


            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = server2.AcceptTcpClient();
                    NetworkStream s = client.GetStream();

                    byte[] buff = new byte[1024];
                    MemoryStream ms = new MemoryStream();

                    do
                    {
                        int bytes = s.Read(buff, 0, buff.Length);
                        ms.Append(buff);
                    }
                    while (s.DataAvailable);


                    var binForm = new BinaryFormatter();
                    ms.Position = 0;

                    var result = (TreeGedaLib.Result)binForm.Deserialize(ms);

                    Form_Result formREs = new Form_Result(result);
                    formREs.ShowDialog();
                }
            });
        }

        private void btn_LoadTest_Click(object sender, EventArgs e)
        {
            clientTcp = new TcpClient();
            clientTcp.Connect("localhost", portSend);
            stream = clientTcp.GetStream();

            byte[] data;

            using (var ms = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                binForm.Serialize(ms, currentUser);

                data = ms.ToArray();
            }


            stream.Write(data, 0, data.Length);
            stream.Close();
        }

        private void btn_PassTest_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;

            TreeGedaLib.Test test = tests[dataGridView1.CurrentRow.Index];

            List<TreeGedaLib.UserAnswer> userAnswers = new List<TreeGedaLib.UserAnswer>();
            Form_Test form = new Form_Test(test, currentUser, userAnswers);

            if (form.ShowDialog() == DialogResult.OK)
            {

                TcpClient c = null;
                NetworkStream s;

                c = new TcpClient();
                c.Connect("localhost", portSendRes);
                s = c.GetStream();

                byte[] data;


                using (var ms = new MemoryStream())
                {
                    var binForm = new BinaryFormatter();
                    binForm.Serialize(ms, userAnswers);

                    data = ms.ToArray();
                }


                s.Write(data, 0, data.Length);
                s.Close();
                this.Close();
            }
        }

        private void Form_ShowTests_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
