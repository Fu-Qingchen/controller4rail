namespace SerialCommunication
{
    partial class Form_Serial
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Serial));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.gpbSend = new System.Windows.Forms.GroupBox();
            this.rbSendStr = new System.Windows.Forms.RadioButton();
            this.rbSend16 = new System.Windows.Forms.RadioButton();
            this.gpbReceive = new System.Windows.Forms.GroupBox();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcv16 = new System.Windows.Forms.RadioButton();
            this.cbTimeSend = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRcv = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Save = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.timeSend = new System.Windows.Forms.Timer(this.components);
            this.cbSendHex = new System.Windows.Forms.CheckBox();
            this.txtStrTo16 = new System.Windows.Forms.TextBox();
            this.btnSendCRC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.send_num = new System.Windows.Forms.Label();
            this.Rcvnum = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tsSpNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button6 = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.gpbSend.SuspendLayout();
            this.gpbReceive.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口：";
            // 
            // cbSerial
            // 
            this.cbSerial.BackColor = System.Drawing.Color.White;
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerial.ForeColor = System.Drawing.Color.Black;
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(80, 107);
            this.cbSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(136, 28);
            this.cbSerial.TabIndex = 1;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSwitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(564, 102);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(127, 32);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "打开串口";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(697, 102);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "波特率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "停止位：";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.BackColor = System.Drawing.Color.White;
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudRate.ForeColor = System.Drawing.Color.Black;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(83, 159);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(132, 28);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.CbBaudRate_SelectedIndexChanged);
            // 
            // cbStop
            // 
            this.cbStop.BackColor = System.Drawing.Color.White;
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStop.ForeColor = System.Drawing.Color.Black;
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(362, 159);
            this.cbStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(132, 28);
            this.cbStop.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(568, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "校验位：";
            // 
            // cbDataBits
            // 
            this.cbDataBits.BackColor = System.Drawing.Color.White;
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBits.ForeColor = System.Drawing.Color.Black;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(362, 107);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(132, 28);
            this.cbDataBits.TabIndex = 10;
            // 
            // cbParity
            // 
            this.cbParity.BackColor = System.Drawing.Color.White;
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParity.ForeColor = System.Drawing.Color.Black;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(650, 159);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(132, 28);
            this.cbParity.TabIndex = 11;
            // 
            // gpbSend
            // 
            this.gpbSend.Controls.Add(this.rbSendStr);
            this.gpbSend.Controls.Add(this.rbSend16);
            this.gpbSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSend.ForeColor = System.Drawing.Color.White;
            this.gpbSend.Location = new System.Drawing.Point(21, 200);
            this.gpbSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSend.Name = "gpbSend";
            this.gpbSend.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSend.Size = new System.Drawing.Size(181, 51);
            this.gpbSend.TabIndex = 12;
            this.gpbSend.TabStop = false;
            this.gpbSend.Text = "发送数据格式";
            // 
            // rbSendStr
            // 
            this.rbSendStr.AutoSize = true;
            this.rbSendStr.ForeColor = System.Drawing.Color.White;
            this.rbSendStr.Location = new System.Drawing.Point(101, 22);
            this.rbSendStr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSendStr.Name = "rbSendStr";
            this.rbSendStr.Size = new System.Drawing.Size(78, 24);
            this.rbSendStr.TabIndex = 1;
            this.rbSendStr.TabStop = true;
            this.rbSendStr.Text = "字符串";
            this.rbSendStr.UseVisualStyleBackColor = true;
            // 
            // rbSend16
            // 
            this.rbSend16.AutoSize = true;
            this.rbSend16.ForeColor = System.Drawing.Color.White;
            this.rbSend16.Location = new System.Drawing.Point(8, 22);
            this.rbSend16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSend16.Name = "rbSend16";
            this.rbSend16.Size = new System.Drawing.Size(78, 24);
            this.rbSend16.TabIndex = 0;
            this.rbSend16.TabStop = true;
            this.rbSend16.Text = "16进制";
            this.rbSend16.UseVisualStyleBackColor = true;
            this.rbSend16.CheckedChanged += new System.EventHandler(this.rbSend16_CheckedChanged);
            // 
            // gpbReceive
            // 
            this.gpbReceive.Controls.Add(this.rbRcvStr);
            this.gpbReceive.Controls.Add(this.rbRcv16);
            this.gpbReceive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbReceive.ForeColor = System.Drawing.Color.White;
            this.gpbReceive.Location = new System.Drawing.Point(245, 200);
            this.gpbReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbReceive.Name = "gpbReceive";
            this.gpbReceive.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbReceive.Size = new System.Drawing.Size(181, 51);
            this.gpbReceive.TabIndex = 13;
            this.gpbReceive.TabStop = false;
            this.gpbReceive.Text = "接收数据格式";
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.ForeColor = System.Drawing.Color.White;
            this.rbRcvStr.Location = new System.Drawing.Point(101, 22);
            this.rbRcvStr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(78, 24);
            this.rbRcvStr.TabIndex = 1;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符串";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            // 
            // rbRcv16
            // 
            this.rbRcv16.AutoSize = true;
            this.rbRcv16.ForeColor = System.Drawing.Color.White;
            this.rbRcv16.Location = new System.Drawing.Point(8, 22);
            this.rbRcv16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRcv16.Name = "rbRcv16";
            this.rbRcv16.Size = new System.Drawing.Size(78, 24);
            this.rbRcv16.TabIndex = 0;
            this.rbRcv16.TabStop = true;
            this.rbRcv16.Text = "16进制";
            this.rbRcv16.UseVisualStyleBackColor = true;
            // 
            // cbTimeSend
            // 
            this.cbTimeSend.AutoSize = true;
            this.cbTimeSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeSend.ForeColor = System.Drawing.Color.White;
            this.cbTimeSend.Location = new System.Drawing.Point(460, 223);
            this.cbTimeSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTimeSend.Name = "cbTimeSend";
            this.cbTimeSend.Size = new System.Drawing.Size(127, 24);
            this.cbTimeSend.TabIndex = 14;
            this.cbTimeSend.Text = "定时发送数据";
            this.cbTimeSend.UseVisualStyleBackColor = true;
            this.cbTimeSend.CheckedChanged += new System.EventHandler(this.cbTimeSend_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(609, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "时间间隔：";
            // 
            // txtSecond
            // 
            this.txtSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSecond.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.ForeColor = System.Drawing.Color.White;
            this.txtSecond.Location = new System.Drawing.Point(697, 221);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 27);
            this.txtSecond.TabIndex = 16;
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecond_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(802, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "发送数据：";
            // 
            // txtSend
            // 
            this.txtSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.ForeColor = System.Drawing.Color.White;
            this.txtSend.Location = new System.Drawing.Point(21, 287);
            this.txtSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSend.Size = new System.Drawing.Size(496, 108);
            this.txtSend.TabIndex = 19;
            this.txtSend.Text = "01 03 00 00 00 01 84 0A";
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtRcv);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(850, 107);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(481, 409);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收方";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "接收数据";
            this.label14.Click += new System.EventHandler(this.Label14_Click_1);
            // 
            // txtRcv
            // 
            this.txtRcv.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRcv.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtRcv.Location = new System.Drawing.Point(0, 21);
            this.txtRcv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRcv.Name = "txtRcv";
            this.txtRcv.Size = new System.Drawing.Size(480, 355);
            this.txtRcv.TabIndex = 0;
            this.txtRcv.Text = "";
            this.txtRcv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRcv_MouseClick);
            this.txtRcv.TextChanged += new System.EventHandler(this.txtRcv_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(376, 378);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 30);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "清空接收框";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.Location = new System.Drawing.Point(571, 496);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "（不用写.txt等后缀）";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(761, 452);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(555, 440);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "保存文件名：";
            // 
            // txt_Save
            // 
            this.txt_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Save.ForeColor = System.Drawing.Color.White;
            this.txt_Save.Location = new System.Drawing.Point(558, 458);
            this.txt_Save.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Save.Name = "txt_Save";
            this.txt_Save.Size = new System.Drawing.Size(176, 27);
            this.txt_Save.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(761, 380);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 30);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(429, 468);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 30);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Press);
            // 
            // timeSend
            // 
            this.timeSend.Tick += new System.EventHandler(this.timeSend_Tick);
            // 
            // cbSendHex
            // 
            this.cbSendHex.AutoSize = true;
            this.cbSendHex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSendHex.ForeColor = System.Drawing.Color.White;
            this.cbSendHex.Location = new System.Drawing.Point(21, 412);
            this.cbSendHex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSendHex.Name = "cbSendHex";
            this.cbSendHex.Size = new System.Drawing.Size(191, 24);
            this.cbSendHex.TabIndex = 25;
            this.cbSendHex.Text = "显示此字符串的16进制";
            this.cbSendHex.UseVisualStyleBackColor = true;
            this.cbSendHex.CheckedChanged += new System.EventHandler(this.cbSendHex_CheckedChanged);
            // 
            // txtStrTo16
            // 
            this.txtStrTo16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtStrTo16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrTo16.ForeColor = System.Drawing.Color.White;
            this.txtStrTo16.Location = new System.Drawing.Point(22, 437);
            this.txtStrTo16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStrTo16.Name = "txtStrTo16";
            this.txtStrTo16.ReadOnly = true;
            this.txtStrTo16.Size = new System.Drawing.Size(496, 27);
            this.txtStrTo16.TabIndex = 26;
            // 
            // btnSendCRC
            // 
            this.btnSendCRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSendCRC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCRC.ForeColor = System.Drawing.Color.White;
            this.btnSendCRC.Location = new System.Drawing.Point(21, 468);
            this.btnSendCRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCRC.Name = "btnSendCRC";
            this.btnSendCRC.Size = new System.Drawing.Size(144, 30);
            this.btnSendCRC.TabIndex = 27;
            this.btnSendCRC.Text = "添加CRC校验发送";
            this.btnSendCRC.UseVisualStyleBackColor = false;
            this.btnSendCRC.Click += new System.EventHandler(this.btnSendCRC_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(825, 507);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 28;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(172, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "读取已有文件";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(166, 502);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "（默认为demo_try.txt）";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(300, 468);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 31;
            this.button2.Text = "清空发送框";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(414, 504);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "（快捷键为Enter键）";
            // 
            // send_num
            // 
            this.send_num.AutoSize = true;
            this.send_num.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_num.ForeColor = System.Drawing.Color.White;
            this.send_num.Location = new System.Drawing.Point(558, 288);
            this.send_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.send_num.Name = "send_num";
            this.send_num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.send_num.Size = new System.Drawing.Size(133, 20);
            this.send_num.TabIndex = 33;
            this.send_num.Text = "已发送字节数 0个";
            this.send_num.Click += new System.EventHandler(this.label14_Click);
            // 
            // Rcvnum
            // 
            this.Rcvnum.AutoSize = true;
            this.Rcvnum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcvnum.ForeColor = System.Drawing.Color.White;
            this.Rcvnum.Location = new System.Drawing.Point(555, 332);
            this.Rcvnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rcvnum.Name = "Rcvnum";
            this.Rcvnum.Size = new System.Drawing.Size(133, 20);
            this.Rcvnum.TabIndex = 34;
            this.Rcvnum.Text = "已接收字节数 0个";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(761, 283);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 28);
            this.button4.TabIndex = 35;
            this.button4.Text = "清零";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(761, 327);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 28);
            this.button5.TabIndex = 36;
            this.button5.Text = "清零";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tsSpNum
            // 
            this.tsSpNum.Name = "tsSpNum";
            this.tsSpNum.Size = new System.Drawing.Size(0, 17);
            // 
            // tsBaudRate
            // 
            this.tsBaudRate.Name = "tsBaudRate";
            this.tsBaudRate.Size = new System.Drawing.Size(0, 17);
            // 
            // tsDataBits
            // 
            this.tsDataBits.Name = "tsDataBits";
            this.tsDataBits.Size = new System.Drawing.Size(0, 17);
            // 
            // tsStopBits
            // 
            this.tsStopBits.Name = "tsStopBits";
            this.tsStopBits.Size = new System.Drawing.Size(0, 17);
            // 
            // tsParity
            // 
            this.tsParity.Name = "tsParity";
            this.tsParity.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSpNum,
            this.tsBaudRate,
            this.tsDataBits,
            this.tsStopBits,
            this.tsParity});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1344, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(558, 380);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 30);
            this.button6.TabIndex = 38;
            this.button6.Text = "程序测试";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(66, 27);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(597, 28);
            this.label_Name.TabIndex = 40;
            this.label_Name.Text = "基于子母机协同的高效铁轨检修机操作平台 - 武汉理工大学ICADCS";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.ErrorImage")));
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.InitialImage")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(21, 27);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(39, 35);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 39;
            this.pictureBox_Logo.TabStop = false;
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Min.Image")));
            this.pictureBox_Min.Location = new System.Drawing.Point(1288, 27);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Min.TabIndex = 42;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.PictureBox_Min_Click);
            // 
            // Form_Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1344, 563);
            this.Controls.Add(this.pictureBox_Min);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Rcvnum);
            this.Controls.Add(this.txt_Save);
            this.Controls.Add(this.send_num);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSendCRC);
            this.Controls.Add(this.txtStrTo16);
            this.Controls.Add(this.cbSendHex);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTimeSend);
            this.Controls.Add(this.gpbReceive);
            this.Controls.Add(this.gpbSend);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStop);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.cbSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Serial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbSend.ResumeLayout(false);
            this.gpbSend.PerformLayout();
            this.gpbReceive.ResumeLayout(false);
            this.gpbReceive.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.GroupBox gpbSend;
        private System.Windows.Forms.RadioButton rbSendStr;
        private System.Windows.Forms.RadioButton rbSend16;
        private System.Windows.Forms.GroupBox gpbReceive;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcv16;
        private System.Windows.Forms.CheckBox cbTimeSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        //private System.Windows.Forms.ToolStripStatusLabel tsSend_num;
        //private System.Windows.Forms.ToolStripStatusLabel tsRcv_num;
        private System.Windows.Forms.Timer timeSend;
        private System.Windows.Forms.RichTextBox txtRcv;
        private System.Windows.Forms.CheckBox cbSendHex;
        private System.Windows.Forms.TextBox txtStrTo16;
        private System.Windows.Forms.Button btnSendCRC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Save;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label send_num;
        private System.Windows.Forms.Label Rcvnum;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripStatusLabel tsSpNum;
        private System.Windows.Forms.ToolStripStatusLabel tsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel tsDataBits;
        private System.Windows.Forms.ToolStripStatusLabel tsStopBits;
        private System.Windows.Forms.ToolStripStatusLabel tsParity;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.PictureBox pictureBox_Min;
    }
}

