namespace HostComputerForRail
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip_bottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_State = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Camera = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Inclinometer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_MotionDetector = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_SQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Name = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.statusStrip_Left = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ControlCenter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_OriginData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_DataSolve = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.panel_OriginData = new System.Windows.Forms.Panel();
            this.statusStrip_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.statusStrip_Left.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip_bottom
            // 
            this.statusStrip_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.statusStrip_bottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_State,
            this.toolStripStatusLabel_Camera,
            this.toolStripStatusLabel_Inclinometer,
            this.toolStripStatusLabel_MotionDetector,
            this.toolStripStatusLabel_SQL});
            this.statusStrip_bottom.Location = new System.Drawing.Point(0, 1053);
            this.statusStrip_bottom.Name = "statusStrip_bottom";
            this.statusStrip_bottom.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip_bottom.Size = new System.Drawing.Size(1924, 25);
            this.statusStrip_bottom.TabIndex = 3;
            this.statusStrip_bottom.Text = "准备";
            // 
            // toolStripStatusLabel_State
            // 
            this.toolStripStatusLabel_State.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_State.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel_State.Image")));
            this.toolStripStatusLabel_State.Name = "toolStripStatusLabel_State";
            this.toolStripStatusLabel_State.Size = new System.Drawing.Size(125, 20);
            this.toolStripStatusLabel_State.Text = "系统连接出错";
            // 
            // toolStripStatusLabel_Camera
            // 
            this.toolStripStatusLabel_Camera.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_Camera.Name = "toolStripStatusLabel_Camera";
            this.toolStripStatusLabel_Camera.Size = new System.Drawing.Size(137, 20);
            this.toolStripStatusLabel_Camera.Text = "监控摄像头未连接";
            // 
            // toolStripStatusLabel_Inclinometer
            // 
            this.toolStripStatusLabel_Inclinometer.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_Inclinometer.Name = "toolStripStatusLabel_Inclinometer";
            this.toolStripStatusLabel_Inclinometer.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel_Inclinometer.Text = "倾角仪未连接";
            // 
            // toolStripStatusLabel_MotionDetector
            // 
            this.toolStripStatusLabel_MotionDetector.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_MotionDetector.Name = "toolStripStatusLabel_MotionDetector";
            this.toolStripStatusLabel_MotionDetector.Size = new System.Drawing.Size(137, 20);
            this.toolStripStatusLabel_MotionDetector.Text = "位移传感器未连接";
            // 
            // toolStripStatusLabel_SQL
            // 
            this.toolStripStatusLabel_SQL.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_SQL.Name = "toolStripStatusLabel_SQL";
            this.toolStripStatusLabel_SQL.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel_SQL.Text = "数据库未连接";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(100, 19);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(517, 28);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "基于子母机协同的高效铁轨检修机 - 武汉理工大学ICADCS";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.ErrorImage")));
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.InitialImage")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(55, 19);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(39, 35);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 1;
            this.pictureBox_Logo.TabStop = false;
            // 
            // statusStrip_Left
            // 
            this.statusStrip_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.statusStrip_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusStrip_Left.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Left.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip_Left.Location = new System.Drawing.Point(0, 0);
            this.statusStrip_Left.Name = "statusStrip_Left";
            this.statusStrip_Left.Size = new System.Drawing.Size(22, 1053);
            this.statusStrip_Left.TabIndex = 6;
            this.statusStrip_Left.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 321);
            this.toolStripStatusLabel1.Text = "                                                                              ";
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(20, 0);
            this.toolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(20, 73);
            this.toolStripStatusLabel3.Text = "━━━━━━━━";
            this.toolStripStatusLabel3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(20, 97);
            this.toolStripStatusLabel6.Text = "                      ";
            this.toolStripStatusLabel6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(20, 73);
            this.toolStripStatusLabel7.Text = "━━━━━━━━";
            this.toolStripStatusLabel7.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripStatusLabel7.Click += new System.EventHandler(this.toolStripStatusLabel7_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(20, 93);
            this.toolStripStatusLabel4.Text = "                     ";
            this.toolStripStatusLabel4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(20, 73);
            this.toolStripStatusLabel5.Text = "━━━━━━━━";
            this.toolStripStatusLabel5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel_ControlCenter,
            this.toolStripStatusLabel12,
            this.toolStripStatusLabel11,
            this.toolStripStatusLabel_OriginData,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel_DataSolve});
            this.statusStrip1.Location = new System.Drawing.Point(22, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(22, 1053);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip2";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(20, 325);
            this.toolStripStatusLabel8.Text = "                                                                               ";
            this.toolStripStatusLabel8.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel_ControlCenter
            // 
            this.toolStripStatusLabel_ControlCenter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel_ControlCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.toolStripStatusLabel_ControlCenter.Name = "toolStripStatusLabel_ControlCenter";
            this.toolStripStatusLabel_ControlCenter.Size = new System.Drawing.Size(20, 73);
            this.toolStripStatusLabel_ControlCenter.Text = "控制中心";
            this.toolStripStatusLabel_ControlCenter.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripStatusLabel_ControlCenter.Click += new System.EventHandler(this.toolStripStatusLabel_ControlCenter_Click_1);
            this.toolStripStatusLabel_ControlCenter.MouseEnter += new System.EventHandler(this.toolStripStatusLabel_ControlCenter_MouseEnter);
            this.toolStripStatusLabel_ControlCenter.MouseLeave += new System.EventHandler(this.toolStripStatusLabel_ControlCenter_MouseLeave);
            // 
            // toolStripStatusLabel12
            // 
            this.toolStripStatusLabel12.Name = "toolStripStatusLabel12";
            this.toolStripStatusLabel12.Size = new System.Drawing.Size(20, 0);
            this.toolStripStatusLabel12.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(20, 93);
            this.toolStripStatusLabel11.Text = "                     ";
            this.toolStripStatusLabel11.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel_OriginData
            // 
            this.toolStripStatusLabel_OriginData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.toolStripStatusLabel_OriginData.Name = "toolStripStatusLabel_OriginData";
            this.toolStripStatusLabel_OriginData.Size = new System.Drawing.Size(20, 73);
            this.toolStripStatusLabel_OriginData.Text = "原始数据";
            this.toolStripStatusLabel_OriginData.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripStatusLabel_OriginData.Click += new System.EventHandler(this.toolStripStatusLabel_OriginData_Click);
            this.toolStripStatusLabel_OriginData.MouseEnter += new System.EventHandler(this.toolStripStatusLabel_OriginData_MouseEnter);
            this.toolStripStatusLabel_OriginData.MouseLeave += new System.EventHandler(this.toolStripStatusLabel_OriginData_MouseLeave);
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(20, 93);
            this.toolStripStatusLabel9.Text = "                     ";
            this.toolStripStatusLabel9.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel_DataSolve
            // 
            this.toolStripStatusLabel_DataSolve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.toolStripStatusLabel_DataSolve.Name = "toolStripStatusLabel_DataSolve";
            this.toolStripStatusLabel_DataSolve.Size = new System.Drawing.Size(20, 73);
            this.toolStripStatusLabel_DataSolve.Text = "数据处理";
            this.toolStripStatusLabel_DataSolve.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripStatusLabel_DataSolve.Click += new System.EventHandler(this.toolStripStatusLabel_DataSolve_Click);
            this.toolStripStatusLabel_DataSolve.MouseEnter += new System.EventHandler(this.toolStripStatusLabel_DataSolve_MouseEnter);
            this.toolStripStatusLabel_DataSolve.MouseLeave += new System.EventHandler(this.toolStripStatusLabel_DataSolve_MouseLeave);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(1874, 29);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 8;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Min.Image")));
            this.pictureBox_Min.Location = new System.Drawing.Point(1843, 29);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Min.TabIndex = 9;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel_OriginData
            // 
            this.panel_OriginData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel_OriginData.Location = new System.Drawing.Point(82, 74);
            this.panel_OriginData.Name = "panel_OriginData";
            this.panel_OriginData.Size = new System.Drawing.Size(1842, 976);
            this.panel_OriginData.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1924, 1078);
            this.Controls.Add(this.panel_OriginData);
            this.Controls.Add(this.pictureBox_Min);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.statusStrip_Left);
            this.Controls.Add(this.statusStrip_bottom);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pictureBox_Logo);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2160, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
            this.Name = "Form1";
            this.Text = "基于子母机协同的高效铁轨检修机控制中心";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip_bottom.ResumeLayout(false);
            this.statusStrip_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.statusStrip_Left.ResumeLayout(false);
            this.statusStrip_Left.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip_bottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Camera;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Inclinometer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_MotionDetector;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_SQL;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_State;
        private System.Windows.Forms.StatusStrip statusStrip_Left;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ControlCenter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel12;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_OriginData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DataSolve;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Min;
        private System.Windows.Forms.Panel panel_OriginData;
    }
}

