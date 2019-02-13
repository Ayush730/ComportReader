using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ComportReader
{
    public partial class Form1 : Form
    {
        HashSet<string> ports = new HashSet<string>();
        Thread readThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < SerialPort.GetPortNames().Length; i++)
            {
                ports.Add(SerialPort.GetPortNames()[i]);
            }
            UI_cboPort.Items.AddRange(ports.ToArray());
            UI_cboPort.SelectedIndex = 0;
            UI_btnClose.Enabled = false;
        }

        private void UI_btnOpen_Click(object sender, EventArgs e)
        {
            UI_btnOpen.Enabled = false;
            UI_btnClose.Enabled = true;
            try
            {
                curSerial.PortName = UI_cboPort.Text;
                curSerial.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            readThread = new Thread(new ThreadStart(PlaceText));
            readThread.IsBackground = true;
            readThread.Start();
        }

        private void PlaceText()
        {
            while (true)
            {
                string text = ReceiveText();

                UI_txReceive.Invoke(new Action(() => {
                    UI_txReceive.Text += text;
                    UI_txReceive.SelectionStart = UI_txReceive.Text.Length - 1;
                }));
            }
        }
        private string ReceiveText()
        {
            while (true)
            {
                if (curSerial.IsOpen)
                {
                    string temp = curSerial.ReadExisting();
                    if (temp.Length > 0)
                        return temp;
                }
            }
        }

        private void cbChangeText(string s)
        {
            UI_txReceive.Text += s;
        }

        private void UI_btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (curSerial.IsOpen)
                {
                    curSerial.WriteLine(UI_txSerial.Text + Environment.NewLine);
                    UI_txSerial.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UI_btnClose_Click(object sender, EventArgs e)
        {
            if (readThread != null)
                readThread.Abort();
            UI_btnOpen.Enabled = true;
            UI_btnClose.Enabled = false;
            try
            {
                curSerial.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UI_btnClear_Click(object sender, EventArgs e)
        {
            UI_txReceive.Text = "";
        }

        private void UI_cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readThread != null)
            {
                lock (readThread)
                {
                    curSerial.Close();
                    curSerial.PortName = UI_cboPort.Text;
                    curSerial.Open();
                }
            }
            else
            {
                if (curSerial.IsOpen)
                {
                    curSerial.Close();
                    curSerial.PortName = UI_cboPort.Text;
                    curSerial.Open();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (readThread != null)
                readThread.Abort();

            if (curSerial.IsOpen)
                curSerial.Close();
        }
    }
}
