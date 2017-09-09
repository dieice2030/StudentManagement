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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        学生表 currxs;
        public Form4(学生表 xs)
        {
            InitializeComponent();
            currxs = xs;
            textBox1.Text = currxs.学号;
            textBox2.Text = currxs.姓名;
            textBox3.Text = currxs.性别;
            textBox4.Text = currxs.班级;
            textBox5.Text = currxs.通信地址;
            textBox6.Text = currxs.出生日期.ToString();
            textBox7.Text = currxs.身高.ToString();
            textBox8.Text = currxs.金额.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var xs = new 学生表();
            xs.学号 = textBox1.Text;
            xs.姓名 = textBox2.Text;
            xs.性别 = textBox3.Text;
//            xs.班级 = textBox4.Text;
            xs.通信地址 = textBox5.Text;
            xs.出生日期 = DateTime.Parse(textBox6.Text);
            xs.身高 = decimal.Parse(textBox7.Text);
            xs.金额 = decimal.Parse(textBox8.Text);
            var mydb = new jiaowudataEntities();
            mydb.学生表.Add(xs);
            mydb.SaveChanges();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
