namespace CodeChallenge.WindowApp
{
    partial class frmOldPhonePad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutputName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(179, 26);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(546, 105);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(173, 208);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(23, 32);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "-";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(25, 29);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(92, 32);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input :";
            // 
            // lblOutputName
            // 
            this.lblOutputName.AutoSize = true;
            this.lblOutputName.Location = new System.Drawing.Point(25, 208);
            this.lblOutputName.Name = "lblOutputName";
            this.lblOutputName.Size = new System.Drawing.Size(115, 32);
            this.lblOutputName.TabIndex = 1;
            this.lblOutputName.Text = "Output :";
            // 
            // frmOldPhonePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblOutputName);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "frmOldPhonePad";
            this.Text = "Old Phone Pad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutputName;
    }
}

