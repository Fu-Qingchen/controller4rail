using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SerialCommunication;

namespace HostComputerForRail
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var thread = new Thread(ThreadStart);
            // allow UI with ApartmentState.STA though [STAThread] above should give that to you
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
            Application.Run(new Form1());
            //Application.Run(new Form_Serial());
        }
        private static void ThreadStart()
        {
            Application.Run(new Form_Serial()); // <-- other form started on its own UI thread
        }
    }
}
