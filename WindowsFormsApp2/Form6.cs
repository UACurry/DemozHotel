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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();
            Form4 form4 = Program.form4;

            if (textBox1.Text == "")
            {
                MessageBox.Show("退房房间号不能为空", "提示");
            }
            else if (Convert.ToInt32(textBox1.Text) <= 600 || Convert.ToInt32(textBox1.Text) >= 2008)
            {
                MessageBox.Show("没有该房间号（6-20层是客房，每层只有8个房间）", "提示");
            }
            else
            {
                //1、判断该用户是否已预约房间                
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
                    MessageBox.Show("该用户未预约过房间", "提示");
                }
                //2、若预约过房间，判断该房间是该用户预约
                SqlCommand pdyy = new SqlCommand($"select roomOX from db_rooms where room='{textBox1.Text}'", connection);
                SqlDataReader yyzk = pdyy.ExecuteReader();
                object obj1 = new object();
                while (yyzk.Read())
                {
                    obj1 = yyzk[0];
                }
                yyzk.Close();

                if ((string)obj1 != "empty")
                {
                    //给用户信息数据添加房间信息
                    var commandText = $"update db_users set room='NULL' where username='{form4.toolStripStatusLabel1.Text}'";
                    new SqlCommand(commandText, connection).ExecuteNonQuery();
                    //给房间信息添加已有人预约的信息
                    var commandText1 = $"update db_rooms set roomOX='empty' where room='{textBox1.Text}'";
                    new SqlCommand(commandText1, connection).ExecuteNonQuery();
                    //给房间信息添加已预约人的信息
                    var commandText2 = $"update db_rooms set username='NULL' where room='{textBox1.Text}'";
                    new SqlCommand(commandText2, connection).ExecuteNonQuery();

                    MessageBox.Show("退房成功！！！", "提示");
                }
                else
                {
                    MessageBox.Show("该房间不属于该用户使用", "提示");
                }
                return;


                /*string commandText = $"delete from dbo.db_users where room='{textBox1.Text}'";
                SqlCommand command= new SqlCommand(commandText, connection);            
                command.ExecuteNonQuery();*/
                //Form4 form4 = Program.form4;
                //string commandText1 = $"update dbo.db_rooms set roomOX='{textBox1.Text}' where  username='{form4.toolStripStatusLabel1.Text}";
                //SqlCommand command1 = new SqlCommand(commandText1, connection);
                //command1.ExecuteNonQuery();
                /*SqlDataReader reader = command1.ExecuteNonQuery();
                /*SqlCommand command1 = new SqlCommand($"delete room from dbo.db_rooms where room='{textBox1.Text}'", connection);
                SqlDataReader reader = command.ExecuteReader();//执行上述查找语句*/
                /*Form4 form4 = Program.form4;
                SqlCommand command = new SqlCommand($"select room from db_users where username='{form4.toolStripStatusLabel1.Text}'", connection);
                SqlDataReader reader = command.ExecuteReader();//执行上述查找语句
                object obj = new object();
                while (reader.Read())
                {
                    obj = reader[0];//在数据库中查找是否存在已有用户
                }*/
                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
