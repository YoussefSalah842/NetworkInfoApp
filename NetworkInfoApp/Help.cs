using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace NetworkInfoApp
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help_View HelpViewApp = new Help_View();
            HelpViewApp.Show();
            HelpViewApp.HelpTitle.Text = "Introduction to the program and how it works";
            HelpViewApp.HelpDesr1.Text = "This program is designed to display detailed network information of your computer. It retrieves and shows the Host Name, IP Address, DNS addresses, Gateway, Subnet Mask, and the active Network Interface. Additionally, it allows you to copy all the displayed information to the clipboard for easy sharing or documentation.";
            HelpViewApp.HelpDesr2.Text = "view and copy your network details quickly to troubleshoot or share them safely.";
            HelpViewApp.IMGTEXT.Text = "Screenshot of the main interface of the program";
            HelpViewApp.pictureBox2.Image = Properties.Resources.main;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help_View HelpViewApp = new Help_View();
            HelpViewApp.Show();
            HelpViewApp.HelpTitle.Text = "How to use ipconfig commands and their benefits";
            HelpViewApp.HelpDesr1.Text = "This part of the program allows you to run various ipconfig commands directly from the application. These commands help you view and manage your network configuration easily without opening the Command Prompt manually.";
            HelpViewApp.HelpDesr2.Text = "run ipconfig commands to view, release, or renew your network settings easily.";
            HelpViewApp.IMGTEXT.Text = "Screenshot of the main interface of the ipconfig Dialog";
            HelpViewApp.pictureBox2.Image = Properties.Resources.ipconfig;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:youssefsalah9862@gmail.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
