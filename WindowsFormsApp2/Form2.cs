using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();

            if (textBox2.Text != textBox3.Text)
            {
                textBox3.Text = "";
                MessageBox.Show("确认密码与密码不一致！！！", "提示");
                textBox3.Focus();
            }            
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("都是重要信息，请认真将注册信息填写完整！！！", "提示");
                textBox1.Focus();
            }
            else
            {
                SqlCommand command = new SqlCommand($"select * from db_users where username='{textBox1.Text}'", connection);
                SqlDataReader reader = command.ExecuteReader();//执行上述查找语句
                object obj = new object();
                while (reader.Read())
                {
                    obj = reader[0];//在数据库中查找是否存在已有用户
                }
                reader.Close();
                //检测异常
                try
                {
                    var f = (string)obj;//若为空值执行catch命令
                }
                catch
                {
                    var commandText = $"insert into db_users values ('{textBox1.Text}','{textBox2.Text}','{comboBox1.Text }','{textBox4.Text }','{textBox5.Text }','{textBox6.Text }','{textBox7.Text }',null)";
                    new SqlCommand(commandText, connection).ExecuteNonQuery();
                    MessageBox.Show("注册成功！！！", "提示");
                    this.Hide();
                    return;
                }
                MessageBox.Show("用户已存在！", "提示");
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
