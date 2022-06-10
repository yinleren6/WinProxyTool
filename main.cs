using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinProxyTool
{
    public partial class MainWindow : Form
    {
        readonly string version = "1.1.2 ";
        int ProxyEnable;
        string ProxyServer;
        bool ignore_local;

        public MainWindow()
        {
            InitializeComponent();
            this.CheckBox_Override.Text = "本地(intranet)地址不使用代理";
            UpdateValue(); UpdateUI();
            label_versiom.Text = version;
        }
        //内部类
        private class Proxy_Settings
        {
            static readonly RegistryKey proxy = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            //获取代理开关
            public int Get_ProxyEnable()
            {
                int ProxyEnable = (int)proxy.GetValue("ProxyEnable");
                return ProxyEnable;
            }
            public void Set_ProxyEnable(int v) { proxy.SetValue("ProxyEnable", v); }
            //获取代理IP地址
            public string Get_ProxyServer()
            {
                string ProxyServer = (string)proxy.GetValue("ProxyServer");
                return ProxyServer;
            }
            public void Set_ProxyServer(string s) { proxy.SetValue("ProxyServer", s); }

            //
            public string Get_ProxyOverride()
            {
                string ProxyOverride = (string)proxy.GetValue("ProxyOverride");
                if (ProxyOverride == null) { return "null"; }
                else { return ProxyOverride; }
            }
            public void Clear_ProxyOverride() { proxy.SetValue("ProxyOverride", ""); }
        };

        //更新数据
        private void UpdateValue()
        {
            Proxy_Settings Settings = new Proxy_Settings();
            //代理开关
            ProxyEnable = Settings.Get_ProxyEnable();
            //代理地址
            string mProxyServer = Settings.Get_ProxyServer();
            if (mProxyServer != null) { ProxyServer = mProxyServer; }
            //跳过代理
            string mProxyOverride = Settings.Get_ProxyOverride();
            ignore_local = mProxyOverride.Contains("<local>");
        }

        //更新UI
        private void UpdateUI()
        {
            log.ForeColor = System.Drawing.Color.Black;
            string on = "代理已开启";
            string off = "代理已关闭";
            if (ProxyEnable == 1) { button1.Text = on; }
            else { button1.Text = off; }
            if (log.Text.Length > 20) { log.Text = ""; }

            try
            {
                int index = ProxyServer.IndexOf("://");
                if (index == ProxyServer.IndexOf(":")) { ProxyServer = (string)ProxyServer.Substring(index + 3); }

                if (ProxyServer.IndexOf("://") == -1)
                {
                    textBox_IP.Text = (string)ProxyServer.Split(':')[0];
                    textBox_Port.Text = (string)ProxyServer.Split(':')[1];
                    log.Text = string.Format("代理状态: {0}\n代理地址: {1}\n", button1.Text.Substring(2), ProxyServer);
                }
            }
            catch (Exception e) { Console.WriteLine(e); }

            if (ignore_local) { CheckBox_Override.Checked = true; CheckBox_Override.Enabled = true; } else { CheckBox_Override.Checked = false; CheckBox_Override.Enabled = false; }
        }

        //设置代理开关
        private void Set_ProxyEnable(int v)
        {
            Proxy_Settings Settings = new Proxy_Settings();
            Settings.Set_ProxyEnable(v);
        }

        //设置代理地址
        private void Save_ProxyServer()
        {
            Proxy_Settings Settings = new Proxy_Settings();
            string _ip = textBox_IP.Text.Trim();
            string _port = textBox_Port.Text.Trim();

            if (_ip != "" && _ip.IndexOf(" ") == -1)
            {
                if (_port != "" && _port.IndexOf(" ") == -1 && int.TryParse(_port, out _))
                {
                    Settings.Set_ProxyServer(_ip + ":" + _port);
                    UpdateValue();
                }
                else { log.ForeColor = System.Drawing.Color.Red; log.Text = "端口错误\n" + _port; }
            }
            else { log.ForeColor = System.Drawing.Color.Red; log.Text = "IP错误\n" + _ip; }
            log.ForeColor = System.Drawing.Color.Black;
        }

        //设置跳过本地地址
        private void Save_ProxyOverride()
        {
            Proxy_Settings Settings = new Proxy_Settings();
            Settings.Clear_ProxyOverride();
            UpdateValue();
        }

        //刷新按钮
        private void Button_get_Proxy_Click(object sender, EventArgs e) { UpdateValue(); UpdateUI(); }

        //保存代理按钮
        private void Button_Save_Proxy_Click(object sender, EventArgs e) { Save_ProxyServer(); Save_ProxyOverride(); UpdateValue(); UpdateUI(); }

        //代理开关按钮
        private void Button_Enable_Proxy_Click(object sender, EventArgs e)
        {
            if (ProxyEnable == 1) { Set_ProxyEnable(0); }
            else { Set_ProxyEnable(1); }
            UpdateValue(); UpdateUI();
        }

        private void Jump(object sender, LinkLabelLinkClickedEventArgs e) { Process.Start("https://github.com/yinleren6/WinRegTool/releases"); }

        private void TextBox_IP_TextChanged(object sender, EventArgs e) { log.Text = "未保存"; }

        private void TextBox_Port_TextChanged(object sender, EventArgs e) { log.Text = "未保存"; }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) { if (!CheckBox_Override.Checked) { Save_ProxyOverride(); } }
    }
}
