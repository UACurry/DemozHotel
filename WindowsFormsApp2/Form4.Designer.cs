﻿namespace WindowsFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空房查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入住管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客房安全系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(398, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(398, 47);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 42);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(559, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(458, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "大堂";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(559, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房管理ToolStripMenuItem,
            this.查询信息ToolStripMenuItem,
            this.客房安全系统ToolStripMenuItem,
            this.退出系统ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询信息ToolStripMenuItem
            // 
            this.查询信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间查询ToolStripMenuItem});
            this.查询信息ToolStripMenuItem.Name = "查询信息ToolStripMenuItem";
            this.查询信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询信息ToolStripMenuItem.Text = "查询信息";
            // 
            // 房间查询ToolStripMenuItem
            // 
            this.房间查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间信息ToolStripMenuItem,
            this.空房查询ToolStripMenuItem});
            this.房间查询ToolStripMenuItem.Name = "房间查询ToolStripMenuItem";
            this.房间查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间查询ToolStripMenuItem.Text = "房间查询";
            // 
            // 空房查询ToolStripMenuItem
            // 
            this.空房查询ToolStripMenuItem.Name = "空房查询ToolStripMenuItem";
            this.空房查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.空房查询ToolStripMenuItem.Text = "空房查询";
            this.空房查询ToolStripMenuItem.Click += new System.EventHandler(this.空房查询ToolStripMenuItem_Click);
            // 
            // 房间信息ToolStripMenuItem
            // 
            this.房间信息ToolStripMenuItem.Name = "房间信息ToolStripMenuItem";
            this.房间信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间信息ToolStripMenuItem.Text = "房间信息";
            this.房间信息ToolStripMenuItem.Click += new System.EventHandler(this.房间信息ToolStripMenuItem_Click);
            // 
            // 客房管理ToolStripMenuItem
            // 
            this.客房管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入住管理ToolStripMenuItem,
            this.退房管理ToolStripMenuItem});
            this.客房管理ToolStripMenuItem.Name = "客房管理ToolStripMenuItem";
            this.客房管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客房管理ToolStripMenuItem.Text = "客房管理";
            // 
            // 入住管理ToolStripMenuItem
            // 
            this.入住管理ToolStripMenuItem.Name = "入住管理ToolStripMenuItem";
            this.入住管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.入住管理ToolStripMenuItem.Text = "入住管理";
            this.入住管理ToolStripMenuItem.Click += new System.EventHandler(this.入住管理ToolStripMenuItem_Click);
            // 
            // 退房管理ToolStripMenuItem
            // 
            this.退房管理ToolStripMenuItem.Name = "退房管理ToolStripMenuItem";
            this.退房管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退房管理ToolStripMenuItem.Text = "退房管理";
            this.退房管理ToolStripMenuItem.Click += new System.EventHandler(this.退房管理ToolStripMenuItem_Click);
            // 
            // 客房安全系统ToolStripMenuItem
            // 
            this.客房安全系统ToolStripMenuItem.Name = "客房安全系统ToolStripMenuItem";
            this.客房安全系统ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.客房安全系统ToolStripMenuItem.Text = "客房安全系统";
            this.客房安全系统ToolStripMenuItem.Click += new System.EventHandler(this.客房安全系统ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem1
            // 
            this.退出系统ToolStripMenuItem1.Name = "退出系统ToolStripMenuItem1";
            this.退出系统ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem1.Text = "退出系统";
            this.退出系统ToolStripMenuItem1.Click += new System.EventHandler(this.退出系统ToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "TeamZ Hotel Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 客房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入住管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空房查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客房安全系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}