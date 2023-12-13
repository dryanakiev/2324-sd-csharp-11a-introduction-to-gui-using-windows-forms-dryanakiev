namespace SimpleButtonClicker
{
    partial class ButtonSmasher
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
            buttonClicker = new Button();
            labelCounter = new Label();
            SuspendLayout();
            // 
            // buttonClicker
            // 
            buttonClicker.Location = new Point(87, 197);
            buttonClicker.Name = "buttonClicker";
            buttonClicker.Size = new Size(94, 29);
            buttonClicker.TabIndex = 0;
            buttonClicker.Text = "Click me!";
            buttonClicker.UseVisualStyleBackColor = true;
            buttonClicker.Click += buttonClicker_Click;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(46, 80);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(0, 20);
            labelCounter.TabIndex = 1;
            // 
            // ButtonSmasher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(labelCounter);
            Controls.Add(buttonClicker);
            Name = "ButtonSmasher";
            Text = "Button Smasher!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClicker;
        private Label labelCounter;
    }
}