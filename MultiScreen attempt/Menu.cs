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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            gameScreen gs = new gameScreen();
            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
            f.Controls.Add(gs);
            
        }

        private void intruButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            Intruction ins = new Intruction();
            ins.Location = new Point((this.Width - ins.Width) / 2, (this.Height - ins.Height) / 2);
            f.Controls.Add(ins);
        }
    }
}
