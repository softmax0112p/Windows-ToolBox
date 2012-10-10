using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pierre_Technologies__Windows_Toolbox_0._1
{
    public static class ProcessManager
    {
        public static void Start(string processName)
        {
            try
            {
                Process.Start(processName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot find the exe " + processName + "\n" + ex.Message); 
            }
        }
    }
}
