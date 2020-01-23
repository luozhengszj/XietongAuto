namespace XietongAuto
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fasong_btn = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_body = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_from = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_login_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_login_pawd = new System.Windows.Forms.TextBox();
            this.textBox_url_port = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.testbtn = new System.Windows.Forms.Button();
            this.shuomingtbn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fasong_btn
            // 
            this.fasong_btn.Location = new System.Drawing.Point(14, 413);
            this.fasong_btn.Name = "fasong_btn";
            this.fasong_btn.Size = new System.Drawing.Size(159, 26);
            this.fasong_btn.TabIndex = 0;
            this.fasong_btn.Text = "确定发送邮件";
            this.fasong_btn.UseVisualStyleBackColor = true;
            this.fasong_btn.Click += new System.EventHandler(this.fasong_btn_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(14, 323);
            this.textBox_path.Multiline = true;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(159, 77);
            this.textBox_path.TabIndex = 1;
            // 
            // textBox_log
            // 
            this.textBox_log.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.textBox_log.Location = new System.Drawing.Point(593, 37);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_log.Size = new System.Drawing.Size(391, 440);
            this.textBox_log.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Excel A序号 B姓名 C账号 D代替";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "输出日志";
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(12, 28);
            this.textBox_url.Multiline = true;
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(89, 21);
            this.textBox_url.TabIndex = 7;
            this.textBox_url.Text = "10.100.83.190";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "邮件服务器地址  端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 9;
            // 
            // textBox_body
            // 
            this.textBox_body.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.textBox_body.Location = new System.Drawing.Point(200, 86);
            this.textBox_body.Multiline = true;
            this.textBox_body.Name = "textBox_body";
            this.textBox_body.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_body.Size = new System.Drawing.Size(371, 391);
            this.textBox_body.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "邮件内容  需要替换的内容请用luozhengQAQ代替";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "发送邮箱的账号";
            // 
            // textbox_from
            // 
            this.textbox_from.Location = new System.Drawing.Point(12, 207);
            this.textbox_from.Multiline = true;
            this.textbox_from.Name = "textbox_from";
            this.textbox_from.Size = new System.Drawing.Size(161, 24);
            this.textbox_from.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "邮箱账号";
            // 
            // textbox_login_name
            // 
            this.textbox_login_name.Location = new System.Drawing.Point(12, 86);
            this.textbox_login_name.Multiline = true;
            this.textbox_login_name.Name = "textbox_login_name";
            this.textbox_login_name.Size = new System.Drawing.Size(161, 24);
            this.textbox_login_name.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "邮箱密码";
            // 
            // textbox_login_pawd
            // 
            this.textbox_login_pawd.Location = new System.Drawing.Point(12, 143);
            this.textbox_login_pawd.Multiline = true;
            this.textbox_login_pawd.Name = "textbox_login_pawd";
            this.textbox_login_pawd.PasswordChar = '*';
            this.textbox_login_pawd.Size = new System.Drawing.Size(161, 24);
            this.textbox_login_pawd.TabIndex = 18;
            // 
            // textBox_url_port
            // 
            this.textBox_url_port.Location = new System.Drawing.Point(111, 28);
            this.textBox_url_port.Multiline = true;
            this.textBox_url_port.Name = "textBox_url_port";
            this.textBox_url_port.Size = new System.Drawing.Size(36, 21);
            this.textBox_url_port.TabIndex = 20;
            this.textBox_url_port.Text = "25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "替换字段的次数";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(12, 261);
            this.textBox_number.Multiline = true;
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(89, 24);
            this.textBox_number.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "邮件标题";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(200, 34);
            this.textBox_title.Multiline = true;
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(371, 24);
            this.textBox_title.TabIndex = 24;
            // 
            // testbtn
            // 
            this.testbtn.Location = new System.Drawing.Point(825, 5);
            this.testbtn.Name = "testbtn";
            this.testbtn.Size = new System.Drawing.Size(159, 26);
            this.testbtn.TabIndex = 25;
            this.testbtn.Text = "测试 不显示";
            this.testbtn.UseVisualStyleBackColor = true;
            this.testbtn.Visible = false;
            this.testbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // shuomingtbn
            // 
            this.shuomingtbn.Location = new System.Drawing.Point(12, 451);
            this.shuomingtbn.Name = "shuomingtbn";
            this.shuomingtbn.Size = new System.Drawing.Size(159, 26);
            this.shuomingtbn.TabIndex = 26;
            this.shuomingtbn.Text = "使用说明";
            this.shuomingtbn.UseVisualStyleBackColor = true;
            this.shuomingtbn.Click += new System.EventHandler(this.shuomingtbn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 489);
            this.Controls.Add(this.shuomingtbn);
            this.Controls.Add(this.testbtn);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_url_port);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox_login_pawd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_login_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_from);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_body);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.fasong_btn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "协同内邮自动发送";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fasong_btn;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_body;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_from;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_login_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_login_pawd;
        private System.Windows.Forms.TextBox textBox_url_port;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Button testbtn;
        private System.Windows.Forms.Button shuomingtbn;
    }
}

