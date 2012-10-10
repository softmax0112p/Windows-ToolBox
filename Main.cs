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
    public partial class Main : Form
    {
        public Main()
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
        private void btnNotepad_Click(object sender, EventArgs e)
        {
            ProcessManager.Start("Notepad");
        }

        private void btnWordPad_Click(object sender, EventArgs e)
        {
            ProcessManager.Start("Wordpad");
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            ProcessManager.Start("mspaint");
        }

        private void btnDisk_Click(object sender, EventArgs e)
        {
            ProcessManager.Start("dfrgui");
        }

        private void btnDefrag_Click(object sender, EventArgs e)
        {
            ProcessManager.Start("cleanmgr");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProcessManager.Start("wuapp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ProcessInfo().Show();
        }
    }
}
