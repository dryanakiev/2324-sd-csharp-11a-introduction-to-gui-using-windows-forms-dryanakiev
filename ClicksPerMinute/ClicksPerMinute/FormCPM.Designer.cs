namespace ClicksPerMinute
{
    partial class FormCPM
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
            buttonStart = new Button();
            label1 = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Dock = DockStyle.Bottom;
            buttonStart.Location = new Point(0, 224);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(282, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 95);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Good luck!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerCountdown
            // 
            timerCountdown.Interval = 10000;
            timerCountdown.Tick += timerCountdown_Tick;
            // 
            // FormCPM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Name = "FormCPM";
            Text = "Form1";
            Click += FormCPM_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label label1;
        private System.Windows.Forms.Timer timerCountdown;
    }
}