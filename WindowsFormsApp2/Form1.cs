using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//登陆
        {
            //1、连接数据库
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("账号密码不能为空！！！", "提示");
            }
            else
            {
                //2、判断用户名是否存在
                SqlCommand command = new SqlCommand($"select * from db_users where username='{textBox1.Text}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                object obj = new object();
                while (reader.Read())
                {
                    obj = reader[0];
                }
                reader.Close();
                try
                {
                    var f = (string)obj;//若为空值执行catch命令
                }
                catch
                {
                    MessageBox.Show("该用户不存在", "提示");
                    return;
                }
                //3、判断密码是否正确
                SqlCommand pdmm = new SqlCommand($"select password from db_users where username='{textBox1.Text}'", connection);
                SqlDataReader mm = pdmm.ExecuteReader();
                object obj1 = new object();
                while (mm.Read())
                {
                    obj1 = mm[0];
                }
                mm.Close();
                if (textBox2.Text == (string)obj1)
                {
                    Form4 form4 = Program.form4;
                    form4.toolStripStatusLabel1.Text=textBox1.Text;
                    form4.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("密码不正确！！！", "提示");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                connection.Close ();
            } 
        }

        private void button2_Click(object sender, EventArgs e)//清除
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)//注册账号
        {
            Form2 form2 = new Form2();
            form2.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//找回密码
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)//装修，填充数据库用。。
        {
            Form10 form10 = new Form10();
            form10.Show();
        }
    }
}
