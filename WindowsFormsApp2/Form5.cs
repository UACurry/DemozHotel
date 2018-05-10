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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();
            Form4 form4 = Program.form4;
            if (textBox2.Text == "")
            {
                MessageBox.Show("房间号不能为空", "提示");
            }
            else if(Convert.ToInt32 ( textBox2.Text)<=600 || Convert.ToInt32(textBox2.Text) >= 2008 )
            {
                MessageBox.Show("没有该房间号", "提示");
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
                    //2、未预约过房间，判断该房间是否已被人预约
                    SqlCommand pdyy = new SqlCommand($"select roomOX from db_rooms where room='{textBox2.Text}'", connection);
                    SqlDataReader yyzk = pdyy.ExecuteReader();
                    object obj1 = new object();
                    while (yyzk.Read())
                    {
                        obj1 = yyzk[0];
                    }
                    yyzk.Close();
                    if ((string)obj1 == "empty")
                    {
                        //给用户信息数据添加房间信息
                        var commandText = $"update db_users set room='{textBox2.Text}' where username='{form4.toolStripStatusLabel1.Text}'";
                        new SqlCommand(commandText, connection).ExecuteNonQuery();
                        //给房间信息添加已有人预约的信息
                        var commandText1 = $"update db_rooms set roomOX='using' where room='{textBox2.Text}'";
                        new SqlCommand(commandText1, connection).ExecuteNonQuery();
                        //给房间信息添加已预约人的信息
                        var commandText2 = $"update db_rooms set username='{form4.toolStripStatusLabel1.Text}' where room='{textBox2.Text}'";
                        new SqlCommand(commandText2, connection).ExecuteNonQuery();

                        MessageBox.Show("预约成功！！！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("该房间已被人提前预约", "提示");
                    }                    
                    return;
                }
                if ((string)obj == "NULL")
                {
                    SqlCommand pdyy = new SqlCommand($"select roomOX from db_rooms where room='{textBox2.Text}'", connection);
                    SqlDataReader yyzk = pdyy.ExecuteReader();
                    object obj1 = new object();
                    while (yyzk.Read())
                    {
                        obj1 = yyzk[0];
                    }
                    yyzk.Close();
                    if ((string)obj1 == "empty")
                    {
                        //给用户信息数据添加房间信息
                        var commandText = $"update db_users set room='{textBox2.Text}' where username='{form4.toolStripStatusLabel1.Text}'";
                        new SqlCommand(commandText, connection).ExecuteNonQuery();
                        //给房间信息添加已有人预约的信息
                        var commandText1 = $"update db_rooms set roomOX='using' where room='{textBox2.Text}'";
                        new SqlCommand(commandText1, connection).ExecuteNonQuery();
                        //给房间信息添加已预约人的信息
                        var commandText2 = $"update db_rooms set username='{form4.toolStripStatusLabel1.Text}' where room='{textBox2.Text}'";
                        new SqlCommand(commandText2, connection).ExecuteNonQuery();

                        MessageBox.Show("预约成功！！！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("该房间已被人提前预约", "提示");
                    }
                }
                else
                    MessageBox.Show("该用户已预约过房间","提示");
                
                 /*2、判断该房间是否已被人预约
                    SqlCommand pdyy = new SqlCommand($"select roomOX from db_rooms where room='{textBox2.Text}'", connection);
                    SqlDataReader yyzk = pdyy.ExecuteReader();
                    object obj1 = new object();
                    while (yyzk.Read())
                    {
                        obj1 = yyzk[0];
                    }
                    yyzk.Close();                    
                    try
                    {                        
                        var f1 = (string)obj1;
                    }
                    catch
                    {
                        if ((string)obj1 == "empty")
                        {
                            //给用户信息数据添加房间信息
                            var commandText = $"update db_users set room='{textBox2.Text}' where username='{form4.toolStripStatusLabel1.Text}'";
                            new SqlCommand(commandText, connection).ExecuteNonQuery();
                            //给房间信息添加已有人预约的信息
                            var commandText1 = $"update db_rooms set roomOX='using' where room='{textBox2.Text}'";
                            new SqlCommand(commandText1, connection).ExecuteNonQuery();
                            //给房间信息添加已预约人的信息
                            var commandText2 = $"update db_rooms set username='{form4.toolStripStatusLabel1.Text}' where room='{textBox2.Text}'";
                            new SqlCommand(commandText2, connection).ExecuteNonQuery();

                            MessageBox.Show("预约成功！！！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("该房间已被人提前预约", "提示");
                        }                        
                        return;
                    }                    
                    return;*/
                
                /*2、判断该房间是否已被别人预约obj1
                SqlCommand pdyy = new SqlCommand($"select roomOX from db_rooms where room='{textBox2.Text}'", connection);
                SqlDataReader yyzk = pdyy.ExecuteReader();
                object obj1 = new object();
                while (yyzk.Read())
                {
                    obj1 = yyzk[0];
                }
                yyzk.Close();
                try
                {
                    var f = (string)obj;
                    var f1 = (string)obj1;
                }
                catch
                {                    
                        //给用户信息数据添加房间信息
                        var commandText = $"update db_users set room='{textBox2.Text}' where username='{form4.toolStripStatusLabel1.Text}'";
                        new SqlCommand(commandText, connection).ExecuteNonQuery();
                        //给房间信息添加已有人预约的信息
                        var commandText1 = $"update db_rooms set roomOX='USING' where room='{textBox2.Text}'";
                        new SqlCommand(commandText1, connection).ExecuteNonQuery();
                        //给房间信息添加已预约人的信息
                        var commandText2 = $"update db_rooms set username='{form4.toolStripStatusLabel1.Text}' where room='{textBox2.Text}'";
                        new SqlCommand(commandText2, connection).ExecuteNonQuery();

                        MessageBox.Show("预约成功！！！", "提示");
                        return;                                 
                }                       
                
                MessageBox.Show("该用户已预约房间或该房间已被别人预约！", "提示");*/
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
