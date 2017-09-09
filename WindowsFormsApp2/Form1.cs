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
    public partial class Form1 : Form
    {
        jiaowudataEntities mydb = new jiaowudataEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = textBox1.Text;
            var code = textBox2.Text;
            var xs = mydb.学生表.Any(x => x.姓名 == user && x.密码 == code);
            if (xs)
            {
                Form2 FormMain = new Form2();
                FormMain.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var user = textBox1.Text;
                var code = textBox2.Text;
                var xs = mydb.学生表.Any(x => x.姓名 == user && x.密码 == code);
                if (xs)
                {
                    Form2 FormMain = new Form2();
                    FormMain.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
        }
    }
}
