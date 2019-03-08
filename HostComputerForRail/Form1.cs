using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostComputerForRail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            this.Close();
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
