namespace MultiScreen_attempt
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.intruButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intruButton
            // 
            this.intruButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intruButton.Location = new System.Drawing.Point(166, 346);
            this.intruButton.Name = "intruButton";
            this.intruButton.Size = new System.Drawing.Size(149, 43);
            this.intruButton.TabIndex = 5;
            this.intruButton.Text = "Intsructions";
            this.intruButton.UseVisualStyleBackColor = true;
            this.intruButton.Click += new System.EventHandler(this.intruButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(166, 263);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(149, 43);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuLabel.Location = new System.Drawing.Point(81, 105);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(311, 44);
            this.menuLabel.TabIndex = 3;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.intruButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuLabel);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(472, 494);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button intruButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label menuLabel;
    }
}
