namespace WinFormsColorSelector
{
    partial class Form1
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.labelHue = new System.Windows.Forms.Label();
            this.labelSaturation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(138, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Choose a background color";
            // 
            // listBoxColors
            // 
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.Location = new System.Drawing.Point(16, 30);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(376, 407);
            this.listBoxColors.TabIndex = 1;
            this.listBoxColors.SelectedIndexChanged += new System.EventHandler(this.listBoxColors_SelectedIndexChanged);
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(464, 30);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(59, 13);
            this.labelBrightness.TabIndex = 2;
            this.labelBrightness.Text = "Brightness:";
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(464, 57);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(30, 13);
            this.labelHue.TabIndex = 3;
            this.labelHue.Text = "Hue:";
            // 
            // labelSaturation
            // 
            this.labelSaturation.AutoSize = true;
            this.labelSaturation.Location = new System.Drawing.Point(464, 86);
            this.labelSaturation.Name = "labelSaturation";
            this.labelSaturation.Size = new System.Drawing.Size(58, 13);
            this.labelSaturation.TabIndex = 4;
            this.labelSaturation.Text = "Saturation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSaturation);
            this.Controls.Add(this.labelHue);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.labelInfo);
            this.Name = "Form1";
            this.Text = "WinFormsColorSelector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Label labelSaturation;
    }
}

