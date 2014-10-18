namespace WindowsFormsApplication1
{
    partial class TempConverter
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
            this.celciusinputTextbox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.farenheitLabel = new System.Windows.Forms.Label();
            this.celciusLabel = new System.Windows.Forms.Label();
            this.farenheitoutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // celciusinputTextbox
            // 
            this.celciusinputTextbox.Location = new System.Drawing.Point(156, 52);
            this.celciusinputTextbox.Name = "celciusinputTextbox";
            this.celciusinputTextbox.Size = new System.Drawing.Size(100, 20);
            this.celciusinputTextbox.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(33, 177);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(156, 177);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(100, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // farenheitLabel
            // 
            this.farenheitLabel.AutoSize = true;
            this.farenheitLabel.Location = new System.Drawing.Point(39, 98);
            this.farenheitLabel.Name = "farenheitLabel";
            this.farenheitLabel.Size = new System.Drawing.Size(51, 13);
            this.farenheitLabel.TabIndex = 5;
            this.farenheitLabel.Text = "Farenheit";
            // 
            // celciusLabel
            // 
            this.celciusLabel.AutoSize = true;
            this.celciusLabel.Location = new System.Drawing.Point(39, 52);
            this.celciusLabel.Name = "celciusLabel";
            this.celciusLabel.Size = new System.Drawing.Size(41, 13);
            this.celciusLabel.TabIndex = 4;
            this.celciusLabel.Text = "Celcius";
            // 
            // farenheitoutputLabel
            // 
            this.farenheitoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.farenheitoutputLabel.Location = new System.Drawing.Point(156, 98);
            this.farenheitoutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.farenheitoutputLabel.Name = "farenheitoutputLabel";
            this.farenheitoutputLabel.Size = new System.Drawing.Size(100, 20);
            this.farenheitoutputLabel.TabIndex = 2;
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(302, 262);
            this.Controls.Add(this.farenheitoutputLabel);
            this.Controls.Add(this.farenheitLabel);
            this.Controls.Add(this.celciusLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.celciusinputTextbox);
            this.Name = "TempConverter";
            this.Text = "Celcius To Farenheit Converter";
            this.Load += new System.EventHandler(this.TempConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox celciusinputTextbox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label farenheitLabel;
        private System.Windows.Forms.Label celciusLabel;
        private System.Windows.Forms.Label farenheitoutputLabel;
    }
}

