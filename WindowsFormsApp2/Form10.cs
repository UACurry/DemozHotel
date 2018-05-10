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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.conStr);
            connection.Open();

            SqlCommand command = new SqlCommand($"select * from db_rooms where room='{601}'", connection);
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
                for (int i = 6; i <= 20; i++)
                {
                    for (int j = 1; j <= 8; j++)
                    {
                        try { 
                        int fjh = i * 100 + j;
                        var commandText = $"insert into db_rooms values ({fjh},'empty',null)";
                        new SqlCommand(commandText, connection).ExecuteNonQuery();
                        MessageBox.Show("装修完成！！", "提示");
                        }
                        catch { }
                    }
                }

                return;
            }
            MessageBox.Show("装修已完成，就等着营业了！！", "提示");                        
            
        }
        
    }
}
