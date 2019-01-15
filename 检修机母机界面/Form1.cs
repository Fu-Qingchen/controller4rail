using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace 检修机母机界面
{
    public partial class Form1 : Form
    {
        //数据源
        string path = @"C:\Users\ASUS\Desktop\DATA\1.txt";
        string path1 = @"C:\Users\ASUS\Desktop\DATA\2.txt";
        string path2 = @"C:\Users\ASUS\Desktop\DATA\3.txt";
        string path3 = @"C:\Users\ASUS\Desktop\DATA\4.txt";
        string path4 = @"C:\Users\ASUS\Desktop\DATA\5.txt";
        string path5 = @"C:\Users\ASUS\Desktop\DATA\6.txt";
        string path6 = @"C:\Users\ASUS\Desktop\DATA\7.txt";
        string path9 = @"C:\Users\ASUS\Desktop\DATA\10.txt";

        //
        public int t, t1;

        public Form1()
        {
            InitializeComponent();
        }

        //初始值加载
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1435.6";
            textBox2.Text = "0.01";
            textBox3.Text = "0.5";
            textBox4.Text = "0.2";
            textBox5.Text = "-0.3";
            textBox6.Text = "0.1";
            textBox7.Text = "0";
            textBox10.Text = "100";
        }

        //将path...里面的数据输出到textbox...
        public void TextBox1_Change()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(1000);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich), data[i].ToString());
                            SetRich(data[i].ToString());
                        }

                        Data = sr.ReadLine();
                    }

                }
            }
        }
        private void textbox2change()
        {
            using (StreamReader sr = new StreamReader(path1))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(1000);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich1), data[i].ToString());
                        }
                        Data = sr.ReadLine();
                    }
                }
            }
        }
        private void textbox3change()
        {
            using (StreamReader sr = new StreamReader(path2))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(1000);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich2), data[i].ToString());

                        }

                        Data = sr.ReadLine();
                    }

                }
            }
        }
        private void textbox4change()
        {
            using (StreamReader sr = new StreamReader(path3))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(1000);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich3), data[i].ToString());
                        }

                        Data = sr.ReadLine();
                    }

                }
            }
        }
        private void textbox5change()
        {
            using (StreamReader sr = new StreamReader(path4))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(1000);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich4), data[i].ToString());
                        }

                        Data = sr.ReadLine();
                    }

                }
            }
        }
        private void textbox6change()
        {
            using (StreamReader sr = new StreamReader(path5))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(1000);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich5), data[i].ToString());
                        }

                        Data = sr.ReadLine();
                    }

                }
            }
        }
        private void textbox7change()
        {
            using (StreamReader sr = new StreamReader(path6))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(800);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich6), data[i].ToString());
                        }

                        Data = sr.ReadLine();
                    }

                }
            }
        }
        private void textbox10change()
        {

            using (StreamReader sr = new StreamReader(path9))
            {
                string Data;
                Data = sr.ReadLine();
                int line = 0;
                while (sr.ReadLine() != null)
                {
                    line++;
                    double[] data = new double[line];

                    while (Data != null)
                    {
                        int i = 0;

                        for (i = 0; i < line; i++)
                        {
                            Thread.Sleep(1000);
                            data[i] = double.Parse(Data);

                            this.Invoke(new MyDelegate(SetRich9), data[i].ToString());
                        }

                        Data = sr.ReadLine();
                    }

                }
            }
        }

        delegate void MyDelegate(string str);//定义委托，读取txt文件需要

        //输出数据
        private void SetRich(string str)//委托
        {
            textBox1.Text = str;
        }

        private void SetRich1(string str)
        {
            textBox2.Text = str;
        }
        private void SetRich2(string str)
        {
            textBox3.Text = str;
        }
        private void SetRich3(string str)
        {
            textBox4.Text = str;
        }
        private void SetRich4(string str)
        {
            textBox5.Text = str;
        }
        private void SetRich5(string str)
        {
            textBox6.Text = str;
        }
        private void SetRich6(string str)
        {
            textBox7.Text = str;
        }
        private void SetRich9(string str)
        {
            textBox10.Text = str;
        }

        public void threadprogress()
        {
            Thread t = new Thread(new ThreadStart(TextBox1_Change));
            t.Start();
            Thread t1 = new Thread(new ThreadStart(textbox2change));
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(textbox3change));
            t2.Start();
            Thread t3 = new Thread(new ThreadStart(textbox4change));
            t3.Start();
            Thread t4 = new Thread(new ThreadStart(textbox5change));
            t4.Start();
            Thread t5 = new Thread(new ThreadStart(textbox6change));
            t5.Start();
            Thread t6 = new Thread(new ThreadStart(textbox7change));
            t6.Start();
            Thread t9 = new Thread(new ThreadStart(textbox10change));
            t9.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            threadprogress();
            timer1.Start();
            timer2.Start();

        }

        public string Getmeter(int t)
        {
            string mm, kmm;
            int m, km;
            int temp = t1 / 9;
            m = (5 * temp);
            km = (5 * temp) / 1000 % 1000;
            if (m < 10) mm = "00" + m.ToString();

            else if (m < 100) mm = "0" + m.ToString();
            else mm = m.ToString();
            if (km < 10) kmm = "0" + km.ToString();
            else kmm = km.ToString();
            return kmm + "." + mm;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            textBox9.Text = "00:00:00";
            textBox8.Text = "00.000";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox10.Text = "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t1++;
            textBox8.Text = Getmeter(t);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            textBox9.Text = Gettime9(t);
        }

        //根据时间把时分秒拆开转化为标准格式
        public string Gettime9(int t)
        {
            string hh, mm, ss;
            int temp = t / 9;
            int h = temp / 3600;
            int m = temp / 60 % 60;
            int s = temp % 60;
            if (s < 10) ss = "0" + s.ToString();
            else ss = s.ToString();
            if (h < 10) hh = "0" + h.ToString();
            else hh = h.ToString();
            if (m < 10) mm = "0" + m.ToString();
            else mm = m.ToString();
            return hh + ":" + mm + ":" + ss;
        }
    }
}
