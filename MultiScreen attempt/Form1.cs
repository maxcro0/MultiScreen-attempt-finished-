﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiScreen_attempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Menu ms = new Menu();
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
          

            
        }
    }
}
