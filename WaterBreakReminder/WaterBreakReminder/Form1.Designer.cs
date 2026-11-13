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
            combo = new ComboBox();
            panel1 = new Panel();
            lblWaterCountdown = new Label();
            button3 = new Button();
            checkBox1 = new CheckBox();
            WRstop_interval = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            lblBreakCountdown = new Label();
            cmbBreakInterval = new ComboBox();
            checkBox2 = new CheckBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // combo
            // 
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.FormattingEnabled = true;
            combo.Items.AddRange(new object[] { "15 min", "30 min", "45 min", "60 min" });
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
            panel1.Controls.Add(lblWaterCountdown);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(WRstop_interval);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(combo);
            panel1.Location = new Point(13, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 230);
            panel1.TabIndex = 6;
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
            // button3
            // 
            button3.Location = new Point(88, 177);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
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
            // WRstop_interval
            // 
            WRstop_interval.Location = new Point(161, 148);
            WRstop_interval.Name = "WRstop_interval";
            WRstop_interval.Size = new Size(75, 23);
            WRstop_interval.TabIndex = 1;
            WRstop_interval.Text = "Stop";
            WRstop_interval.UseVisualStyleBackColor = true;
            WRstop_interval.Click += WRstop_interval_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panel2.Controls.Add(lblBreakCountdown);
            panel2.Controls.Add(cmbBreakInterval);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(599, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 230);
            panel2.TabIndex = 6;
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
            cmbBreakInterval.Items.AddRange(new object[] { "15 min", "30 min", "45 min ", "60 min" });
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
            // button6
            // 
            button6.Location = new Point(110, 177);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 2;
            button6.Text = "Reset";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(180, 148);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "Stop";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(36, 148);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "Start";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 761);
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
        private Button button3;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private ComboBox cmbBreakInterval;
        private ComboBox comboBox2;
        private CheckBox checkBox2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label lblWaterCountdown;
        private Label lblBreakCountdown;
        private Panel panel3;
        private Label label1;
    }
}
