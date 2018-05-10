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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();

            if (comboBox1.Text == "空闲")
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"select room from db_rooms where roomOX='empty'", Program.conStr);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "room");
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "room";
                dataGridView1.Columns[0].DataPropertyName = dataSet.Tables[0].Columns[0].ToString();
            }
            else if (comboBox1.Text == "使用")
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"select room,username from db_rooms where roomOX='using'", Program.conStr);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "room");
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "room";
                dataGridView1.Columns[0].DataPropertyName = dataSet.Tables[0].Columns[0].ToString();
            }
            else
            {
                MessageBox.Show("请在下拉栏填上‘空闲’或‘使用’", "提示");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
