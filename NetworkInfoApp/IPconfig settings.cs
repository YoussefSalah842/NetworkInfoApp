using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace NetworkInfoApp
{
    public partial class IPconfig_settings : Form
    {
        public IPconfig_settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define the command you want to run (e.g., "ipconfig")
            string command = "ipconfig";  // Replace "ipconfig" with your desired command

            // Start the Command Prompt process and keep it open
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define the command you want to run (e.g., "ipconfig")
            string command = "ipconfig /all";  // Replace "ipconfig" with your desired command

            // Start the Command Prompt process and keep it open
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Define the command you want to run (e.g., "ipconfig")
            string command = "ipconfig /release";  // Replace "ipconfig" with your desired command

            // Start the Command Prompt process and keep it open
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Define the command you want to run (e.g., "ipconfig")
            string command = "ipconfig /renew";  // Replace "ipconfig" with your desired command

            // Start the Command Prompt process and keep it open
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/k " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processInfo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
