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
            logPanel = new Panel();
            label6 = new Label();
            log = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            logPanel.SuspendLayout();
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
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 86);
            panel5.Name = "panel5";
            panel5.Size = new Size(432, 561);
            panel5.TabIndex = 5;
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
            label5.Location = new Point(21, 32);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 5;
            label5.Text = "Timer (s): ";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 12F);
            timerLabel.Location = new Point(127, 32);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(76, 32);
            timerLabel.TabIndex = 6;
            timerLabel.Text = "(time)";
            // 
            // panel7
            // 
            panel7.Controls.Add(timerLabel);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(432, 104);
            panel7.Name = "panel7";
            panel7.Size = new Size(573, 86);
            panel7.TabIndex = 7;
            // 
            // logPanel
            // 
            logPanel.Controls.Add(pictureBox1);
            logPanel.Controls.Add(label6);
            logPanel.Dock = DockStyle.Top;
            logPanel.Location = new Point(432, 190);
            logPanel.Name = "logPanel";
            logPanel.Size = new Size(573, 81);
            logPanel.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(21, 22);
            label6.Name = "label6";
            label6.Size = new Size(68, 41);
            label6.TabIndex = 0;
            label6.Text = "Log";
            // 
            // log
            // 
            log.Dock = DockStyle.Fill;
            log.Location = new Point(432, 271);
            log.Name = "log";
            log.Size = new Size(573, 480);
            log.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(423, 0);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 81);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 751);
            Controls.Add(log);
            Controls.Add(logPanel);
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            logPanel.ResumeLayout(false);
            logPanel.PerformLayout();
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
        private Panel logPanel;
        private Label label6;
        private Panel log;
        private PictureBox pictureBox1;
    }
}
