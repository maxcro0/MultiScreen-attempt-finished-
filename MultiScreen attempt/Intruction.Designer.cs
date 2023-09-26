namespace MultiScreen_attempt
{
    partial class Intruction
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
            this.instruBack = new System.Windows.Forms.Button();
            this.InstruLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instruBack
            // 
            this.instruBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruBack.Location = new System.Drawing.Point(154, 246);
            this.instruBack.Name = "instruBack";
            this.instruBack.Size = new System.Drawing.Size(149, 43);
            this.instruBack.TabIndex = 2;
            this.instruBack.Text = "Back";
            this.instruBack.UseVisualStyleBackColor = true;
            this.instruBack.Click += new System.EventHandler(this.instruBack_Click);
            // 
            // InstruLabel
            // 
            this.InstruLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstruLabel.Location = new System.Drawing.Point(69, 70);
            this.InstruLabel.Name = "InstruLabel";
            this.InstruLabel.Size = new System.Drawing.Size(311, 44);
            this.InstruLabel.TabIndex = 3;
            this.InstruLabel.Text = "Instructions";
            this.InstruLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Intruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.InstruLabel);
            this.Controls.Add(this.instruBack);
            this.Name = "Intruction";
            this.Size = new System.Drawing.Size(471, 438);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button instruBack;
        private System.Windows.Forms.Label InstruLabel;
    }
}
