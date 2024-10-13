using System;
using System.IO.Ports;
using System.Runtime.Serialization;
using System.Threading;
using System.ComponentModel;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace Light_Toggler
{
    public partial class Form1 : Form
    {
        Thread thread;
        SerialPort serialPort;
        DateTime startTime;
        System.Windows.Forms.Timer timer1;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM6", 9600);
            startTime = DateTime.UtcNow;
            timerLabel.Text = 0.ToString();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += incrementTimer;
            timer1.Start();

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
        }

        private void TurnOffLight()
        {
            serialPort.Write("0");
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
                string message = MessageToSend(buttonName);
                if (message != "")
                {
                    serialPort.Write("1");
                    Thread.Sleep(2000);
                    
                    foreach (char  c in message)
                    {
                        serialPort.Write(c.ToString());
                        Thread.Sleep(500);
                    }
                }
            }
            serialPort.Write("0");

        }

        private string MessageToSend(string name)
        {
            string message;
            if (name == "brakeSendButton")
            {
                message = "10011001";
            }
            else
            {
                message = "";
            }




            return message;
        }
    }
}
