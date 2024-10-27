using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace NetworkInfoApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                string hostName = Dns.GetHostName();
                lblHostName.Text = "Host Name: " + hostName;

                
                var ipAddresses = Dns.GetHostEntry(hostName).AddressList
                    .Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    .Select(ip => ip.ToString()).ToArray();

                string ipAddress = ipAddresses.Length > 0 ? ipAddresses[0] : "N/A";
                lblIPAddress.Text = "IP Address: " + ipAddress;

                
                var dnsAddresses = Dns.GetHostAddresses(hostName)
                    .Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    .Select(ip => ip.ToString()).ToArray();

                string dnsInfo = dnsAddresses.Length > 0 ? string.Join(", ", dnsAddresses) : "N/A";
                lblDNS.Text = "DNS: " + dnsInfo;

                
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.OperationalStatus == OperationalStatus.Up)
                    {
                       
                        var gateway = ni.GetIPProperties().GatewayAddresses
                            .Where(g => g.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            .Select(g => g.Address.ToString()).ToArray();
                        string gatewayAddress = gateway.Length > 0 ? gateway[0] : "N/A";
                        lblGateway.Text = "Gateway: " + gatewayAddress;

                        
                        var unicastAddresses = ni.GetIPProperties().UnicastAddresses
                            .Where(ua => ua.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            .Select(ua => ua.IPv4Mask.ToString()).ToArray();
                        string subnetMask = unicastAddresses.Length > 0 ? unicastAddresses[0] : "N/A";
                        lblSubnetMask.Text = "Subnet Mask: " + subnetMask;

                        lblNetworkInterface.Text = "Network Interface: " + ni.Name;
                        break; 
                    }
                }

                
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Information displayed successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string allInfo = lblHostName.Text + "\n" +
                 lblIPAddress.Text + "\n" +
                 lblDNS.Text + "\n" +
                 lblGateway.Text + "\n" +
                 lblSubnetMask.Text + "\n" +
                 lblNetworkInterface.Text;

            Clipboard.SetText(allInfo);
            MessageBox.Show("Information copied to clipboard!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control", "ncpa.cpl");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}