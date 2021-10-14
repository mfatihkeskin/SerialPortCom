
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
            this.cBox_ComPort = new System.Windows.Forms.ComboBox();
            this.cBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.cBox_DataBits = new System.Windows.Forms.ComboBox();
            this.cBox_StopBits = new System.Windows.Forms.ComboBox();
            this.cBox_ParityBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(31, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cBox_ComPort
            // 
            this.cBox_ComPort.FormattingEnabled = true;
            this.cBox_ComPort.Location = new System.Drawing.Point(198, 50);
            this.cBox_ComPort.Name = "cBox_ComPort";
            this.cBox_ComPort.Size = new System.Drawing.Size(122, 24);
            this.cBox_ComPort.TabIndex = 0;
            // 
            // cBox_BaudRate
            // 
            this.cBox_BaudRate.FormattingEnabled = true;
            this.cBox_BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBox_BaudRate.Location = new System.Drawing.Point(198, 80);
            this.cBox_BaudRate.Name = "cBox_BaudRate";
            this.cBox_BaudRate.Size = new System.Drawing.Size(122, 24);
            this.cBox_BaudRate.TabIndex = 1;
            // 
            // cBox_DataBits
            // 
            this.cBox_DataBits.FormattingEnabled = true;
            this.cBox_DataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBox_DataBits.Location = new System.Drawing.Point(198, 110);
            this.cBox_DataBits.Name = "cBox_DataBits";
            this.cBox_DataBits.Size = new System.Drawing.Size(122, 24);
            this.cBox_DataBits.TabIndex = 2;
            // 
            // cBox_StopBits
            // 
            this.cBox_StopBits.FormattingEnabled = true;
            this.cBox_StopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBox_StopBits.Location = new System.Drawing.Point(198, 140);
            this.cBox_StopBits.Name = "cBox_StopBits";
            this.cBox_StopBits.Size = new System.Drawing.Size(122, 24);
            this.cBox_StopBits.TabIndex = 3;
            // 
            // cBox_ParityBits
            // 
            this.cBox_ParityBits.FormattingEnabled = true;
            this.cBox_ParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBox_ParityBits.Location = new System.Drawing.Point(198, 170);
            this.cBox_ParityBits.Name = "cBox_ParityBits";
            this.cBox_ParityBits.Size = new System.Drawing.Size(122, 24);
            this.cBox_ParityBits.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BİTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BİTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARİTY BİTS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 16);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 31);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(134, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 27);
            this.progressBar1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(49, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(308, 273);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(69, 96);
            this.btnSendData.TabIndex = 5;
            this.btnSendData.Text = "SEND DATA";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(389, 48);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(240, 321);
            this.tBoxDataOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 402);
            this.Controls.Add(this.tBoxDataOut);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "COM PORT SERİAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}

