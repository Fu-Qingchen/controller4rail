using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using AForge.Video.DirectShow;
using System.Threading;
using System.Data.SqlClient;
using System.Globalization;

namespace HostComputerForRail
{
    public partial class Form1 : Form
    {
        private DateTime TimeStart = DateTime.Now;
        bool bool_start = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //系统信息部分
            timer_System.Start();

            //实时监控部分
            bool_haveCamera = comboBox_MonitorCamera_Load();

            //倾角仪传输部分
            comboBox_Inclinometer_Load();
            SerialPort_Inclinometer1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived1);
            SerialPort_Inclinometer2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived2);

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

        private void pictureBox_Start_Click(object sender, EventArgs e)
        {
            bool_start = true;
            timer_Main.Start();
        }

        private void pictureBox_End_Click(object sender, EventArgs e)
        {
            bool_start = false;
            timer_Main.Stop();
        }

        private void timer_Main_Tick(object sender, EventArgs e)
        {
            if (bool_start)
            {
                //TODO: 刷新数据
                label_Inclinometer1_Ax.Text = a[0,0] + "";
                label_Inclinometer1_Ay.Text = a[0,1] + "";
                label_Inclinometer1_Az.Text = a[0,2] + "";
                label_Inclinometer1_THETAx.Text = Angle[0,0] + "";
                label_Inclinometer1_THETAy.Text = Angle[0,1] + "";
                label_Inclinometer1_THETAz.Text = Angle[0,2] + "";
                label_Inclinometer2_Ax.Text = a[1, 0] + "";
                label_Inclinometer2_Ay.Text = a[1, 1] + "";
                label_Inclinometer2_Az.Text = a[1, 2] + "";
                label_Inclinometer2_THETAx.Text = Angle[1, 0] + "";
                label_Inclinometer2_THETAy.Text = Angle[1, 1] + "";
                label_Inclinometer2_THETAz.Text = Angle[1, 2] + "";
                label_IncrementalTime.Text = (DateTime.Now - TimeStart).TotalMilliseconds / 1000 + "";
                if(!((a[0, 0] == 0 && a[0, 1] == 0 && a[0, 2] == 0 && Angle[0, 0] == 0 && Angle[0, 1] == 0 && Angle[0, 2] == 0)|| 
                    (a[1, 0] == 0 && a[1, 1] == 0 && a[1, 2] == 0 && Angle[1, 0] == 0 && Angle[1, 1] == 0 && Angle[1, 2] == 0)))
                {
                    chart1_Run();
                    statusStrip_Bottom.BackColor =
                        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(20)))));
                    SQLconnect();
                }
            }
        }

        /*
         * —————————————————————————————————————————数据库传输部分——————————————————————————————————————————
         */
        private string sqlDate;

        private void SQLconnect()
        {
            string connsql = "server=FU-QINGCHEN\\SQLEXPRESS;integrated security=SSPI;database=Test";
            try
            {
                using (SqlConnection mySQL = new SqlConnection())
                {
                    mySQL.ConnectionString = connsql;
                    // 打开数据库连接
                    mySQL.Open();
                    // 向数据库中插入数据
                    var format = "yyyy-MM-dd HH:mm:ss:fffffff";
                    var stringDate = DateTime.Now.ToString(format);
                    var convertedBack = DateTime.ParseExact(stringDate, format, CultureInfo.InvariantCulture);
                    sqlDate = "insert Inclination_OriginDate(DateTime,"
                        + "Accelerate1_X,Accelerate1_Y,Accelerate1_Z," + "Inclination1_X,Inclination1_Y,Inclination1_Z,"
                        + "Accelerate2_X,Accelerate2_Y,Accelerate2_Z," + "Inclination2_X,Inclination2_Y,Inclination2_Z"
                        + ")values(SYSDATETIME(),"
                        + a[0, 0] + "," + a[0, 1] + "," + a[0, 2] + "," + Angle[0, 0] + "," + Angle[0, 1] + "," + Angle[0, 2] + ","
                        + a[1, 0] + "," + a[1, 1] + "," + a[1, 2] + "," + Angle[1, 0] + "," + Angle[1, 1] + "," + Angle[1, 2]
                        + ")";
                    // 建立一个命令
                    SqlCommand sqlCommand = new SqlCommand(sqlDate, mySQL);
                    // 执行命令
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel_SQL.Text = "错误：" + ex.Message;
            }
            finally
            {
                toolStripStatusLabel_SQL.Text = "数据库已连接";
            }
        }

        /*
         * —————————————————————————————————————————倾角仪传输部分——————————————————————————————————————————
         */
        private bool bool_Inclinometer1 = false, bool_Inclinometer2 = false;
        string[] serialPortName;
        SerialPort SerialPort_Inclinometer1 = new SerialPort();
        SerialPort SerialPort_Inclinometer2 = new SerialPort();
        double[,] a = new double[2, 3], Angle = new double[2, 3];
        int serialPortNumber;

        //查询串口并加载
        private void comboBox_Inclinometer_Load()
        {
            serialPortName = SerialPort.GetPortNames();
            if(serialPortName == null)
            {
                toolStripStatusLabel_Inclinometer.Text = "无串口连接";
            }
            else
            {
                foreach(string name in serialPortName)
                {
                    comboBox_Inclinometer1.Items.Add(name);
                    comboBox_Inclinometer1.SelectedIndex = -1;
                    comboBox_Inclinometer2.Items.Add(name);
                    comboBox_Inclinometer2.SelectedIndex = -1;
                }
                toolStripStatusLabel_Inclinometer.Text = "请选择倾角仪串口";
            }
            SerialPort_Inclinometer1.BaudRate = 115200;
            SerialPort_Inclinometer2.BaudRate = 115200;
        }

        //关闭串口，释放资源
        private void serialPort_Close(SerialPort serialPort)
        {
            if (serialPort.IsOpen == true)
            {
                serialPort.Dispose();
                serialPort.Close();
            }
        }

        private void comboBox_Inclinometer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Inclinometer1.SelectedIndex >= 0)
            {
                SerialPort_Inclinometer1.PortName = serialPortName[comboBox_Inclinometer1.SelectedIndex];
            }

            bool_Inclinometer1 = true;
            if (bool_Inclinometer2 == true)
            {
                toolStripStatusLabel_Inclinometer.Text = "倾角仪已连接";
            }

            serialPort_Close(SerialPort_Inclinometer1);
            SerialPort_Inclinometer1.Open();

            //timer_Main.Start();
        }

        private void comboBox_Inclinometer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Inclinometer2.SelectedIndex >= 0)
            {
                SerialPort_Inclinometer2.PortName = serialPortName[comboBox_Inclinometer2.SelectedIndex];
            }

            bool_Inclinometer2 = true;
            if (bool_Inclinometer1 == true)
            {
                toolStripStatusLabel_Inclinometer.Text = "倾角仪已连接";
            }

            serialPort_Close(SerialPort_Inclinometer2);
            SerialPort_Inclinometer2.Open();
            //timer_Main.Start();
        }

        //以下获取串口数据部分, 改编于传感器厂商开源代码
        delegate void UpdateData1(byte[] byteData);//声明一个委托
        delegate void UpdateData2(byte[] byteData);//声明一个委托
        byte[] RxBuffer1 = new byte[1000];
        byte[] RxBuffer2 = new byte[1000];
        UInt16 usRxLength1 = 0;
        UInt16 usRxLength2 = 0;
        private double[] LastTime1 = new double[10];
        private double[] LastTime2 = new double[10];

        //接收数据
        private void SerialPort_DataReceived1(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] byteTemp = new byte[1000];
            UInt16 usLength = 0;
            usLength = (UInt16)SerialPort_Inclinometer1.Read(RxBuffer1, usRxLength1, 700);
            usRxLength1 += usLength;
            while (usRxLength1 >= 11)
            {
                UpdateData1 Update = new UpdateData1(DecodeData1);
                RxBuffer1.CopyTo(byteTemp, 0);
                if (!((byteTemp[0] == 0x55) & ((byteTemp[1] & 0x50) == 0x50)))
                {
                    for (int i = 1; i < usRxLength1; i++) RxBuffer1[i - 1] = RxBuffer1[i];
                    usRxLength1--;
                    continue;
                }
                if (((byteTemp[0] + byteTemp[1] + byteTemp[2] + byteTemp[3] + byteTemp[4] + byteTemp[5] + byteTemp[6] + byteTemp[7] + byteTemp[8] + byteTemp[9]) & 0xff) == byteTemp[10])
                    this.Invoke(Update, byteTemp);
                    for (int i = 11; i < usRxLength1; i++) RxBuffer1[i - 11] = RxBuffer1[i];
                    usRxLength1 -= 11;
                }
            Thread.Sleep(10);
        }
        private void SerialPort_DataReceived2(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] byteTemp = new byte[1000];
            UInt16 usLength = 0;
            usLength = (UInt16)SerialPort_Inclinometer2.Read(RxBuffer2, usRxLength2, 700);
            usRxLength2 += usLength;
            while (usRxLength2 >= 11)
            {
                UpdateData2 Update2 = new UpdateData2(DecodeData2);
                RxBuffer2.CopyTo(byteTemp, 0);
                if (!((byteTemp[0] == 0x55) & ((byteTemp[1] & 0x50) == 0x50)))
                {
                    for (int i = 1; i < usRxLength2; i++) RxBuffer2[i - 1] = RxBuffer2[i];
                    usRxLength2--;
                    continue;
                }
                if (((byteTemp[0] + byteTemp[1] + byteTemp[2] + byteTemp[3] + byteTemp[4] + byteTemp[5] + byteTemp[6] + byteTemp[7] + byteTemp[8] + byteTemp[9]) & 0xff) == byteTemp[10])
                    this.Invoke(Update2, byteTemp);
                for (int i = 11; i < usRxLength2; i++) RxBuffer2[i - 11] = RxBuffer2[i];
                usRxLength2 -= 11;
            }
            Thread.Sleep(10);
        }

        //解码数据
        private void DecodeData1(byte[] byteTemp)
        {
            serialPortNumber = 0;
            double[] Data = new double[4];
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds / 1000;

            Data[0] = BitConverter.ToInt16(byteTemp, 2);
            Data[1] = BitConverter.ToInt16(byteTemp, 4);
            Data[2] = BitConverter.ToInt16(byteTemp, 6);
            Data[3] = BitConverter.ToInt16(byteTemp, 8);

            switch (byteTemp[1])
            {
                case 0x51:  //加速度输出
                    Data[0] = Data[0] / 32768.0 * 16;
                    Data[1] = Data[1] / 32768.0 * 16;
                    Data[2] = Data[2] / 32768.0 * 16;

                    a[serialPortNumber,0] = Data[0];
                    a[serialPortNumber,1] = Data[1];
                    a[serialPortNumber,2] = Data[2];
                    if ((TimeElapse - LastTime1[1]) < 0.1) return;
                    LastTime1[1] = TimeElapse;
                    break;
                case 0x53:  //角度输出
                    Data[0] = Data[0] / 32768.0 * 180;
                    Data[1] = Data[1] / 32768.0 * 180;
                    Data[2] = Data[2] / 32768.0 * 180;
                    Angle[serialPortNumber,0] = Data[0];
                    Angle[serialPortNumber,1] = Data[1];
                    Angle[serialPortNumber,2] = Data[2];
                    if ((TimeElapse - LastTime1[3]) < 0.1) return;
                    LastTime1[3] = TimeElapse;
                    break;
                default:
                    break;
            }
        }
        private void DecodeData2(byte[] byteTemp)
        {
            serialPortNumber = 1;
            double[] Data = new double[4];
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds / 1000;

            Data[0] = BitConverter.ToInt16(byteTemp, 2);
            Data[1] = BitConverter.ToInt16(byteTemp, 4);
            Data[2] = BitConverter.ToInt16(byteTemp, 6);
            Data[3] = BitConverter.ToInt16(byteTemp, 8);

            switch (byteTemp[1])
            {
                case 0x51:  //加速度输出
                    Data[0] = Data[0] / 32768.0 * 16;
                    Data[1] = Data[1] / 32768.0 * 16;
                    Data[2] = Data[2] / 32768.0 * 16;

                    a[serialPortNumber,0] = Data[0];
                    a[serialPortNumber,1] = Data[1];
                    a[serialPortNumber,2] = Data[2];
                    if ((TimeElapse - LastTime2[1]) < 0.1) return;
                    LastTime2[1] = TimeElapse;
                    break;
                case 0x53:  //角度输出
                    Data[0] = Data[0] / 32768.0 * 180;
                    Data[1] = Data[1] / 32768.0 * 180;
                    Data[2] = Data[2] / 32768.0 * 180;
                    Angle[serialPortNumber,0] = Data[0];
                    Angle[serialPortNumber,1] = Data[1];
                    Angle[serialPortNumber,2] = Data[2];
                    if ((TimeElapse - LastTime2[3]) < 0.1) return;
                    LastTime2[3] = TimeElapse;
                    break;
                default:
                    break;
            }
        }

        /*
         * ————————————————————————————————————————————实时监控部分————————————————————————————————————————————
         */

        private bool bool_haveCamera;    //判断是否有可用的摄像头
        private FilterInfoCollection VideoInputDeviceCollection;    //调出所有可用设备
        private VideoCaptureDevice VideoCaptureDevice;  //视频源

        //获取所有摄像机, 并把它加载在 comboBox 控件上 
        public bool comboBox_MonitorCamera_Load()
        {
            VideoInputDeviceCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoInputDevice in VideoInputDeviceCollection)
            {
                comboBox_MonitorCamera.Items.Add(VideoInputDevice.Name);
                comboBox_MonitorCamera.SelectedIndex = -1;
            }
            if (VideoInputDeviceCollection.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void comboBox_MonitorCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VideoInputDeviceCollection.Count != 0 && comboBox_MonitorCamera.SelectedIndex >= 0)
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
        private void chart1_Run()
        {
            chart1.Series[0].Points.AddXY(DateTime.Now.Millisecond.ToString(),a[0,1]);
            chart1.Series[1].Points.AddXY(DateTime.Now.Millisecond.ToString(), a[1,1]);
            chart1.Series[2].Points.AddXY(DateTime.Now.Millisecond.ToString(), a[0,2]);
            chart1.Series[3].Points.AddXY(DateTime.Now.Millisecond.ToString(), a[1,2]);
            chart1.Series[4].Points.AddXY(DateTime.Now.Millisecond.ToString(), Angle[0,0]);
            chart1.Series[5].Points.AddXY(DateTime.Now.Millisecond.ToString(), Angle[1,0]);
            if (chart1.Series[0].Points.Count >= 400)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Series[2].Points.RemoveAt(0);
                chart1.Series[3].Points.RemoveAt(0);
                chart1.Series[4].Points.RemoveAt(0);
                chart1.Series[5].Points.RemoveAt(0);
            }
        }

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

        private void timer_System_Tick(object sender, EventArgs e)
        {
            label_SystemTime.Text = DateTime.Now + "";
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
