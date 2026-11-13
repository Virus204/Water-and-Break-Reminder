namespace WaterBreakReminder
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
            components = new System.ComponentModel.Container();
            combo = new ComboBox();
            panel1 = new Panel();
            WaterStartBtn = new Button();
            WaterPauseBtn = new Button();
            WaterResumeBtn = new Button();
            WaterResetBtn = new Button();
            lblWaterCountdown = new Label();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            BreakStartBtn = new Button();
            BreakResetBtn = new Button();
            lblBreakCountdown = new Label();
            cmbBreakInterval = new ComboBox();
            checkBox2 = new CheckBox();
            BreakPauseBtn = new Button();
            BreakResumeBtn = new Button();
            panel3 = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // combo
            // 
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.FormattingEnabled = true;
            combo.Items.AddRange(new object[] { "1 min", "15 min", "30 min", "45 min", "60 min" });
            combo.Location = new Point(17, 99);
            combo.Name = "combo";
            combo.Size = new Size(121, 23);
            combo.TabIndex = 0;
            combo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(WaterStartBtn);
            panel1.Controls.Add(WaterPauseBtn);
            panel1.Controls.Add(WaterResetBtn);
            panel1.Controls.Add(lblWaterCountdown);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(combo);
            panel1.Controls.Add(WaterResumeBtn);
            panel1.Location = new Point(13, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 230);
            panel1.TabIndex = 6;
            // 
            // WaterStartBtn
            // 
            WaterStartBtn.Location = new Point(59, 148);
            WaterStartBtn.Name = "WaterStartBtn";
            WaterStartBtn.Size = new Size(75, 23);
            WaterStartBtn.TabIndex = 8;
            WaterStartBtn.Text = "Start";
            WaterStartBtn.UseVisualStyleBackColor = true;
            WaterStartBtn.Click += WaterStartBtn_Click;
            // 
            // WaterPauseBtn
            // 
            WaterPauseBtn.Location = new Point(59, 148);
            WaterPauseBtn.Name = "WaterPauseBtn";
            WaterPauseBtn.Size = new Size(75, 23);
            WaterPauseBtn.TabIndex = 9;
            WaterPauseBtn.Text = "Pause";
            WaterPauseBtn.UseVisualStyleBackColor = true;
            WaterPauseBtn.Click += WaterPauseBtn_Click;
            // 
            // WaterResumeBtn
            // 
            WaterResumeBtn.Location = new Point(59, 148);
            WaterResumeBtn.Name = "WaterResumeBtn";
            WaterResumeBtn.Size = new Size(75, 23);
            WaterResumeBtn.TabIndex = 10;
            WaterResumeBtn.Text = "Resume";
            WaterResumeBtn.UseVisualStyleBackColor = true;
            WaterResumeBtn.Click += WaterResumeBtn_Click;
            // 
            // WaterResetBtn
            // 
            WaterResetBtn.Location = new Point(161, 148);
            WaterResetBtn.Name = "WaterResetBtn";
            WaterResetBtn.Size = new Size(75, 23);
            WaterResetBtn.TabIndex = 11;
            WaterResetBtn.Text = "Reset";
            WaterResetBtn.UseVisualStyleBackColor = true;
            WaterResetBtn.Click += WaterResetBtn_Click;
            // 
            // lblWaterCountdown
            // 
            lblWaterCountdown.AutoSize = true;
            lblWaterCountdown.Location = new Point(17, 29);
            lblWaterCountdown.Name = "lblWaterCountdown";
            lblWaterCountdown.Size = new Size(92, 15);
            lblWaterCountdown.TabIndex = 3;
            lblWaterCountdown.Text = "Water Reminder";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(161, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "State";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BreakStartBtn);
            panel2.Controls.Add(BreakResetBtn);
            panel2.Controls.Add(lblBreakCountdown);
            panel2.Controls.Add(cmbBreakInterval);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(BreakPauseBtn);
            panel2.Controls.Add(BreakResumeBtn);
            panel2.Location = new Point(599, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 230);
            panel2.TabIndex = 6;
            // 
            // BreakStartBtn
            // 
            BreakStartBtn.Location = new Point(61, 148);
            BreakStartBtn.Name = "BreakStartBtn";
            BreakStartBtn.Size = new Size(75, 23);
            BreakStartBtn.TabIndex = 0;
            BreakStartBtn.Text = "Start";
            BreakStartBtn.UseVisualStyleBackColor = true;
            BreakStartBtn.Click += BreakStartBtn_Click;
            // 
            // BreakResetBtn
            // 
            BreakResetBtn.Location = new Point(173, 148);
            BreakResetBtn.Name = "BreakResetBtn";
            BreakResetBtn.Size = new Size(75, 23);
            BreakResetBtn.TabIndex = 6;
            BreakResetBtn.Text = "Reset";
            BreakResetBtn.UseVisualStyleBackColor = true;
            BreakResetBtn.Click += BreakResetBtn_Click_1;
            // 
            // lblBreakCountdown
            // 
            lblBreakCountdown.AutoSize = true;
            lblBreakCountdown.Location = new Point(15, 29);
            lblBreakCountdown.Name = "lblBreakCountdown";
            lblBreakCountdown.Size = new Size(90, 15);
            lblBreakCountdown.TabIndex = 5;
            lblBreakCountdown.Text = "Break Reminder";
            // 
            // cmbBreakInterval
            // 
            cmbBreakInterval.FormattingEnabled = true;
            cmbBreakInterval.Items.AddRange(new object[] { "1 min", "15 min", "30 min", "45 min ", "60 min" });
            cmbBreakInterval.Location = new Point(15, 95);
            cmbBreakInterval.Name = "cmbBreakInterval";
            cmbBreakInterval.Size = new Size(121, 23);
            cmbBreakInterval.TabIndex = 4;
            cmbBreakInterval.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(173, 99);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(52, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "State";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // BreakPauseBtn
            // 
            BreakPauseBtn.Location = new Point(61, 148);
            BreakPauseBtn.Name = "BreakPauseBtn";
            BreakPauseBtn.Size = new Size(75, 23);
            BreakPauseBtn.TabIndex = 1;
            BreakPauseBtn.Text = "Pause";
            BreakPauseBtn.UseVisualStyleBackColor = true;
            BreakPauseBtn.Click += BreakPauseBtn_Click;
            // 
            // BreakResumeBtn
            // 
            BreakResumeBtn.Location = new Point(61, 148);
            BreakResumeBtn.Name = "BreakResumeBtn";
            BreakResumeBtn.Size = new Size(75, 23);
            BreakResumeBtn.TabIndex = 8;
            BreakResumeBtn.Text = "Resume";
            BreakResumeBtn.UseVisualStyleBackColor = true;
            BreakResumeBtn.Click += BreakResumeBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(-1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1185, 761);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(306, 12);
            label1.Name = "label1";
            label1.Size = new Size(362, 25);
            label1.TabIndex = 7;
            label1.Text = "Good evening! Don't forget to hydrate.";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1110, 638);
            Controls.Add(panel3);
            Controls.Add(linkLabel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox combo;
        private Panel panel1;
        private CheckBox checkBox1;
        private Button WRstop_interval;
        private Button button1;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private ComboBox cmbBreakInterval;
        private ComboBox comboBox2;
        private CheckBox checkBox2;
        private Button button6;
        private Button BreakPauseBtn;
        private Button BreakStartBtn;
        private Label lblWaterCountdown;
        private Label lblBreakCountdown;
        private Panel panel3;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button BreakResetBtn;
        private Button BreakResumeBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Button WaterStartBtn;
        private Button WaterPauseBtn;
        private Button WaterResumeBtn;
        private Button WaterResetBtn;
    }
}
