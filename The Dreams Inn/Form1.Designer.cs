namespace The_Dreams_Inn
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
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.outputImageLabel = new System.Windows.Forms.Label();
            this.yButton = new System.Windows.Forms.Label();
            this.rButton = new System.Windows.Forms.Label();
            this.bButton = new System.Windows.Forms.Label();
            this.gButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(385, 375);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(284, 32);
            this.redLabel.TabIndex = 0;
            this.redLabel.Text = "Red";
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.Location = new System.Drawing.Point(385, 417);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(284, 29);
            this.greenLabel.TabIndex = 1;
            this.greenLabel.Text = "Green";
            this.greenLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // yellowLabel
            // 
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.Location = new System.Drawing.Point(60, 375);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(261, 32);
            this.yellowLabel.TabIndex = 2;
            this.yellowLabel.Text = "Yellow";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 299);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(648, 66);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLabel
            // 
            this.blueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Location = new System.Drawing.Point(60, 417);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(261, 29);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "Blue";
            // 
            // outputImageLabel
            // 
            this.outputImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputImageLabel.Location = new System.Drawing.Point(70, 9);
            this.outputImageLabel.Name = "outputImageLabel";
            this.outputImageLabel.Size = new System.Drawing.Size(526, 276);
            this.outputImageLabel.TabIndex = 5;
            // 
            // yButton
            // 
            this.yButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yButton.Location = new System.Drawing.Point(12, 380);
            this.yButton.Name = "yButton";
            this.yButton.Size = new System.Drawing.Size(28, 23);
            this.yButton.TabIndex = 6;
            this.yButton.Text = "N";
            this.yButton.Click += new System.EventHandler(this.yButton_Click);
            // 
            // rButton
            // 
            this.rButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rButton.Location = new System.Drawing.Point(338, 380);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(31, 23);
            this.rButton.TabIndex = 7;
            this.rButton.Text = "M";
            // 
            // bButton
            // 
            this.bButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bButton.Location = new System.Drawing.Point(12, 422);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(28, 23);
            this.bButton.TabIndex = 8;
            this.bButton.Text = "B";
            // 
            // gButton
            // 
            this.gButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gButton.Location = new System.Drawing.Point(338, 417);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(41, 23);
            this.gButton.TabIndex = 9;
            this.gButton.Text = "Space";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 455);
            this.Controls.Add(this.gButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.yButton);
            this.Controls.Add(this.outputImageLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Name = "Form1";
            this.Text = "The Dreams Inn";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label outputImageLabel;
        private System.Windows.Forms.Label yButton;
        private System.Windows.Forms.Label rButton;
        private System.Windows.Forms.Label bButton;
        private System.Windows.Forms.Label gButton;
    }
}

