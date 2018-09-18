using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAPI.USB;
using Newtonsoft.Json;

namespace WindowsAPI
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            List<string> deviceList = new List<string>();
            Hid.GetHidDeviceList(ref deviceList);
            Console.WriteLine(deviceList);
        }

        /// <summary>
        /// 获取设备hid
        /// </summary>
        /// <returns></returns>
        public string GetHIDList() {
            List<string> deviceList = new List<string>();
            Hid.GetHidDeviceList(ref deviceList);
            return JsonConvert.SerializeObject(deviceList);
        }
        
    }
}
