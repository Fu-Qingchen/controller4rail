using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video.DirectShow;

namespace HostComputerForRail
{
    class MonitorCamera
    {
        private FilterInfoCollection VideoInputDeviceCollection;
        private VideoCaptureDevice VideoCaptureDevice;

        //获取所有摄像机, 并把它加载在 comboBox 控件上 
        public bool getAllCamera(System.Windows.Forms.ComboBox comboBox)
        {
            VideoInputDeviceCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo VideoInputDevice in VideoInputDeviceCollection)
            {
                comboBox.Items.Add(VideoInputDevice.Name);
                comboBox.SelectedIndex = 0;
            }
            if(VideoInputDeviceCollection.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
