using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinProxyTool.Utils;

namespace WinProxyTool
{
    public partial class MainWindow : Form
    {
        int ProxyEnable;
        string ProxyServer;
        bool ignore_local;
        RegistryTool Settings = new RegistryTool();

        public MainWindow()
        {
            InitializeComponent();
            UpdateValue();
            UpdateUI();
        }

        //更新数据
        private void UpdateValue()
        {
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


        }

        //设置代理开关
        private void Set_ProxyEnable(int v)
        {
            Settings.Set_ProxyEnable(v);
        }

        //设置代理地址
        private int Save_ProxyServer()
        {
            string _ip = textBox_IP.Text.Trim();
            string _port = textBox_Port.Text.Trim();
            Regex validipregex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            bool ip_valid = (_ip != "" && validipregex.IsMatch(_ip)) ? true : false;

            if (_ip != "" && ip_valid) { }
            else
            {
                log.ForeColor = System.Drawing.Color.Red; log.Text = "IP错误\n" + _ip;
                return -1;
            }

            if (_port != "" && int.TryParse(_port, out _))
            {
                int m_port = int.Parse(_port);
                if (m_port > 0 && m_port < 65536)
                {
                    Settings.Set_ProxyServer(_ip + ":" + _port);
                    UpdateValue();
                    return 0;
                }
                else
                {
                    log.ForeColor = System.Drawing.Color.Red; log.Text = "端口错误\n" + _port;
                    return -1;
                }
            }
            else
            {
                log.ForeColor = System.Drawing.Color.Red; log.Text = "端口错误\n" + _port;
                return -1;
            }
        }



        //刷新按钮
        private void Button_get_Proxy_Click(object sender, EventArgs e) { UpdateValue(); UpdateUI(); }

        //保存代理按钮
        private void Button_Save_Proxy_Click(object sender, EventArgs e)
        {
            if (Save_ProxyServer() == 1) { UpdateValue(); UpdateUI(); }
        }

        //代理开关按钮
        private void Button_Enable_Proxy_Click(object sender, EventArgs e)
        {
            if (ProxyEnable == 1) { Set_ProxyEnable(0); }
            else { Set_ProxyEnable(1); }
            UpdateValue();
            UpdateUI();
        }

        private void Github_Release(object sender, LinkLabelLinkClickedEventArgs e) { Process.Start("https://github.com/yinleren6/WinRegTool/"); }

        private void TextBox_IP_TextChanged(object sender, EventArgs e) { log.Text = "未保存"; }

        private void TextBox_Port_TextChanged(object sender, EventArgs e) { log.Text = "未保存"; }


    }
}
