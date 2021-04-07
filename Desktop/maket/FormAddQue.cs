using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maket
{
    public partial class FormAddQue : Form
    {
        bool IsTest = true;
        public FormAddQue()
        {
            InitializeComponent();
        }

        public FormAddQue(bool wideQua)
        {
            InitializeComponent();
            IsTest = wideQua;
        }

        private void FormAddQue_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCorAns.Enabled = false;
            buttonCorAns.Enabled = false;
        }

        private void buttonWrAns_Click(object sender, EventArgs e)
        {
            if (!IsTest) 
            { 
            textBoxWrAns.Enabled = false;
            buttonWrAns.Enabled = false;
            }
        }
    }
}
