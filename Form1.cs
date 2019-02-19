using System;
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using UsbLibrary;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Data.SqlClient;
using System.Globalization;

namespace MiniIMU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitChart();
            //SQLConnect();
        }//构造函数，初始化组件

        double[] a = new double[4] , w = new double[4], h = new double[4], Angle = new double[4], Port = new double[4];
        double Temperature, Pressure, Altitude, GroundVelocity, GPSYaw, GPSHeight;
        long Longitude, Latitude;
        string sqlDate, sqlWriteDate;
        bool flag_Start = false;
        double Lg, H, Yl, Yr, Zl, Zr;//轨距,超高,左轨向,右轨向,左高度,右高度(SI)
        double[] Angle0_integration = {0,0}, a1_integration = { 0, 0 }, a2_integration = { 0, 0 };
        double[] v1_integration = { 0, 0 }, v2_integration = { 0, 0 };
        double[] y_integration = { 0, 0 }, z_integration = { 0, 0 };
        double fixA1 = 0, fixA2 = -0.008, fixAngle0 = 0,e = 0.002;  //这里要改
        int a_count = 0;

        private void SQLConnect()
        {
            //使用Windows身份打开数据库
            //string connsql = "server=FU-QINGCHEN\\SQLEXPRESS;user=sa;pwd=whuteducn;database=Test";
            string connsql = "server=FU-QINGCHEN\\SQLEXPRESS;integrated security=SSPI;database=Test";
            try
            {
                using (SqlConnection mySQL = new SqlConnection())
                {
                    mySQL.ConnectionString = connsql;
                    mySQL.Open(); // 打开数据库连接
                    //向数据库中插入数据
                    var format = "yyyy-MM-dd HH:mm:ss:fffffff";
                    var stringDate = DateTime.Now.ToString(format);
                    var convertedBack = DateTime.ParseExact(stringDate, format, CultureInfo.InvariantCulture);
                    sqlDate = "insert Inclination_OriginDate(DateTime,Accelerate_X,Accelerate_Y,Accelerate_Z,"
                        + "AngularVelocity_X,AngularVelocity_Y,AngularVelocity_Z,"
                        + "Inclination_X,Inclination_Y,Inclination_Z)" + "values(SYSDATETIME(),"
                        + a[0] + "," + a[1] + "," + a[2] + ","
                        + w[0] + "," + w[1] + "," + w[2] + ","
                        + Angle[0] + "," + Angle[1] + "," + Angle[2] + ")";
                    SqlCommand sqlCommand = new SqlCommand(sqlDate, mySQL);
                    sqlCommand.ExecuteNonQuery();
                    //向数据库查询数据
                    //sqlWriteDate = "SELECT TOP 2 * FROM Inclination_OriginDate ORDER BY ID DESC;";
                    //SqlCommand sqlWriteCommand = new SqlCommand(sqlWriteDate, mySQL);
                    //SqlDataReader sqlDataReader = sqlWriteCommand.ExecuteReader();
                    //int i = 0;
                    //while (sqlDataReader.Read())
                    //{
                    //    Angle0_integration[i] = Convert.ToDouble(sqlDataReader[8]);
                    //    a1_integration[i] = Convert.ToDouble(sqlDataReader[3]);
                    //   a2_integration[i] = Convert.ToDouble(sqlDataReader[4]);
                    //   i++;
                    //}
                    //sqlDataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息：" + ex.Message + "\n" + sqlDate, "出现错误");
            }
            finally
            {
                Status.Text = "SQL server connected";
            }
        }

        private void InitChart()
        {

            //加速度图表
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series11 = new Series("ax");
            series11.ChartArea = "C1";
            this.chart1.Series.Add(series11);
            Series series12 = new Series("ay");
            series12.ChartArea = "C1";
            this.chart1.Series.Add(series12);
            Series series13 = new Series("az");
            series13.ChartArea = "C1";
            this.chart1.Series.Add(series13);
            //设置图表显示样式
            this.chart1.Titles.Add("ax");
            this.chart1.Titles[0].Text = string.Format("加速度显示");
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[1].Color = Color.Orange;
            this.chart1.Series[2].Color = Color.Green;
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[1].ChartType = SeriesChartType.Line;
            this.chart1.Series[2].ChartType = SeriesChartType.Line;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //添加点
            this.chart1.Titles.Clear();
            this.chart1.Series[0].Points.Add(a[0]);
            this.chart1.Series[1].Points.Add(a[1]);
            this.chart1.Series[2].Points.Add(a[2]);
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();

            //角速度图表
            //定义图表区域
            this.chart2.ChartAreas.Clear();
            ChartArea chartArea2 = new ChartArea("C2");
            this.chart2.ChartAreas.Add(chartArea2);
            //定义存储和显示点的容器
            this.chart2.Series.Clear();
            Series series21 = new Series("wx");
            series21.ChartArea = "C2";
            this.chart2.Series.Add(series21);
            Series series22 = new Series("wy");
            series22.ChartArea = "C2";
            this.chart2.Series.Add(series22);
            Series series23 = new Series("wz");
            series23.ChartArea = "C2";
            this.chart2.Series.Add(series23);
            //设置图表显示样式
            this.chart2.Titles.Add("wx");
            this.chart2.Titles[0].Text = string.Format("角速度显示");
            this.chart2.Series[0].Color = Color.Red;
            this.chart2.Series[1].Color = Color.Orange;
            this.chart2.Series[2].Color = Color.Green;
            this.chart2.Series[0].ChartType = SeriesChartType.Line;
            this.chart2.Series[1].ChartType = SeriesChartType.Line;
            this.chart2.Series[2].ChartType = SeriesChartType.Line;
            this.chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //添加点
            this.chart2.Titles.Clear();
            this.chart2.Series[0].Points.Add(w[0]);
            this.chart2.Series[1].Points.Add(w[1]);
            this.chart2.Series[2].Points.Add(w[2]);
            this.chart2.Series[0].Points.Clear();
            this.chart2.Series[1].Points.Clear();
            this.chart2.Series[2].Points.Clear();

            //角速图表
            //定义图表区域
            this.chart3.ChartAreas.Clear();
            ChartArea chartArea3 = new ChartArea("C3");
            this.chart3.ChartAreas.Add(chartArea3);
            //定义存储和显示点的容器
            this.chart3.Series.Clear();
            Series series31 = new Series("Anglex");
            series31.ChartArea = "C3";
            this.chart3.Series.Add(series31);
            Series series32 = new Series("Angley");
            series32.ChartArea = "C3";
            this.chart3.Series.Add(series32);
            Series series33 = new Series("Anglez");
            series33.ChartArea = "C3";
            this.chart3.Series.Add(series33);
            //设置图表显示样式
            this.chart3.Titles.Add("wx");
            this.chart3.Titles[0].Text = string.Format("角速度显示");
            this.chart3.Series[0].Color = Color.Red;
            this.chart3.Series[1].Color = Color.Orange;
            this.chart3.Series[2].Color = Color.Green;
            this.chart3.Series[0].ChartType = SeriesChartType.Line;
            this.chart3.Series[1].ChartType = SeriesChartType.Line;
            this.chart3.Series[2].ChartType = SeriesChartType.Line;
            this.chart3.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //添加点
            this.chart3.Titles.Clear();
            this.chart3.Series[0].Points.Add(Angle[0]);
            this.chart3.Series[1].Points.Add(Angle[1]);
            this.chart3.Series[2].Points.Add(Angle[2]);
            this.chart3.Series[0].Points.Clear();
            this.chart3.Series[1].Points.Clear();
            this.chart3.Series[2].Points.Clear();
        }

        private void DisplayRefresh(object sender, EventArgs e)
        {
            double x = Angle[0] / 180 * Math.PI, y = Angle[1] / 180 * Math.PI, z = Angle[2] / 180 * Math.PI;
            double a_x = a[0], a_y = a[1], a_z = a[2];
            //T1:消除重力加速度
            a[0] = Math.Cos(z) * (a_x * Math.Cos(y) + Math.Sin(y) * (a_z * Math.Cos(x) + a_y * Math.Sin(x))) - Math.Sin(z) * (a_y * Math.Cos(x) - a_z * Math.Sin(x));
            a[1] = Math.Sin(z) * (a_x * Math.Cos(y) + Math.Sin(y) * (a_z * Math.Cos(x) + a_y * Math.Sin(x))) + Math.Cos(z) * (a_y * Math.Cos(x) - a_z * Math.Sin(x));
            a[2] = Math.Cos(y) * (a_z * Math.Cos(x) + a_y * Math.Sin(x)) - a_x * Math.Sin(y) - 1;
            //T2:还原
            a_x = a[0]; a_y = a[1]; a_z = a[2];
            a[0] = Math.Cos(y) * (a_x * Math.Cos(z) + a_y * Math.Sin(z)) - a_z * Math.Sin(y);
            a[1] = Math.Sin(x) * (a_z * Math.Cos(y) + Math.Sin(y) * (a_x * Math.Cos(z) + a_y * Math.Sin(z))) + Math.Cos(x) * (a_y * Math.Cos(z) - a_x * Math.Sin(z));
            a[2] = Math.Cos(x) * (a_z * Math.Cos(y) + Math.Sin(y) * (a_x * Math.Cos(z) + a_y * Math.Sin(z))) - Math.Sin(x) * (a_y * Math.Cos(z) - a_x * Math.Sin(z));
            //removeG();
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds / 1000;
            textBox16.Text = a[0]+"";
            textBox15.Text = a[1]+"";
            textBox14.Text = a[2]+"";
            textBox13.Text = w[0]+"";
            textBox12.Text = w[1]+"";
            textBox11.Text = w[2]+"";
            textBox22.Text = Angle[0]+"";
            textBox21.Text = Angle[1]+"";
            textBox20.Text = Angle[2]+"";
            textBox18.Text = DateTime.Now+"";
            textBox17.Text = TimeElapse + "";
            //加速度折线图
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[1].ChartType = SeriesChartType.Line;
            this.chart1.Series[2].ChartType = SeriesChartType.Line;
            this.chart1.Series[0].Points.Add(a[0]);
            this.chart1.Series[1].Points.Add(a[1]);
            this.chart1.Series[2].Points.Add(a[2]);
            //速度折线图
            this.chart2.Series[0].ChartType = SeriesChartType.Line;
            this.chart2.Series[1].ChartType = SeriesChartType.Line;
            this.chart2.Series[2].ChartType = SeriesChartType.Line;
            this.chart2.Series[0].Points.Add(a1_integration[1]);
            this.chart2.Series[1].Points.Add(v1_integration[1]);
            this.chart2.Series[2].Points.Add(y_integration[1]);
            //角度折线图
            this.chart3.Series[0].ChartType = SeriesChartType.Line;
            this.chart3.Series[1].ChartType = SeriesChartType.Line;
            this.chart3.Series[2].ChartType = SeriesChartType.Line;
            this.chart3.Series[0].Points.Add(Angle[0]);
            this.chart3.Series[1].Points.Add(Angle[1]);
            this.chart3.Series[2].Points.Add(Angle[2]);
            if (flag_Start)
            {
                SQLConnect();
                a1_integration[0] = a1_integration[1];
                a2_integration[0] = a2_integration[1];
                a1_integration[1] = a[1];
                a2_integration[1] = a[2];
                fixMember();
                integration();
                getYl();
                getYr();
                getZl();
                getZr();
                textBox1.Text = Lg + "";
                textBox2.Text = H + "";
                textBox3.Text = Yl + "";
                textBox4.Text = Yr + "";
                textBox5.Text = Zl + "";
                textBox6.Text = Zr + "";
            }
        }//【实时输出数据】

        private void RefreshComPort(object sender, EventArgs e)
        {
            toolStripComSet.DropDownItems.Clear();
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                toolStripComSet.DropDownItems.Add(portName, null, PortSelect);

                if ((spSerialPort.IsOpen) & (spSerialPort.PortName == portName))
                {
                    ToolStripMenuItem menu = (ToolStripMenuItem)toolStripComSet.DropDownItems[toolStripComSet.DropDownItems.Count - 1];
                    menu.Checked = true;
                }
            }
            toolStripComSet.DropDownItems.Add(new ToolStripSeparator());
            toolStripComSet.DropDownItems.Add("Close", null, PortClose);
        }//初始化【串口选择】下拉框

        ResourceManager rm = new ResourceManager(typeof(Form1));//资源管理器

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshComPort(null, null);
            Baund = 115200;
            SetBaudrate();

            textBox1.Text = "1435.6";
            textBox2.Text = "0.01";
            textBox3.Text = "0.5";
            textBox4.Text = "0.2";
            textBox5.Text = "-0.3";
            textBox6.Text = "0.1";
            textBox7.Text = "0";
            textBox10.Text = "100";
        }//初始化【串口选择】下拉框，设置波特率

        public enum USBCmd
        {
            NONE,
            BTKEY,
            UART1,
            UART2,
            UART3,
            UART4,
            UART5
        };

        private void SetBaudrate()
        {
            //设置波特率
            spSerialPort.BaudRate = 115200;

            byte[] byteChipCMD = new byte[4];
            byteChipCMD[1] = (byte)Baud.BAUD_115200;
            byteChipCMD[2] = 0;

            byteChipCMD[0] = (byte)USBCmd.UART1;
            SendUSBMsg((byte)DATATYPE.CHIP_CMD, byteChipCMD, 3);
            Thread.Sleep(10);

            byteChipCMD[0] = (byte)USBCmd.UART2;
            SendUSBMsg((byte)DATATYPE.CHIP_CMD, byteChipCMD, 3);
            Thread.Sleep(10);

            byteChipCMD[0] = (byte)USBCmd.UART3;
            SendUSBMsg((byte)DATATYPE.CHIP_CMD, byteChipCMD, 3);

        }//设置比特率

        private bool bListening = false;
        private bool bClosing = false;
        private DateTime TimeStart = DateTime.Now;
        private Int32 Baund=115200;

        private void PortSelect(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            try
            {
                PortClose(null, null);
                spSerialPort.PortName = menu.Text;
                spSerialPort.BaudRate = Baund;
                spSerialPort.Open();
                menu.Checked = true;
                bClosing = false;
            }
            catch (Exception ex)
            {
                menu.Checked = false;
            }
        }

        private void PortClose(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStripComSet.DropDownItems.Count-2; i++)
            {
                ToolStripMenuItem tempMenu = (ToolStripMenuItem)toolStripComSet.DropDownItems[i];
                tempMenu.Checked = false;
            }
            if (spSerialPort.IsOpen)
            {
                bClosing = true;
                while (bListening) Application.DoEvents();
                spSerialPort.Dispose();
                spSerialPort.Close();
                timer3.Stop();
            }
        }

        private double[] LastTime = new double[10];
        short sRightPack = 0;
        short [] ChipTime = new short[7];

        private void DecodeData(byte[] byteTemp)
        {
            double[] Data = new double[4];
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds / 1000;

            Data[0] = BitConverter.ToInt16(byteTemp, 2);
            Data[1] = BitConverter.ToInt16(byteTemp, 4);
            Data[2] = BitConverter.ToInt16(byteTemp, 6);
            Data[3] = BitConverter.ToInt16(byteTemp, 8);
            sRightPack++;

            switch (byteTemp[1])
            {
                case 0x50:
                    //Data[3] = Data[3] / 32768 * double.Parse(textBox9.Text) + double.Parse(textBox8.Text);
                    ChipTime[0] = (short)(2000 + byteTemp[2]);
                    ChipTime[1] = byteTemp[3];
                    ChipTime[2] = byteTemp[4];
                    ChipTime[3] = byteTemp[5];
                    ChipTime[4] = byteTemp[6];
                    ChipTime[5] = byteTemp[7];
                    ChipTime[6] = BitConverter.ToInt16(byteTemp, 8);
                    break;
                case 0x51:  //加速度输出
                    //Data[3] = Data[3] / 32768 * double.Parse(textBox9.Text) + double.Parse(textBox8.Text);
                    Temperature = Data[3] / 100.0;
                    Data[0] = Data[0] / 32768.0 * 16;
                    Data[1] = Data[1] / 32768.0 * 16;
                    Data[2] = Data[2] / 32768.0 * 16;

                    a[0] = Data[0];
                    a[1] = Data[1];
                    a[2] = Data[2];
                    a[3] = Data[3];
                    if ((TimeElapse - LastTime[1]) < 0.1) return;
                    LastTime[1] = TimeElapse;

                    break;
                case 0x52:  //角速度输出
                    //Data[3] = Data[3] / 32768 * double.Parse(textBox9.Text) + double.Parse(textBox8.Text);
                    Temperature = Data[3] / 100.0;
                    Data[0] = Data[0] / 32768.0 * 2000;
                    Data[1] = Data[1] / 32768.0 * 2000;
                    Data[2] = Data[2] / 32768.0 * 2000;
                    w[0] = Data[0];
                    w[1] = Data[1];
                    w[2] = Data[2];
                    w[3] = Data[3];

                    if ((TimeElapse-LastTime[2])<0.1) return;
                    LastTime[2] = TimeElapse;
                    break;
                case 0x53:  //角度输出
                    //Data[3] = Data[3] / 32768 * double.Parse(textBox9.Text) + double.Parse(textBox8.Text);
                    Temperature = Data[3] / 100.0;
                    Data[0] = Data[0] / 32768.0 * 180;
                    Data[1] = Data[1] / 32768.0 * 180;
                    Data[2] = Data[2] / 32768.0 * 180;
                    Angle[0] = Data[0];
                    Angle[1] = Data[1];
                    Angle[2] = Data[2];
                    Angle[3] = Data[3];
                    if ((TimeElapse-LastTime[3])<0.1) return;
                    LastTime[3] = TimeElapse;
                    break;
                case 0x54:
                    //Data[3] = Data[3] / 32768 * double.Parse(textBox9.Text) + double.Parse(textBox8.Text);
                    Temperature = Data[3] / 100.0;
                    h[0] = Data[0];
                    h[1] = Data[1];
                    h[2] = Data[2];
                    h[3] = Data[3];
                    if ((TimeElapse - LastTime[4]) < 0.1) return;
                    LastTime[4] = TimeElapse;
                    break;
                case 0x55:
                    Port[0] = Data[0];
                    Port[1] = Data[1];
                    Port[2] = Data[2];
                    Port[3] = Data[3];

                    break;

                case 0x56:
                    Pressure = BitConverter.ToInt32(byteTemp, 2);
                    Altitude = (double)BitConverter.ToInt32(byteTemp, 6) / 100.0;

                    break;

                case 0x57:
                    Longitude = BitConverter.ToInt32(byteTemp, 2);
                    Latitude  = BitConverter.ToInt32(byteTemp, 6);

                    break;

                case 0x58:
                    GPSHeight = (double)BitConverter.ToInt16(byteTemp, 2) / 10.0;
                    GPSYaw = (double)BitConverter.ToInt16(byteTemp, 4) / 10.0;
                    GroundVelocity = BitConverter.ToInt16(byteTemp, 6)/1e3;

                    break;
                default:
                    break;
            }
        } //解码数据

        delegate void UpdateData(byte[] byteData);//声明一个委托
        byte[] RxBuffer = new byte[1000];
        UInt16 usRxLength = 0;

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] byteTemp = new byte[1000];

            if (bClosing) return;
            try
            {
                bListening = true;
                UInt16 usLength=0;
                
                usLength = (UInt16)spSerialPort.Read(RxBuffer, usRxLength, 700);
                
                usRxLength += usLength;
                while (usRxLength >= 11)
                {
                    UpdateData Update = new UpdateData(DecodeData);
                    RxBuffer.CopyTo(byteTemp, 0);
                    if (!((byteTemp[0] == 0x55) & ((byteTemp[1] & 0x50)==0x50)))
                    {
                        for (int i = 1; i < usRxLength; i++) RxBuffer[i - 1] = RxBuffer[i];
                        usRxLength--;
                        continue;
                    }
                    if (((byteTemp[0]+byteTemp[1]+byteTemp[2]+byteTemp[3]+byteTemp[4]+byteTemp[5]+byteTemp[6]+byteTemp[7]+byteTemp[8]+byteTemp[9])&0xff)==byteTemp[10])
                        this.Invoke(Update, byteTemp);
                    for (int i = 11; i < usRxLength; i++) RxBuffer[i - 11] = RxBuffer[i];
                    usRxLength -= 11;
                }

                Thread.Sleep(10);
            }
            finally
            {
                bListening = false;//我用完了，ui可以关闭串口了。
            }
        }

        private sbyte sbSumCheck(byte[] byteData,byte byteLength)
        {
            byte byteSum=0;
            for (byte i = 0;i<byteLength-2;i++)
                byteSum += byteData[i];
            if (byteData[byteLength - 1] == byteSum) return 0;
            else return -1;
        }

        public sbyte SendMessage(Byte[] byteSend)
        {
            SendUSBMsg((byte)DATATYPE.MODULE_CMD, byteSend, (byte)byteSend.Length);
            if (spSerialPort.IsOpen == false)
            {
              //  MessageBox.Show(rm.GetString("PortNotOpen"), "Error!");
                Status.Text="Port Not Open!";
                return -1;
            }
            try
            {
                spSerialPort.Write(byteSend, 0, byteSend.Length);
                return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                PortClose(null, null);
            }
            catch { }

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            try
            {
                base.OnHandleCreated(e);
                usb.RegisterHandle(Handle);
            }
            catch (Exception err) { }
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                usb.ParseMessages(ref m);
                base.WndProc(ref m);	// pass message on to base form
            }
            catch (Exception err) { }
        }
        
        public enum DATATYPE
        {
            CHIP_DATA,
            MODULE_DATA,
            CHIP_CMD,
            MODULE_CMD
        };

        private void button1_Click(object sender, EventArgs e)
        {
            TimeStart = DateTime.Now;
            timer3.Start();
            InitChart();
            flag_Start = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("2019");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag_Start = false;
            Status.Text = "SQL server is disconnect";
        }

        public enum Baud
        {
            BAUD_115200
        };

        private void usb_OnDataRecieved(object sender, UsbLibrary.DataRecievedEventArgs args)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new DataRecievedEventHandler(usb_OnDataRecieved), new object[] { sender, args });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                byte byteLength = args.data[1];
                switch (args.data[2])
                {
                    case (byte)DATATYPE.CHIP_DATA:
                        //for (int i = 0; i < byteLength; i++)
                        //    args.data[i] = args.data[i + 3];
                        //DecodeData(args.data);
                        break;
                    case (byte)DATATYPE.MODULE_DATA:
                        for (int i = 0; i < byteLength; i++)
                            args.data[i] = args.data[i + 3];
                        CopeModuleMsg(args.data, byteLength);
                        break;
                }
            }
        }

        private sbyte SendUSBMsg(byte ucType, byte[] byteSend, byte ucLength)
        {
            try
            {
                if (this.usb.SpecifiedDevice != null)
                {
                    byte[] byteUSB = new Byte[0x43];
                    byteUSB[1] = ucLength;
                    byteUSB[2] = ucType;
                    byteSend.CopyTo(byteUSB, 3);
                    this.usb.SpecifiedDevice.SendData(byteUSB);
                }
                else
                {
                    // MessageBox.Show("Sorry but your device is not present. Plug it in!! ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return 0;
        }

        byte[] ModuleRxBuffer = new byte[1000];
        UInt16 usModuleRxLength = 0;

        private void CopeModuleMsg(byte[] byteIn, byte usLength)
        {
            byte[] byteTemp = new byte[1000];
            byteIn.CopyTo(ModuleRxBuffer, usModuleRxLength);
            usModuleRxLength += usLength;
            while (usModuleRxLength >= 11)
            {
                ModuleRxBuffer.CopyTo(byteTemp, 0);
                if (!((byteTemp[0] == 0x55) & ((byteTemp[1] & 0x50) == 0x50)))
                {
                    for (int i = 1; i < usModuleRxLength; i++) ModuleRxBuffer[i - 1] = ModuleRxBuffer[i];
                    usModuleRxLength--;
                    continue;
                }
                if (((byteTemp[0] + byteTemp[1] + byteTemp[2] + byteTemp[3] + byteTemp[4] + byteTemp[5] + byteTemp[6] + byteTemp[7] + byteTemp[8] + byteTemp[9]) & 0xff) == byteTemp[10])
                    DecodeData(byteTemp);
                for (int i = 11; i < usModuleRxLength; i++) ModuleRxBuffer[i - 11] = ModuleRxBuffer[i];
                usModuleRxLength -= 11;
            }
        }

        private void usb_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            Status.Text = "My Device Connected!";
            SetBaudrate();
        }

        private void usb_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            Status.Text = "My Device DisConnected!";
        }

        private void usb_OnDeviceArrived(object sender, EventArgs e)
        {
            Status.Text = "Find USB Device!";

        }

        private void usb_OnDeviceRemoved(object sender, EventArgs e)
        {
            Status.Text = "USB Device Removed!";
        }

        //坐标变换消除重力加速度
        private void removeG()
        {
            double x = Angle[0] / 180 * Math.PI, y = Angle[1] / 180 * Math.PI, z = Angle[2] / 180 * Math.PI;
            double a_x = a[0], a_y = a[1], a_z = a[2];
            //T1:消除重力加速度
            a[0] = Math.Cos(z) * (a_x * Math.Cos(y) + Math.Sin(y) * (a_z * Math.Cos(x) + a_y * Math.Sin(x))) - Math.Sin(z) * (a_y * Math.Cos(x) - a_z * Math.Sin(x));
            a[1] = Math.Sin(z) * (a_x * Math.Cos(y) + Math.Sin(y) * (a_z * Math.Cos(x) + a_y * Math.Sin(x))) + Math.Cos(z) * (a_y * Math.Cos(x) - a_z * Math.Sin(x));
            a[2] = Math.Cos(y) * (a_z * Math.Cos(x) + a_y * Math.Sin(x)) - a_x * Math.Sin(y)-1;
            //T2:还原
            a[0] = Math.Cos(y)*(a_x* Math.Cos(z) + a_y* Math.Sin(z)) - a_z* Math.Sin(y);
            a[1] = Math.Sin(x)*(a_z* Math.Cos(y) + Math.Sin(y)*(a_x* Math.Cos(z) + a_y* Math.Sin(z))) + Math.Cos(x)*(a_y* Math.Cos(z) - a_x* Math.Sin(z));
            a[2] = Math.Cos(x)*(a_z* Math.Cos(y) + Math.Sin(y)*(a_x* Math.Cos(z) + a_y* Math.Sin(z))) - Math.Sin(x)*(a_y* Math.Cos(z) - a_x* Math.Sin(z));
        }

        //计算轨距
        private void getLg()
        {
            Lg = 1.435;
        }

        //计算超高
        private void getH()
        {
            H = Lg * Math.Tan(Angle[0]);
        }

        //计算左轨向
        private void getYl()
        {
            //TODO:计算左轨向,先算位移，再把附加项添加上去
            Yl = y_integration[1];
        }

        //计算右轨向
        private void getYr()
        {
            //TODO:计算左轨向,先算位移，再把附加项添加上去
            Yr = Yl;
        }

        //计算左高度
        private void getZl()
        {
            //TODO:计算左轨向
            Zl = z_integration[1];
        }

        //计算右高度
        private void getZr()
        {
            //TODO:计算左轨向
            Zr = Zl;
        }

        //修正数值
        private void fixMember()
        {
            //初始值修正
            a1_integration[1] = a1_integration[1] - fixA1;
            a2_integration[1] = a2_integration[1] - fixA2;
            Angle0_integration[1] = Angle0_integration[1] - fixAngle0;
            for (int i = 0; i < 2; i++)
            {                //TODO:机械振动修正
                if ((a1_integration[i] <= e) && (a1_integration[i] > -e))
                {
                    a1_integration[i] = 0;
                }
                if ((a2_integration[i] <= e) && (a2_integration[i] > -e))
                {
                    a2_integration[i] = 0;
                }
                if ((Angle0_integration[i] <= e) && (Angle0_integration[i] > -e))
                {
                    Angle0_integration[i] = 0;
                }
            }
        }

        private void integration()
        {

            v1_integration[1] = v1_integration[0] + ((a1_integration[1] + a1_integration[0]) / 2) * timer3.Interval/1000;
            y_integration[1] = y_integration[0] + ((v1_integration[1] + v1_integration[0])/ 2) * timer3.Interval/1000;
            v1_integration[0] = v1_integration[1];
            y_integration[0] = y_integration[1];

            v2_integration[1] = v2_integration[0] + ((a2_integration[1] + a2_integration[0]) / 2) * timer3.Interval/1000;
            z_integration[1] = z_integration[0] + ((v2_integration[1] + v2_integration[0]) / 2 )* timer3.Interval/1000;
            v2_integration[0] = v2_integration[1];
            z_integration[0] = z_integration[1];

            if (a1_integration[1] == 0 && a2_integration[1] == 0)
            {
                a_count++;
            }
            else
            {
                a_count = 0;
            }

            if (a_count >= 5)
            {
                v1_integration[1] = 0;
                v1_integration[0] = 0;
                v2_integration[1] = 0;
                v2_integration[0] = 0;
            }
        }
    }
}