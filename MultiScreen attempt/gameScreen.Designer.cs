namespace MultiScreen_attempt
{
    partial class gameScreen
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
            this.gameLabel = new System.Windows.Forms.Label();
            this.gameBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameLabel.Location = new System.Drawing.Point(88, 60);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(311, 44);
            this.gameLabel.TabIndex = 1;
            this.gameLabel.Text = "Game";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameBack
            // 
            this.gameBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBack.Location = new System.Drawing.Point(175, 232);
            this.gameBack.Name = "gameBack";
            this.gameBack.Size = new System.Drawing.Size(149, 43);
            this.gameBack.TabIndex = 2;
            this.gameBack.Text = "Back";
            this.gameBack.UseVisualStyleBackColor = true;
            this.gameBack.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.gameBack);
            this.Controls.Add(this.gameLabel);
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(498, 506);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Button gameBack;
    }
}
