using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserComputeLab
{
    public partial class DebugIOConsole : Form
    {
        private ManagerCOM mcom;
        private SerialPort sp;
        private static string databuffer = String.Empty;
        public DebugIOConsole(ManagerCOM mcom, SerialPort sp)
        {
            this.mcom = mcom;
            this.sp = sp;
            this.sp.DataReceived += serialPort_DataReceived;
            this.sp.Open();
            InitializeComponent();
        }
        private void clearConsole_Click(object sender, EventArgs e) => consoletext.Text = String.Empty;
        private void sendData_to()
        {
            try
            {
                if (!sp.IsOpen) sp.Open();
                sp.WriteLine(dataInp.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось отправить данные на порт " + mcom.getPortname(), "Ошибка отправки данных");
            }
            dataInp.Text = "";
        }
        private void sendData_Click(object sender, EventArgs e) => sendData_to();
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (mcom != null) Invoke(new Action(() => consoletext.Text += mcom.getDataReceived()));
        }

        private void dataInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) sendData_to();
        }

        private void DebugIOConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.sp.DataReceived -= serialPort_DataReceived;
        }
    }
}
