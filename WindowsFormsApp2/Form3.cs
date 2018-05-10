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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("信息不能为空，请认真填写！！！", "提示");
                textBox1.Focus();
            }
            else
            {
                //1、判断是否存在该用户名
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
                //2、判断该用户的问题是否正确
                SqlCommand wt = new SqlCommand($"select question from db_users where username='{textBox1.Text}'", connection);
                SqlDataReader mmwt = wt.ExecuteReader();
                Object obj1 = new object();
                while (mmwt.Read())
                {
                    obj1 = mmwt[0];
                }
                mmwt.Close();

                if (comboBox1.Text == (string)obj1)
                {
                    //3、判断问题的答案是否匹配
                    SqlCommand da = new SqlCommand($"select answer from db_users where username='{textBox1.Text}'", connection);
                    SqlDataReader zqda = da.ExecuteReader();
                    Object obj2 = new object();
                    while (zqda.Read())
                    {
                        obj2 = zqda[0];
                    }
                    zqda.Close();

                    if (textBox2.Text == (string)obj2)
                    {
                        //4、获得密码
                        SqlCommand mm = new SqlCommand($"select password from db_users where username='{textBox1.Text}'", connection);
                        SqlDataReader zhmm = mm.ExecuteReader();
                        Object obj3 = new object();
                        while (zhmm.Read())
                        {
                            obj3 = zhmm[0];
                        }
                        zhmm.Close();

                        MessageBox.Show("密码成功找回", "提示");
                        label5.Text = (string)obj3;
                    }
                    else
                    {
                        MessageBox.Show("答案不对请重新填写", "提示");
                        textBox2.Focus();
                    }                    
                }
                else
                {
                    MessageBox.Show("问题不对请重新填写", "提示");
                    comboBox1.Focus();
                }
            }
        }
    }
}
