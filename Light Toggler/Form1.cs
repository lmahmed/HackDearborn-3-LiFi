using System;
using System.IO.Ports;
using System.Runtime.Serialization;
using System.Threading;
using System.ComponentModel;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Globalization;

namespace Light_Toggler
{
    public partial class Form1 : Form
    {
        Thread thread;
        SerialPort serialPort;
        DateTime startTime;
        DateTime endTime;
        int delay; // length of each signal in milliseconds
        System.Windows.Forms.Timer timer1;

        public Form1()
        {
            InitializeComponent();
            delay = 500;
            serialPort = new SerialPort("COM6", 9600);
            timerLabel.Text = "0";

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += incrementTimer;

            try
            {
                serialPort.Open();
            }
            catch
            {

            }
        }

        public void incrementTimer(object? sender, EventArgs e)
        {
            var timer = DateTime.UtcNow - startTime;
            timerLabel.Text = timer.TotalSeconds.ToString();
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            try
            {
                TurnOnLight();
            }
            catch
            {

            }
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            try
            {
                TurnOffLight();
            }
            catch
            {

            }
        }

        private void TurnOnLight()
        {
            serialPort.Write("1");
            offBulbPicture.Visible = false;
        }

        private void TurnOffLight()
        {
            serialPort.Write("0");
            offBulbPicture.Visible = true;
        }

        private void brakeSendButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var name = button.Name;

            thread = new Thread(SendMessage);
            thread.Start(name);
        }

        private void SendMessage(object? o)
        {
            string buttonName = (string)o;
            if (buttonName is string)
            {
                (string, string) tuple = MessageToSend(buttonName);
                string message = tuple.Item1 as string;
                string type = tuple.Item2 as string;

                if (message != "")
                {
                    serialPort.Write("1");
                    logPanel.Invoke(() =>
                    {
                        offBulbPicture.Visible = false;
                        logPanel.Controls.Add(createTextBox($"Starting {type} message transmission."));
                    });
                    Thread.Sleep(2000);
                    foreach (char c in message)
                    {
                        serialPort.Write(c.ToString());
                        logPanel.Invoke(() =>
                        {
                            offBulbPicture.Visible = c == '0';
                            logPanel.Controls.Add(createTextBox($"Transmitting {c}"));
                        });
                        Thread.Sleep(delay);
                    }
                }
                serialPort.Write("0");
                logPanel.Invoke(() =>
                {
                    offBulbPicture.Visible = true;
                    logPanel.Controls.Add(createTextBox($"{type} message completed."));
                });
            }
        }

        private (string, string) MessageToSend(string name)
        {
            string message;
            string type;
            if (name == "brakeSendButton")
            {
                message = "10011001";
                type = "brake";
            }
            else if (name == "secondMessageButton")
            {
                message = "10101010";
                type = "light";
            }
            else if (name == "thirdMessageButton")
            {
                message = "01100101";
                type = "stop";
            }
            else
            {
                message = "";
                type = "";
            }
            return (message, type);
        }

        private TextBox createTextBox(string text)
        {
            var textBox = new TextBox();
            DateTime dateTime = DateTime.Now;
            textBox.Dock = DockStyle.Top;
            textBox.Multiline = true;
            textBox.WordWrap = true;
            textBox.AutoSize = true;
            textBox.BackColor = Color.AliceBlue;
            textBox.Margin = new Padding(0, 15, 0, 0);
            textBox.ReadOnly = true;

            textBox.Text = dateTime.Second + ":" + dateTime.Millisecond + $": " + text;

            return textBox;
        }

        private void timerOnButton_Click(object sender, EventArgs e)
        {
            if (timerLabel.Text == "0")
            {
                startTime = DateTime.UtcNow;
            }
            else
            {
                startTime = endTime + ((DateTime.UtcNow - endTime) - (endTime - startTime));
            }
            timer1.Start();
            timerOnButton.Enabled = false;
            timerOffButton.Enabled = true;
            timerResetButton.Enabled = true;
        }

        private void timerOffButton_Click(object sender, EventArgs e)
        {
            endTime = DateTime.UtcNow;
            timer1.Stop();
            timerOffButton.Enabled = false;
            timerOnButton.Enabled = true;
        }

        private void timerResetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startTime = DateTime.UtcNow;
            timerLabel.Text = "0";
            timerResetButton.Enabled = false;
            timerOffButton.Enabled= false;
            timerOnButton.Enabled = true;
        }
    }
}
