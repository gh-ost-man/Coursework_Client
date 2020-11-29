using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Client
{
    public partial class Form_Test : Form
    {
        TreeGedaLib.Test test;
        TreeGedaLib.User currentUser;

        int cnt = 0;

        int indexQ = 0;
        int indexA = 0;
        
        int hour = 0;
        int minute = 0;
        int sec = 0;

        List<TreeGedaLib.UserAnswer> userAnswers = new List<TreeGedaLib.UserAnswer>();

        DateTime dt = DateTime.Now.Date;



        public Form_Test()
        {
            InitializeComponent();
        }

        public Form_Test(TreeGedaLib.Test _test,TreeGedaLib.User _user,List<TreeGedaLib.UserAnswer> uA)
        {
            InitializeComponent();
            this.test = _test;
            currentUser = _user;

            userAnswers = uA;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int n = cnt;

            if ((n + 1) == test.Questions.Count)
            {
                btn_Next.Enabled = false;

                if (!CheckAnswer(flowLayoutPanel1))
                {
                    MessageBox.Show("select the answer");
                    return;
                }

                TreeGedaLib.UserAnswer a = new TreeGedaLib.UserAnswer();
                a.Id = test.Questions[indexQ].Answers[indexA].Id;
                a.Answer = test.Questions[indexQ].Answers[indexA];
                a.User = currentUser;
                a.Date = DateTime.Now;
                a.DT_Start = DateTime.Now;
                a.DT_End = DateTime.Now;
                userAnswers.Add(a);


                this.DialogResult = DialogResult.OK;
                return;
            }


            if (!CheckAnswer(flowLayoutPanel1))
            {
                MessageBox.Show("select the answer");
                return;
            }

            flowLayoutPanel1.Controls.Clear();

            TreeGedaLib.UserAnswer answer = new TreeGedaLib.UserAnswer();
            answer.Id = test.Questions[indexQ].Answers[indexA].Id;
            answer.Answer = test.Questions[indexQ].Answers[indexA];
            answer.User = currentUser;
            answer.Date = DateTime.Now;
            answer.DT_Start = DateTime.Now;
            answer.DT_End = DateTime.Now;
            answer.IdTest = test.Id;
            userAnswers.Add(answer);


            indexQ++;

            cnt++;

            n = cnt;

            groupBox_Test.Text = (n + 1).ToString() + " || " + test.Questions.Count.ToString();

            textBox1.Text = test.Questions[indexQ].Title;

            foreach (var item in test.Questions[indexQ].Answers)
            {
                RadioButton radio = new RadioButton();
                radio.Text = item.Description;
                flowLayoutPanel1.Controls.Add(radio);
            }

        }

        private bool CheckAnswer(FlowLayoutPanel panel)
        {
            bool flag = false;
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if ((flowLayoutPanel1.Controls[i] as RadioButton).Checked)
                {
                    flag = true;
                    indexA = i;
                }
            }
                

            return flag;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec==60)
            {
                minute++;
                if(minute==60)
                {
                    hour++;
                    minute = 0;
                }
                sec = 0;
            }

            if(hour==test.Time.Hours && minute==test.Time.Minutes)
            {
                timer1.Stop();
                btn_Next.Enabled = false;
                this.DialogResult = DialogResult.OK;
            }

            label1.Text = $"{hour} : {minute} : {sec}";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();

            groupBox_Test.Text = (cnt + 1).ToString() + " || " + test.Questions.Count.ToString();

            dt.AddHours(test.Time.Hours);
            dt.AddMinutes(test.Time.Minutes);  

            textBox1.Text = test.Questions[0].Title;
            foreach (var item in test.Questions[0].Answers)
            {
                RadioButton radio = new RadioButton();
                radio.Text = item.Description;
                flowLayoutPanel1.Controls.Add(radio);
            }

            btn_Start.Enabled = false;
        }

        private void Form_Test_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
