
namespace PortCommunication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_ParityBits = new System.Windows.Forms.ComboBox();
            this.cBox_StopBits = new System.Windows.Forms.ComboBox();
            this.cBox_DataBits = new System.Windows.Forms.ComboBox();
            this.cBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.cBox_ComPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_ClearTxScreen = new System.Windows.Forms.Button();
            this.lbl_TxDataLength = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_TxDataLengthSize = new System.Windows.Forms.Label();
            this.grpbx_TxScreen = new System.Windows.Forms.GroupBox();
            this.grpbx_RxScreen = new System.Windows.Forms.GroupBox();
            this.tBox_DataInput = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBox_ShowBitByBit = new System.Windows.Forms.CheckBox();
            this.btn_ClearRxScreen = new System.Windows.Forms.Button();
            this.lbl_RxDataLengthSize = new System.Windows.Forms.Label();
            this.lbl_RxDataLength = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpbx_TxScreen.SuspendLayout();
            this.grpbx_RxScreen.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBox_ParityBits);
            this.groupBox1.Controls.Add(this.cBox_StopBits);
            this.groupBox1.Controls.Add(this.cBox_DataBits);
            this.groupBox1.Controls.Add(this.cBox_BaudRate);
            this.groupBox1.Controls.Add(this.cBox_ComPort);
            this.groupBox1.Location = new System.Drawing.Point(35, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Com Tools";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARİTY BİTS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BİTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BİTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // cBox_ParityBits
            // 
            this.cBox_ParityBits.FormattingEnabled = true;
            this.cBox_ParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBox_ParityBits.Location = new System.Drawing.Point(109, 166);
            this.cBox_ParityBits.Name = "cBox_ParityBits";
            this.cBox_ParityBits.Size = new System.Drawing.Size(122, 24);
            this.cBox_ParityBits.TabIndex = 4;
            // 
            // cBox_StopBits
            // 
            this.cBox_StopBits.FormattingEnabled = true;
            this.cBox_StopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBox_StopBits.Location = new System.Drawing.Point(109, 136);
            this.cBox_StopBits.Name = "cBox_StopBits";
            this.cBox_StopBits.Size = new System.Drawing.Size(122, 24);
            this.cBox_StopBits.TabIndex = 3;
            // 
            // cBox_DataBits
            // 
            this.cBox_DataBits.FormattingEnabled = true;
            this.cBox_DataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBox_DataBits.Location = new System.Drawing.Point(109, 106);
            this.cBox_DataBits.Name = "cBox_DataBits";
            this.cBox_DataBits.Size = new System.Drawing.Size(122, 24);
            this.cBox_DataBits.TabIndex = 2;
            // 
            // cBox_BaudRate
            // 
            this.cBox_BaudRate.FormattingEnabled = true;
            this.cBox_BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBox_BaudRate.Location = new System.Drawing.Point(109, 76);
            this.cBox_BaudRate.Name = "cBox_BaudRate";
            this.cBox_BaudRate.Size = new System.Drawing.Size(122, 24);
            this.cBox_BaudRate.TabIndex = 1;
            // 
            // cBox_ComPort
            // 
            this.cBox_ComPort.FormattingEnabled = true;
            this.cBox_ComPort.Location = new System.Drawing.Point(109, 46);
            this.cBox_ComPort.Name = "cBox_ComPort";
            this.cBox_ComPort.Size = new System.Drawing.Size(122, 24);
            this.cBox_ComPort.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(19, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 31);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(132, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 27);
            this.progressBar1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(35, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 14);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(113, 79);
            this.btnSendData.TabIndex = 5;
            this.btnSendData.Text = "SEND DATA";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(2, 20);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(228, 171);
            this.tBoxDataOut.TabIndex = 6;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBox_TxDataLengthSize_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_ClearTxScreen
            // 
            this.btn_ClearTxScreen.Location = new System.Drawing.Point(122, 14);
            this.btn_ClearTxScreen.Name = "btn_ClearTxScreen";
            this.btn_ClearTxScreen.Size = new System.Drawing.Size(113, 79);
            this.btn_ClearTxScreen.TabIndex = 7;
            this.btn_ClearTxScreen.Text = "CLEAR Tx SCREEN";
            this.btn_ClearTxScreen.UseVisualStyleBackColor = true;
            this.btn_ClearTxScreen.Click += new System.EventHandler(this.btn_ClearTxScreen_Click);
            // 
            // lbl_TxDataLength
            // 
            this.lbl_TxDataLength.AutoSize = true;
            this.lbl_TxDataLength.Location = new System.Drawing.Point(339, 239);
            this.lbl_TxDataLength.Name = "lbl_TxDataLength";
            this.lbl_TxDataLength.Size = new System.Drawing.Size(109, 17);
            this.lbl_TxDataLength.TabIndex = 9;
            this.lbl_TxDataLength.Text = "Tx Data Length:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ClearTxScreen);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Location = new System.Drawing.Point(300, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // lbl_TxDataLengthSize
            // 
            this.lbl_TxDataLengthSize.AutoSize = true;
            this.lbl_TxDataLengthSize.Location = new System.Drawing.Point(444, 239);
            this.lbl_TxDataLengthSize.Name = "lbl_TxDataLengthSize";
            this.lbl_TxDataLengthSize.Size = new System.Drawing.Size(35, 20);
            this.lbl_TxDataLengthSize.TabIndex = 12;
            this.lbl_TxDataLengthSize.Text = "0000";
            this.lbl_TxDataLengthSize.UseCompatibleTextRendering = true;
            this.lbl_TxDataLengthSize.Click += new System.EventHandler(this.lbl_TxDataLengthSize_Click);
            // 
            // grpbx_TxScreen
            // 
            this.grpbx_TxScreen.Controls.Add(this.tBoxDataOut);
            this.grpbx_TxScreen.Location = new System.Drawing.Point(306, 33);
            this.grpbx_TxScreen.Name = "grpbx_TxScreen";
            this.grpbx_TxScreen.Size = new System.Drawing.Size(235, 197);
            this.grpbx_TxScreen.TabIndex = 12;
            this.grpbx_TxScreen.TabStop = false;
            this.grpbx_TxScreen.Text = "Tx Screen";
            this.grpbx_TxScreen.Enter += new System.EventHandler(this.grpbx_TxScreen_Enter);
            // 
            // grpbx_RxScreen
            // 
            this.grpbx_RxScreen.Controls.Add(this.tBox_DataInput);
            this.grpbx_RxScreen.Location = new System.Drawing.Point(547, 33);
            this.grpbx_RxScreen.Name = "grpbx_RxScreen";
            this.grpbx_RxScreen.Size = new System.Drawing.Size(235, 197);
            this.grpbx_RxScreen.TabIndex = 13;
            this.grpbx_RxScreen.TabStop = false;
            this.grpbx_RxScreen.Text = "Rx Screen";
            this.grpbx_RxScreen.Enter += new System.EventHandler(this.grpbx_RxScreen_Enter);
            // 
            // tBox_DataInput
            // 
            this.tBox_DataInput.Location = new System.Drawing.Point(2, 20);
            this.tBox_DataInput.Multiline = true;
            this.tBox_DataInput.Name = "tBox_DataInput";
            this.tBox_DataInput.Size = new System.Drawing.Size(228, 171);
            this.tBox_DataInput.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBox_ShowBitByBit);
            this.groupBox6.Controls.Add(this.btn_ClearRxScreen);
            this.groupBox6.Location = new System.Drawing.Point(547, 259);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(233, 109);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            // 
            // chBox_ShowBitByBit
            // 
            this.chBox_ShowBitByBit.AutoSize = true;
            this.chBox_ShowBitByBit.Location = new System.Drawing.Point(6, 66);
            this.chBox_ShowBitByBit.Name = "chBox_ShowBitByBit";
            this.chBox_ShowBitByBit.Size = new System.Drawing.Size(192, 21);
            this.chBox_ShowBitByBit.TabIndex = 11;
            this.chBox_ShowBitByBit.Text = "Show Bit by Bit Rx Screen";
            this.chBox_ShowBitByBit.UseVisualStyleBackColor = true;
            this.chBox_ShowBitByBit.CheckedChanged += new System.EventHandler(this.chBox_ShowBitByBitRxScreen_CheckedChanged);
            // 
            // btn_ClearRxScreen
            // 
            this.btn_ClearRxScreen.Location = new System.Drawing.Point(6, 15);
            this.btn_ClearRxScreen.Name = "btn_ClearRxScreen";
            this.btn_ClearRxScreen.Size = new System.Drawing.Size(220, 45);
            this.btn_ClearRxScreen.TabIndex = 7;
            this.btn_ClearRxScreen.Text = "CLEAR Rx SCREEN";
            this.btn_ClearRxScreen.UseVisualStyleBackColor = true;
            this.btn_ClearRxScreen.Click += new System.EventHandler(this.btn_ClearRxScreen_Click);
            // 
            // lbl_RxDataLengthSize
            // 
            this.lbl_RxDataLengthSize.AutoSize = true;
            this.lbl_RxDataLengthSize.Location = new System.Drawing.Point(686, 239);
            this.lbl_RxDataLengthSize.Name = "lbl_RxDataLengthSize";
            this.lbl_RxDataLengthSize.Size = new System.Drawing.Size(40, 17);
            this.lbl_RxDataLengthSize.TabIndex = 10;
            this.lbl_RxDataLengthSize.Text = "0000";
            this.lbl_RxDataLengthSize.TextChanged += new System.EventHandler(this.lbl_RxDataLengthSize_TextChanged);
            // 
            // lbl_RxDataLength
            // 
            this.lbl_RxDataLength.AutoSize = true;
            this.lbl_RxDataLength.Location = new System.Drawing.Point(580, 239);
            this.lbl_RxDataLength.Name = "lbl_RxDataLength";
            this.lbl_RxDataLength.Size = new System.Drawing.Size(110, 17);
            this.lbl_RxDataLength.TabIndex = 9;
            this.lbl_RxDataLength.Text = "Rx Data Length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 404);
            this.Controls.Add(this.lbl_TxDataLengthSize);
            this.Controls.Add(this.lbl_RxDataLengthSize);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.lbl_RxDataLength);
            this.Controls.Add(this.lbl_TxDataLength);
            this.Controls.Add(this.grpbx_RxScreen);
            this.Controls.Add(this.grpbx_TxScreen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "COM PORT SERİAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpbx_TxScreen.ResumeLayout(false);
            this.grpbx_TxScreen.PerformLayout();
            this.grpbx_RxScreen.ResumeLayout(false);
            this.grpbx_RxScreen.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_ParityBits;
        private System.Windows.Forms.ComboBox cBox_StopBits;
        private System.Windows.Forms.ComboBox cBox_DataBits;
        private System.Windows.Forms.ComboBox cBox_BaudRate;
        private System.Windows.Forms.ComboBox cBox_ComPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_ClearTxScreen;
        private System.Windows.Forms.Label lbl_TxDataLength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpbx_TxScreen;
        private System.Windows.Forms.GroupBox grpbx_RxScreen;
        private System.Windows.Forms.TextBox tBox_DataInput;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_RxDataLengthSize;
        private System.Windows.Forms.Label lbl_RxDataLength;
        private System.Windows.Forms.Button btn_ClearRxScreen;
        private System.Windows.Forms.Label lbl_TxDataLengthSize;
        private System.Windows.Forms.CheckBox chBox_ShowBitByBit;
    }
}

