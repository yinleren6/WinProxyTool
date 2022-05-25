namespace WinProxyTool
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_config = new System.Windows.Forms.Button();
            this.label_Port = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CheckBox_Override = new System.Windows.Forms.CheckBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_versiom = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_config);
            this.panel1.Location = new System.Drawing.Point(23, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 41);
            this.panel1.TabIndex = 2;
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("宋体", 14F);
            this.button_refresh.Location = new System.Drawing.Point(3, 3);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(120, 35);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.Button_get_Proxy_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14F);
            this.button1.Location = new System.Drawing.Point(132, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Enable_Proxy_Click);
            // 
            // button_config
            // 
            this.button_config.Font = new System.Drawing.Font("宋体", 14F);
            this.button_config.Location = new System.Drawing.Point(261, 3);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(120, 35);
            this.button_config.TabIndex = 6;
            this.button_config.Text = "保存";
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.Button_Save_Proxy_Click);
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("宋体", 14F);
            this.label_Port.Location = new System.Drawing.Point(3, 0);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(50, 26);
            this.label_Port.TabIndex = 4;
            this.label_Port.Text = "端口";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox_Port.Location = new System.Drawing.Point(3, 29);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(200, 34);
            this.textBox_Port.TabIndex = 3;
            this.textBox_Port.TextChanged += new System.EventHandler(this.TextBox_Port_TextChanged);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox_IP.Location = new System.Drawing.Point(3, 29);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(200, 34);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.TextChanged += new System.EventHandler(this.TextBox_IP_TextChanged);
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("宋体", 14F);
            this.label_IP.Location = new System.Drawing.Point(3, 0);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(28, 26);
            this.label_IP.TabIndex = 0;
            this.label_IP.Text = "IP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 345);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CheckBox_Override);
            this.tabPage1.Controls.Add(this.log);
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Controls.Add(this.flowLayoutPanel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 10F);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "系统代理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Override
            // 
            this.CheckBox_Override.AutoSize = true;
            this.CheckBox_Override.Location = new System.Drawing.Point(26, 215);
            this.CheckBox_Override.Name = "CheckBox_Override";
            this.CheckBox_Override.Size = new System.Drawing.Size(210, 24);
            this.CheckBox_Override.TabIndex = 8;
            this.CheckBox_Override.Text = "本地(intranet)地址不使用代理";
            this.CheckBox_Override.UseVisualStyleBackColor = true;
            this.CheckBox_Override.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("宋体", 12F);
            this.log.Location = new System.Drawing.Point(6, 90);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(415, 110);
            this.log.TabIndex = 7;
            this.log.Text = "";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label_Port);
            this.flowLayoutPanel3.Controls.Add(this.textBox_Port);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(215, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(206, 78);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label_IP);
            this.flowLayoutPanel2.Controls.Add(this.textBox_IP);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(206, 78);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_versiom);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "关于";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_versiom
            // 
            this.label_versiom.AutoSize = true;
            this.label_versiom.Font = new System.Drawing.Font("宋体", 12F);
            this.label_versiom.Location = new System.Drawing.Point(22, 36);
            this.label_versiom.Name = "label_versiom";
            this.label_versiom.Size = new System.Drawing.Size(61, 22);
            this.label_versiom.TabIndex = 1;
            this.label_versiom.Text = "version";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(22, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 22);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Jump);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 366);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(472, 405);
            this.Name = "Form1";
            this.Text = "系统代理设置";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_versiom;
        private System.Windows.Forms.CheckBox CheckBox_Override;
    }
}

