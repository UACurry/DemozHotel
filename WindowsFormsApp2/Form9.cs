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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("信息不能为空，请认真填写！！！", "提示");
                textBox1.Focus();
            }
            else
            {
                Form4 form4 = Program.form4;
                //1、判断房号是否是该用户使用
                SqlCommand command = new SqlCommand($"select room from db_users where username='{form4.toolStripStatusLabel1.Text}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                object obj = new object();
                while (reader.Read())
                {
                    obj = reader[0];
                }
                reader.Close();
                try
                {
                    var f = (string)obj;
                }
                catch
                {
                    MessageBox.Show("该房间不属于本用户使用", "提示");
                    return;
                }
                if (textBox1.Text == (string)obj)
                {
                    //2、判断密码是否正确
                    SqlCommand command1 = new SqlCommand($"select password from db_users where username='{form4.toolStripStatusLabel1.Text}'", connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    object obj1 = new object();
                    while (reader1.Read())
                    {
                        obj1 = reader1[0];
                    }
                    reader1.Close();
                    if (textBox2.Text == (string)obj1)
                    {
                        MessageBox.Show("欢迎回家!!!", "提示");
                        pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\img\door1.jpg");
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\img\room.jpg");
                    }
                    else
                    {
                        MessageBox.Show("密码不正确", "提示");
                    }
                }                
            }
            

            
        }
    }
}
