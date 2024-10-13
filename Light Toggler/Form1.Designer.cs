namespace Light_Toggler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OnButton = new Button();
            OffButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            panel9 = new Panel();
            thirdMessageButton = new Button();
            label8 = new Label();
            panel8 = new Panel();
            secondMessageButton = new Button();
            label7 = new Label();
            panel6 = new Panel();
            brakeSendButton = new Button();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label5 = new Label();
            timerLabel = new Label();
            panel7 = new Panel();
            timerResetButton = new Button();
            timerOffButton = new Button();
            timerOnButton = new Button();
            log = new Panel();
            offBulbPicture = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            logPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)offBulbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OnButton
            // 
            OnButton.BackColor = Color.White;
            OnButton.Location = new Point(86, 128);
            OnButton.Name = "OnButton";
            OnButton.Size = new Size(230, 80);
            OnButton.TabIndex = 0;
            OnButton.Text = "On";
            OnButton.UseVisualStyleBackColor = false;
            OnButton.Click += OnButton_Click;
            // 
            // OffButton
            // 
            OffButton.Location = new Point(86, 360);
            OffButton.Name = "OffButton";
            OffButton.Size = new Size(230, 80);
            OffButton.TabIndex = 1;
            OffButton.Text = "Off";
            OffButton.UseVisualStyleBackColor = true;
            OffButton.Click += OffButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 104);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(586, 20);
            label1.Name = "label1";
            label1.Size = new Size(270, 67);
            label1.TabIndex = 1;
            label1.Text = "Transceiver";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 647);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 86);
            panel5.Name = "panel5";
            panel5.Size = new Size(432, 561);
            panel5.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(thirdMessageButton);
            panel9.Controls.Add(label8);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 300);
            panel9.Name = "panel9";
            panel9.Size = new Size(432, 150);
            panel9.TabIndex = 2;
            // 
            // thirdMessageButton
            // 
            thirdMessageButton.BackColor = Color.White;
            thirdMessageButton.Location = new Point(92, 73);
            thirdMessageButton.Name = "thirdMessageButton";
            thirdMessageButton.Size = new Size(230, 52);
            thirdMessageButton.TabIndex = 3;
            thirdMessageButton.Text = "Send";
            thirdMessageButton.UseVisualStyleBackColor = false;
            thirdMessageButton.Click += brakeSendButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(54, 18);
            label8.Name = "label8";
            label8.Size = new Size(332, 48);
            label8.TabIndex = 0;
            label8.Text = "Stop: 0 1 1 0 0 1 0 1";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(secondMessageButton);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 150);
            panel8.Name = "panel8";
            panel8.Size = new Size(432, 150);
            panel8.TabIndex = 1;
            // 
            // secondMessageButton
            // 
            secondMessageButton.BackColor = Color.White;
            secondMessageButton.Location = new Point(92, 73);
            secondMessageButton.Name = "secondMessageButton";
            secondMessageButton.Size = new Size(230, 52);
            secondMessageButton.TabIndex = 3;
            secondMessageButton.Text = "Send";
            secondMessageButton.UseVisualStyleBackColor = false;
            secondMessageButton.Click += brakeSendButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(47, 22);
            label7.Name = "label7";
            label7.Size = new Size(339, 48);
            label7.TabIndex = 0;
            label7.Text = "Light: 1 0 1 0 1 0 1 0";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(brakeSendButton);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(432, 150);
            panel6.TabIndex = 0;
            // 
            // brakeSendButton
            // 
            brakeSendButton.BackColor = Color.White;
            brakeSendButton.Location = new Point(92, 73);
            brakeSendButton.Name = "brakeSendButton";
            brakeSendButton.Size = new Size(230, 52);
            brakeSendButton.TabIndex = 3;
            brakeSendButton.Text = "Send";
            brakeSendButton.UseVisualStyleBackColor = false;
            brakeSendButton.Click += brakeSendButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(37, 21);
            label4.Name = "label4";
            label4.Size = new Size(349, 48);
            label4.TabIndex = 0;
            label4.Text = "Brake: 1 0 0 1 1 0 0 1";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 86);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(111, 15);
            label3.Name = "label3";
            label3.Size = new Size(196, 54);
            label3.TabIndex = 3;
            label3.Text = "Messages";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(OnButton);
            panel3.Controls.Add(OffButton);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1005, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 647);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(128, 15);
            label2.Name = "label2";
            label2.Size = new Size(142, 54);
            label2.TabIndex = 2;
            label2.Text = "Toggle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(21, 39);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 5;
            label5.Text = "Timer (s): ";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 12F);
            timerLabel.Location = new Point(127, 39);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(76, 32);
            timerLabel.TabIndex = 6;
            timerLabel.Text = "(time)";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(timerResetButton);
            panel7.Controls.Add(timerOffButton);
            panel7.Controls.Add(timerOnButton);
            panel7.Controls.Add(timerLabel);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(432, 104);
            panel7.Name = "panel7";
            panel7.Size = new Size(573, 86);
            panel7.TabIndex = 7;
            // 
            // timerResetButton
            // 
            timerResetButton.BackColor = Color.White;
            timerResetButton.Enabled = false;
            timerResetButton.FlatStyle = FlatStyle.System;
            timerResetButton.Location = new Point(229, 6);
            timerResetButton.Name = "timerResetButton";
            timerResetButton.Size = new Size(97, 34);
            timerResetButton.TabIndex = 8;
            timerResetButton.Text = "Reset";
            timerResetButton.UseVisualStyleBackColor = false;
            timerResetButton.Click += timerResetButton_Click;
            // 
            // timerOffButton
            // 
            timerOffButton.BackColor = Color.LightCoral;
            timerOffButton.Enabled = false;
            timerOffButton.Location = new Point(124, 6);
            timerOffButton.Name = "timerOffButton";
            timerOffButton.Size = new Size(97, 34);
            timerOffButton.TabIndex = 7;
            timerOffButton.Text = "Off";
            timerOffButton.UseVisualStyleBackColor = false;
            timerOffButton.Click += timerOffButton_Click;
            // 
            // timerOnButton
            // 
            timerOnButton.BackColor = Color.FromArgb(128, 255, 128);
            timerOnButton.Location = new Point(21, 6);
            timerOnButton.Name = "timerOnButton";
            timerOnButton.Size = new Size(97, 34);
            timerOnButton.TabIndex = 3;
            timerOnButton.Text = "On";
            timerOnButton.UseVisualStyleBackColor = false;
            timerOnButton.Click += timerOnButton_Click;
            // 
            // log
            // 
            log.BackColor = SystemColors.ActiveCaption;
            log.BorderStyle = BorderStyle.FixedSingle;
            log.Controls.Add(offBulbPicture);
            log.Controls.Add(pictureBox1);
            log.Controls.Add(label6);
            log.Dock = DockStyle.Top;
            log.Location = new Point(432, 190);
            log.Name = "log";
            log.Size = new Size(573, 81);
            log.TabIndex = 8;
            // 
            // offBulbPicture
            // 
            offBulbPicture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            offBulbPicture.BackColor = Color.White;
            offBulbPicture.Image = Properties.Resources.light_bulb_off;
            offBulbPicture.Location = new Point(405, 0);
            offBulbPicture.Margin = new Padding(10);
            offBulbPicture.Name = "offBulbPicture";
            offBulbPicture.Padding = new Padding(10);
            offBulbPicture.Size = new Size(128, 81);
            offBulbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            offBulbPicture.TabIndex = 2;
            offBulbPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.light_bulb_on;
            pictureBox1.Location = new Point(405, 0);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(128, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(21, 18);
            label6.Name = "label6";
            label6.Size = new Size(68, 41);
            label6.TabIndex = 0;
            label6.Text = "Log";
            // 
            // logPanel
            // 
            logPanel.AutoScroll = true;
            logPanel.BackColor = Color.White;
            logPanel.Dock = DockStyle.Fill;
            logPanel.Location = new Point(432, 271);
            logPanel.Name = "logPanel";
            logPanel.Size = new Size(573, 480);
            logPanel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 751);
            Controls.Add(logPanel);
            Controls.Add(log);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            log.ResumeLayout(false);
            log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)offBulbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OnButton;
        private Button OffButton;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
        private Button brakeSendButton;
        private Label label5;
        private Label timerLabel;
        private Panel panel7;
        private Panel log;
        private Label label6;
        private Panel logPanel;
        private PictureBox pictureBox1;
        private PictureBox offBulbPicture;
        private Panel panel9;
        private Button thirdMessageButton;
        private Label label8;
        private Panel panel8;
        private Button secondMessageButton;
        private Label label7;
        private Button timerOnButton;
        private Button timerOffButton;
        private Button timerResetButton;
    }
}
