using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pierre_Technologies__Windows_Toolbox_0._1
{
    public partial class ProcessInfo : Form
    {
        public ProcessInfo()
        {
            InitializeComponent();
        }
        Process[] procs;
        private void GetProcesses()
        {
            procs = Process.GetProcesses();
            if (Convert.ToInt32(label2.Text) != procs.Length)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < procs.Length; i++)
                {
                    listBox1.Items.Add(procs[i].ProcessName);
                }
                label2.Text = procs.Length.ToString();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetProcesses();
        }
    }
}
