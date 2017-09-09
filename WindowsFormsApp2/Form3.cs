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
    public partial class Form3 : Form
    {
        jiaowudataEntities mydb = new jiaowudataEntities();
        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = mydb.学生表.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 FormEdit = new Form4();
            FormEdit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var xs = dataGridView1.CurrentRow.DataBoundItem as 学生表;
            Form4 FormEdit = new Form4(xs);
            FormEdit.Show();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var xs = dataGridView1.CurrentRow.DataBoundItem as 学生表;
            var FormEdit = new Form4(xs);
            FormEdit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var xs = dataGridView1.CurrentRow.DataBoundItem as 学生表;
            mydb.学生表.Attach(xs);
            mydb.学生表.Remove(xs);
            mydb.SaveChanges();
        }
    }
}
