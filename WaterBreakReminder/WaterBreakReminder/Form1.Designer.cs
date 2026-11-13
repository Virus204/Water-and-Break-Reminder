
namespace WaterBreakReminder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            chkSound = new CheckBox();

            SuspendLayout();

            // button1
            button1.Location = new Point(507, 66);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 0;
            button1.Text = "Water Reminder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // button2
            button2.Location = new Point(354, 66);
            button2.Name = "button2";
            button2.Size = new Size(120, 35);
            button2.TabIndex = 1;
            button2.Text = "Break Reminder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            // chkSound
            chkSound.AutoSize = true;
            chkSound.Location = new Point(459, 120);
            chkSound.Name = "chkSound";
            chkSound.Size = new Size(98, 19);
            chkSound.TabIndex = 2;
            chkSound.Text = "Enable Sound";
            chkSound.UseVisualStyleBackColor = true;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkSound);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Water & Break Reminder";
            Load += Form1_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private CheckBox chkSound;
    }
}
