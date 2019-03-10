using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace HostComputerForRail
{
    public partial class Form1 : Form
    {
        private bool bool_haveCamera;    //判断是否有可用的摄像头
        private FilterInfoCollection VideoInputDeviceCollection;    //调出所有可用设备
        private VideoCaptureDevice VideoCaptureDevice;  //

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //识别电脑上的监控摄像头
            bool_haveCamera = comboBox_MonitorCamera_Load();

            //底栏状态调整
            if (bool_haveCamera)
            {
                toolStripStatusLabel_Camera.Text = "请选择摄像头";
            }
            else
            {
                toolStripStatusLabel_Camera.Text = "无可用摄像头";
            }
        }

        /*
         * ————————————————————————————————————————————实时监控部分————————————————————————————————————————————
         */
        //获取所有摄像机, 并把它加载在 comboBox 控件上 
        public bool comboBox_MonitorCamera_Load()
        {
            VideoInputDeviceCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoInputDevice in VideoInputDeviceCollection)
            {
                comboBox_MonitorCamera.Items.Add(VideoInputDevice.Name);
                comboBox_MonitorCamera.SelectedIndex = 0;
            }
            if (VideoInputDeviceCollection.Count == 0)
            {
                return false;
            }
            else
            {
                //获取选择的摄像机
                VideoCaptureDevice = new VideoCaptureDevice
                    (VideoInputDeviceCollection[comboBox_MonitorCamera.SelectedIndex].MonikerString);
                return true;
            }
        }

        private void comboBox_MonitorCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VideoInputDeviceCollection.Count != 0)
            {
                VideoCaptureDevice = new VideoCaptureDevice
                    (VideoInputDeviceCollection[comboBox_MonitorCamera.SelectedIndex].MonikerString);
            }
        }

        private void button_MonitorCamera_Click(object sender, EventArgs e)
        {
            videoSourcePlayer_MonitorCamera.VideoSource = VideoCaptureDevice;
            videoSourcePlayer_MonitorCamera.Start();
            toolStripStatusLabel_Camera.Text = "摄像头已连接";
        }

        /*
         * ————————————————————————————————————————————UI界面设计————————————————————————————————————————————
         */

        private void toolStripStatusLabel_ControlCenter_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel_ControlCenter.ForeColor = 
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void toolStripStatusLabel_ControlCenter_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel_ControlCenter.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel_OriginData_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel_OriginData.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void toolStripStatusLabel_OriginData_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel_OriginData.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel_DataSolve_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel_DataSolve.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void toolStripStatusLabel_DataSolve_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel_DataSolve.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel_ControlCenter_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripStatusLabel_ControlCenter_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabel3.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            toolStripStatusLabel7.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            toolStripStatusLabel5.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.ForeColor = 
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            toolStripStatusLabel7.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            toolStripStatusLabel5.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel_OriginData_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel7.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            toolStripStatusLabel3.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            toolStripStatusLabel5.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel7_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel7.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            toolStripStatusLabel3.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            toolStripStatusLabel5.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel_DataSolve_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel5.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            toolStripStatusLabel7.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            toolStripStatusLabel3.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel5.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            toolStripStatusLabel7.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            toolStripStatusLabel3.ForeColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
        }
    }
}
