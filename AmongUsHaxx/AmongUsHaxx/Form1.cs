using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsHaxx
{

    public partial class Form1 : Form
    {
        Memory.Mem memory = new Memory.Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+01BC7CB4,0,10,4C,C0,5C,14,14", "float", trackBar3.Value.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("Among Us");
            for (int i = 0; i < processesByName.Length; i++)
            {
                memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                Status.Text = "Status: Attached";
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                memory.WriteMemory("GameAssembly.dll+01C4D174,C,20,28,5C,0,34,28", "Byte", "1");
            }
            else
            {
                memory.WriteMemory("GameAssembly.dll+01C4D174,C,20,28,5C,0,34,28", "Byte", "0");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Status.Text = "Status: Not Attached";
            Process[] processesByName = Process.GetProcessesByName("Among Us");
            for (int i = 0; i < processesByName.Length; i++)
            {
                memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                Status.Text = "Status: Attached";
                timer1.Start();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                memory.WriteMemory("GameAssembly.dll+01C57F7C,5c,4,18", "float", "99");
            }
            else
            {
                memory.WriteMemory("GameAssembly.dll+01C57F7C,5c,4,18", "float", "1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+00A161A4,FFC,BC,20,24,5C,34,48", "float", trackBar1.Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+00E3FAD0,81C,0,C,230,164,14,44", "float", trackBar2.Value.ToString());
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true) {
                memory.WriteMemory("UnityPlayer.dll+960CA5", "bytes", "0x0F 0x85 0x91 0x00 0x00 0x00");
            }
            else
            {
                memory.WriteMemory("UnityPlayer.dll+960CA5", "bytes", "0x0F 0x84 0x91 0x00 0x00 0x00");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                memory.WriteMemory("GameAssembly.dll+01C57884,20,24,5C,8,18,14,8", "float", "0");

            }
            if (checkBox5.Checked == true)
            {
                memory.WriteMemory("GameAssembly.dll+01C555C8,40,30,5C,10,34,2C,44", "float", "0");
            }
            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+01BC7CB4,0,10,4C,C0,5C,14,14", "bytes", "0x0 0x1");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+01C57F7C,5c,0,48", "bytes", "99");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                memory.WriteMemory("GameAssembly.dll+8EDBA9", "bytes", "0x90");
                memory.WriteMemory("GameAssembly.dll+8EDBAA", "bytes", "0x90");
                memory.WriteMemory("GameAssembly.dll+8EDBA8", "bytes", "0x90");
                memory.WriteMemory("GameAssembly.dll+8EDBAC", "bytes", "0x90");
                memory.WriteMemory("GameAssembly.dll+8EDBAD", "bytes", "0x90");
                memory.WriteMemory("GameAssembly.dll+8EDBAB", "bytes", "0x90");
            }
            else
            {
                memory.WriteMemory("GameAssembly.dll+8EDBA8", "bytes", "0x0F 0x84 0x2D 0x02 0x00 0x00");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                memory.WriteMemory("GameAssembly.dll+01C57F7C,5c,0,2C", "float", "10");
            }
            else
            {
                memory.WriteMemory("GameAssembly.dll+01C57F7C,5c,0,2C", "float", "1");
            }
        }
    }
}
