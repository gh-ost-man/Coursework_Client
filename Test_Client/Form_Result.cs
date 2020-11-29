using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Client
{
    public partial class Form_Result : Form
    {
        TreeGedaLib.Result result;
        public Form_Result()
        {
            InitializeComponent();
        }
        public Form_Result(TreeGedaLib.Result res)
        {
            InitializeComponent();

            result = res;

            textBox_TestName.Text = result.TestNme;
            textBox_Mark.Text = result.Mark.ToString();
            textBox_Qty.Text = result.QtyRightAnswers.ToString();
        }

    }
}
