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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Sneak() 
        {
            groupBoxhome.Visible = false;
            groupBoxLog.Visible = false;
            groupBoxQuetion.Visible = false;
            groupBoxThemes.Visible = false;
            groupBoxStudAns.Visible = false;
            groupBoxTeachers.Visible = false;
            groupBoxStudent.Visible = false;
            groupBoxHistory.Visible = false;
            groupBoxGroup.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "1")
            {
                groupBoxLog.Visible = false;
                loginToolStripMenuItem.Visible = false;
                themesToolStripMenuItem.Visible = true;
                homeToolStripMenuItem.Visible = true;
                studentsToolStripMenuItem.Visible = true;
                questionToolStripMenuItem.Visible = true;
            }
            if (textBoxLog.Text == "2")
            {
                groupBoxLog.Visible = false;
                loginToolStripMenuItem.Visible = false;
                homeToolStripMenuItem.Visible = true;
                //studentsToolStripMenuItem.Visible = true;
                studentToolStripMenuItem.Visible = true;
                ToolStripMenuItemHistory.Visible = true;
                //studenthistToolStripMenuItem.Visible = true;
                //ToolStripMenuItemHistory.Visible = true;
                teachersToolStripMenuItem.Visible = true;
                groupsToolStripMenuItem.Visible = true;
            }
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxStudAns.Visible = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxhome.Visible = true;
            
        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxThemes.Visible = true;
            
        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxQuetion.Visible = true;
        }

       
        private void buttonThemeAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonQuestionAdd_Click(object sender, EventArgs e)
        {
            FormAddQue form = new FormAddQue();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonThemeAdd_Click_1(object sender, EventArgs e)
        {
            FormAddTheme form = new FormAddTheme();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxTeachers.Visible = true;
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxStudent.Visible = true;
        }

        private void ToolStripMenuItemHistory_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxHistory.Visible = true;
            comboBoxHistory.Items.Clear();
            comboBoxHistory.Items.Add("Student");
            comboBoxHistory.Items.Add("Teacher");
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sneak();
            groupBoxGroup.Visible = true;
        }
    }
}
