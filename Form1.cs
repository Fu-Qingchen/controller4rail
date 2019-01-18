using System;
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using UsbLibrary;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace MiniIMU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitChart();
        }//构造函数，初始化组件

        private void InitChart()
        {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("ax");
            Series series2 = new Series("ay");
            series1.ChartArea = "C1";
            series2.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            //设置图表显示样式
            this.chart1.Titles.Add("ax");
            this.chart1.Titles.Add("ay");
            this.chart1.Titles[0].Text = string.Format("加速度显示");
            this.chart1.Titles[1].Text = string.Format("加速度显示");
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[1].Color = Color.Yellow;
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[1].ChartType = SeriesChartType.Line;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Series[0].Points.Add(a[0]);
            this.chart1.Series[1].Points.Add(a[1]);
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
        }

        /***************************************
         * 倾角仪数据传输部分
         **************************************/

        double[] a = new double[4] , w = new double[4], h = new double[4], Angle = new double[4], Port = new double[4];
        double Temperature, Pressure, Altitude, GroundVelocity, GPSYaw, GPSHeight;
        long Longitude, Latitude;

        private void DisplayRefresh(object sender, EventArgs e)
        {
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
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[0].Points.Add(a[0]);
        }//输出数据

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
            Baund = 9600;
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
            Thread.Sleep(100);

            byteChipCMD[0] = (byte)USBCmd.UART2;
            SendUSBMsg((byte)DATATYPE.CHIP_CMD, byteChipCMD, 3);
            Thread.Sleep(100);

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("2019");
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
    }
}
