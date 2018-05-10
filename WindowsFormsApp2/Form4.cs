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
    public partial class Form4 : Form
    {      
        public Form4()
        {
            InitializeComponent();            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //预备电梯“按钮”（combobox）
            for (int i = -2; i <= 21; i++)
            {
                if (i != 0)
                    comboBox1.Items.Add(i);
            }

            //电梯所在楼层随机数
            Random rd = new Random();
            int a = rd.Next(-2,22);
            if (a == 0)
                a++;
            textBox1.Text = Convert.ToString(a);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//电梯效果
        {
            string q = textBox2.Text ;
            if (q == "1")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\1.jpg");
                label1.Text = "大堂";
            }
            else if (q == "-1")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\-1.jpg");
                label1.Text = "泳池";
            }
            else if (q == "-2")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\-2.jpg");
                label1.Text = "车库";
            }
            else if (q == "2")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\2.jpg");
                label1.Text = "贵宾餐厅";
            }
            else if (q == "3")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\3.jpg");
                label1.Text = "美食坊";
            }
            else if (q == "4")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\4.jpg");
                label1.Text = "酒吧";
            }
            else if (q == "5")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\5.jpg");
                label1.Text = "健身房";
            }
            else if (q == "21")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\21.jpg");
                label1.Text = "图书馆";
            }
            else if (q == "0")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\1.jpg");
                label1.Text = "";
            }
            else
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\floor\6-20.jpg");
                label1.Text = "客房";
            }
        }
        
        int ele,f;        
        private void pictureBox3_Click(object sender, EventArgs e)//电梯启动按钮
        {            
            ele = Convert.ToInt32(textBox1.Text);//电梯所在层数
            f = Convert.ToInt32(textBox2.Text);//当前层数

            pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\img\up1.png"); //“绿标”说明电梯启动            
            timer1.Enabled = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)//等待电梯（电梯正在赶来的路上）
        {
            if (ele == f)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\img\ele1.jpg");
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\img\up0.png");
                comboBox1.Enabled = true;
                timer1.Enabled = false;
                timer3.Enabled = true;
                MessageBox.Show("电梯到了", "提示");
            }
            else if (ele > f)
            {
                ele--;
                textBox1.Text = Convert.ToString(ele);                
            }
            else
            {
                ele++;
                textBox1.Text = Convert.ToString(ele);                
            }
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//点击要去的目标楼层
        {            
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\img\ele0.jpg");
            timer2.Enabled = true;
            comboBox1.Enabled = false;
        }        

        private void timer2_Tick(object sender, EventArgs e)//电梯出发，去目标楼层
        {
            int obj = Convert.ToInt32(comboBox1.Text);
            if (ele == obj)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\img\ele1.jpg");               
                timer2.Enabled = false;
                MessageBox.Show(obj + "层到了！！", "提示");
                timer3.Enabled = true;
            }
            else if (ele > obj)
            {
                ele--;
                textBox1.Text = Convert.ToString(ele);
                textBox2.Text = Convert.ToString(ele);
            }
            else
            {
                ele++;
                textBox1.Text = Convert.ToString(ele);
                textBox2.Text = Convert.ToString(ele);
            }

            
        }        

        private void timer3_Tick_1(object sender, EventArgs e)//若电梯打开5秒后没人，电梯自动关门
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\img\ele0.jpg");
            comboBox1.Enabled = false;
            timer3.Enabled = false;
        }

        private void 入住管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void 退房管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void 房间信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void 空房查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void 客房安全系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        //关闭主程序
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void 退出系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
