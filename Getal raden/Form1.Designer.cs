namespace Getal_raden
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
            Button RaadGetalButton;
            GetalTextBox = new TextBox();
            RaadGetalButton = new Button();
            SuspendLayout();
            // 
            // GetalTextBox
            // 
            GetalTextBox.Location = new Point(12, 12);
            GetalTextBox.Name = "GetalTextBox";
            GetalTextBox.Size = new Size(107, 23);
            GetalTextBox.TabIndex = 0;
            // 
            // RaadGetalButton
            // 
            RaadGetalButton.Location = new Point(125, 12);
            RaadGetalButton.Name = "RaadGetalButton";
            RaadGetalButton.RightToLeft = RightToLeft.No;
            RaadGetalButton.Size = new Size(146, 23);
            RaadGetalButton.TabIndex = 1;
            RaadGetalButton.Text = "Raad getal";
            RaadGetalButton.UseVisualStyleBackColor = true;
            RaadGetalButton.Click += RaadGetalButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 44);
            Controls.Add(RaadGetalButton);
            Controls.Add(GetalTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GetalTextBox;
    }
}
