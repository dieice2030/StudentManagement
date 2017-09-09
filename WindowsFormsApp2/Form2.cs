using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 xsb = new Form3();
            xsb.MdiParent = this;
            xsb.Show();
        }
    }
}
