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
        string dataInput;
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

            chBox_ShowBitByBit.Checked = false;//true olursa tek bit okuyacak
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
                serialPort1.WriteLine("");
            }
        }

        private void grpbx_TxScreen_Enter(object sender, EventArgs e) //Tx Screen
        {

        }

        private void btn_ClearTxScreen_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void grpbx_RxScreen_Enter(object sender, EventArgs e)
        {

        }

        private void tBox_TxDataLengthSize_TextChanged(object sender, EventArgs e)
        {
            //string formatını değiştirip int char için tek tek tanımlama yapılabilir
            int dataOutLength = tBoxDataOut.TextLength;
            lbl_TxDataLengthSize.Text = string.Format("{0:0000}", dataOutLength);
        }

        private void lbl_TxDataLengthSize_Click(object sender, EventArgs e)
        {

        }

        private void btn_ClearRxScreen_Click(object sender, EventArgs e)
        {
            if (tBox_DataInput.Text != "")
            {
                tBox_DataInput.Text = "";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataInput = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e) //yukarıdaki show data için
        {
            //string formatını değiştirip int char için tek tek tanımlama yapılabilir
            int dataInputLength = tBox_DataInput.TextLength;
            lbl_RxDataLengthSize.Text = string.Format("{0:0000}", dataInputLength);

            //load ekranında false bırakıldı. yazılan her karakteri görecek. Eğer bit bit okunmak istenirse açılacak.
            if (chBox_ShowBitByBit.Checked)
            {
                tBox_DataInput.Text = dataInput;
            }
            else
            {
                tBox_DataInput.Text += dataInput;
            }
        }

        private void chBox_ShowBitByBitRxScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_ShowBitByBit.Checked)
            {
                chBox_ShowBitByBit.Checked = true;
            }
        }

        private void lbl_RxDataLengthSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
