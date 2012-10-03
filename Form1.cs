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
    public partial class Form1 : Form
    {
        public Form1()
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
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Wordpad");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("dfrgui");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("wuapp");
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
            new Form2().Show();
        }
    }
}
