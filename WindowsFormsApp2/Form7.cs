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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();

            Form4 form4 = Program.form4;
            
            //判断该用户是否已预约房间
            SqlCommand command = new SqlCommand($"select room from db_users where username='{form4.toolStripStatusLabel1.Text}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            object obj = new object();
            while (reader.Read())
            {
                obj = reader[0];
            }
            reader.Close();
            try//判断是否是空值
            {
                var f = (string)obj;
            }
            catch
            {
                MessageBox.Show("您未在本店预约房间", "提示");
                return;
            }
            if ((string)obj == "NULL")//判断是否已存在值，值为“null”
            {
                MessageBox.Show("您未在本店预约房间", "提示");
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"select username,NAME,IDnumber,PHnumber,room,password from db_users where username='{form4.toolStripStatusLabel1.Text}'", Program.conStr);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "room");
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "room";
                dataGridView1.Columns[0].DataPropertyName = dataSet.Tables[0].Columns[0].ToString();
            }


            

            /*if (textBox1.Text == "")
            {
                MessageBox.Show("信息不能为空，请认真填写！！！", "提示");
                textBox1.Focus();
            }
            else
            {}*/



        }
    }
}
