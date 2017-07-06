using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace ClientUSBDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getInfo_Click(object sender, EventArgs e)
        {
            //string PNPDeviceID = string.Empty;

            ////Предварительно очищаем список
            //listInfo.Items.Clear();

            ////Получение списка USB накопителей
            //foreach (System.Management.ManagementObject drive in
            // new System.Management.ManagementObjectSearcher(
            // "select * from Win32_USBHub where Caption='Запоминающее устройство для USB'").Get())
            //{
            //    PNPDeviceID = drive["PNPDeviceID"].ToString().Trim();
            //    //Получение Ven устройства
            //    listBox1.Items.Add("VID= " +
            //     parseVidFromDeviceID(drive["PNPDeviceID"].ToString().Trim()).Trim());

            //    //Получение Prod устройства
            //    listBox1.Items.Add("PID= " +
            //     parsePidFromDeviceID(drive["PNPDeviceID"].ToString().Trim()).Trim());

            //    //Получение Серийного номера устройства
            //    string[] splitDeviceId = drive["PNPDeviceID"].ToString().Trim().Split('\\');
            //    listBox1.Items.Add("Серийный номер= " + splitDeviceId[2].Trim());

            //    //Разделение списка устройств пустой строкой
            //    listBox1.Items.Add("");
            //}
        }
    }
}
