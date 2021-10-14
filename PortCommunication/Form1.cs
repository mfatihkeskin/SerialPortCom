using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PortCommunication
{
    public partial class Form1 : Form
    {
        string dataOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBox_ComPort.Items.AddRange(ports);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBox_ComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBox_BaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBox_DataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBox_StopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBox_ParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = tBoxDataOut.Text;
                serialPort1.WriteLine(dataOut);
            }
        }
    }
}
