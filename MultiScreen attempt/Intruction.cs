using System;
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
    public partial class Intruction : UserControl
    {
        public Intruction()
        {
            InitializeComponent();
        }

        private void instruBack_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            Menu ms = new Menu();
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            f.Controls.Add(ms);
        }
    }
}
