using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Новодний_кликер.Forms;

namespace Новодний_кликер.Resources.Forms
{
    public partial class FStart : Form
    {
        public FStart()
        {
            InitializeComponent();
            timer1.Start();
            
        }
        int a = 3;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --a;
            if (a == 0)
            {
                timer1.Stop();
                this.Hide();
                FMenu f = new FMenu();
                f.Show();
            }
        }
    }
}
