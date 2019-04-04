using System;
using System.Windows.Forms;
using System.Net;   // For IPAddress
using System.Net.Sockets;

namespace PortScanner
{
    public partial class MainForm : Form
    {
        IPAddress ipAddress;        // Verifies IP input

        private const int MIN_PORT = 0;
        private const int MAX_PORT = 65535;

        private string IP;
        private int portStart;
        private int portEnd;
        private int portCurrent;

        public MainForm()
        {
            InitializeComponent();
        }

        public bool ScanMore()
        {
            return (portEnd - portCurrent + 1) > 0;
        }

        public void ScanPorts()
        {
            textBoxResults.AppendText("IP Address Scanned: " + IP);
            textBoxResults.AppendText(Environment.NewLine);
            textBoxResults.AppendText("Protocol: TCP");
            textBoxResults.AppendText(Environment.NewLine);
            textBoxResults.AppendText("Amount of port(s) scanned: " + (portEnd - portStart + 1));
            textBoxResults.AppendText(Environment.NewLine);
            textBoxResults.AppendText("--------------------------------------------------");
            textBoxResults.AppendText(Environment.NewLine);

            progressBar.Maximum = portEnd - portStart + 1;

            if (portEnd == portStart)
            {
                try
                {
                    TcpClient tcpScanner = new TcpClient(IP, portCurrent);
                    //tcpScanner.SendTimeout = 500;
                    textBoxResults.AppendText("Port " + portCurrent + ": Open");
                    textBoxResults.AppendText(Environment.NewLine);
                }
                catch (Exception)
                {
                    textBoxResults.AppendText("Port " + portCurrent + ": Closed");
                    textBoxResults.AppendText(Environment.NewLine);
                }
            }

            while (ScanMore())
            {
                
                try
                {
                    TcpClient tcpScanner = new TcpClient(IP, portCurrent);
                    //tcpScanner.SendTimeout = 500;               // Check this!
                    textBoxResults.AppendText("Port " + portCurrent + ": Open");
                    textBoxResults.AppendText(Environment.NewLine);
                }
                catch (Exception)
                {
                    textBoxResults.AppendText("Port " + portCurrent + ": Closed");
                    textBoxResults.AppendText(Environment.NewLine);
                }

                progressBar.Value += 1;
                portCurrent++;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelIPTo.Hide();
            textBoxIPRange2.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelIPTo.Show();
            textBoxIPRange2.Show();
        }

        private bool IsIpAddressValid()
        {

            if(textBoxIP.Text == String.Empty)
            {
                MessageBox.Show("Please enter an IP Address.");
                return false;
            }
            
            if(IPAddress.TryParse(textBoxIP.Text, out ipAddress))
            {
                IP = ipAddress.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            textBoxResults.Clear();

            if(!(IsIpAddressValid()))
            {
                MessageBox.Show("Invalid IP Address.");
            }

            if(!(IsPortRangeValid()))
            {
                MessageBox.Show("Invalid Port or Port Range.");
            }

            ScanPorts();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Results saved to text document, but not really because this isn't done.");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxIP.Clear();
            textBoxIPRange1.Clear();
            textBoxIPRange2.Clear();
            textBoxResults.Clear();
            progressBar.Value = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private bool IsPortRangeValid()
        {
            bool successfulParse;

            if (radioButtonRange.Checked)
            {
                successfulParse = int.TryParse(textBoxIPRange2.Text, out portEnd);
                if (!(successfulParse) || (portEnd > MAX_PORT))
                {
                    MessageBox.Show("Invalid input in Range 2.");
                    return false;
                }

                successfulParse = int.TryParse(textBoxIPRange1.Text, out portStart);
                if (!(successfulParse) || (portStart < MIN_PORT))
                {
                    MessageBox.Show("Invalid input in Range 1.");
                    return false;
                }

                if(portEnd <= portStart)
                {
                    MessageBox.Show("Invalid range entered. Starting port must be smaller than the ending port.");
                    return false;
                }
                portCurrent = portStart;
            }
            else
            {
                successfulParse = int.TryParse(textBoxIPRange1.Text, out portStart);
                if(!(successfulParse) || (portStart < MIN_PORT))
                {
                    MessageBox.Show("Incorrect starting port entered");
                    return false;
                }
                portEnd = portStart;
                portCurrent = portStart;
            }

            // Remove this afterwords!!!!
            return true;
        }
    }
}
