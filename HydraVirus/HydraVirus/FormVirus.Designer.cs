namespace HydraVirus
{
    partial class FormVirus
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
            buttonCut = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCut
            // 
            buttonCut.Location = new Point(131, 212);
            buttonCut.Name = "buttonCut";
            buttonCut.Size = new Size(94, 29);
            buttonCut.TabIndex = 0;
            buttonCut.Text = "Cut off";
            buttonCut.UseVisualStyleBackColor = true;
            buttonCut.Click += buttonCut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(336, 20);
            label1.TabIndex = 1;
            label1.Text = "\"Cut off one of my head and two more will show\"";
            // 
            // FormVirus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 253);
            Controls.Add(label1);
            Controls.Add(buttonCut);
            Name = "FormVirus";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hydra doin'?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCut;
        private Label label1;
    }
}