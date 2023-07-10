using Microsoft.Win32;

namespace WinProxyTool.Utils
{
    internal class RegistryTool
    {

        private static string SubKey = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
        static readonly RegistryKey proxy = Registry.CurrentUser.OpenSubKey(SubKey, true);
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

        //Get_ProxyOverride
        public string Get_ProxyOverride()
        {
            string ProxyOverride = (string)proxy.GetValue("ProxyOverride");
            if (ProxyOverride == null) { return "null"; }
            else { return ProxyOverride; }
        }
        public void Clear_ProxyOverride() { proxy.SetValue("ProxyOverride", ""); }

    }
}
