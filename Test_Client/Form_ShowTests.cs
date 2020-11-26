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
    public partial class Form_ShowTests : Form
    {
        User user;
        bool flag = true;

       

        //33101 - load tests
        public Form_ShowTests()
        {
            InitializeComponent();

        }

        public Form_ShowTests(User _user)
        {
            InitializeComponent();

            this.user = _user;
        }

        private void btn_LoadTest_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = user.Tests;
        }

    

    }
}
