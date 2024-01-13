using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Новодний_кликер.Forms
{
    public partial class FPause : Form
    {
        public FPause()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.timer.Start();
        }

        private void FPause_Load(object sender, EventArgs e)
        {
            //Form1.pause = true;
        }

        private void FPause_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1.pause = false;
            //Form1.times = Form1.pauseres;
            //Form1.timer.Start();
            Form1.timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Вы уверены, что хотите выйти?\nИгоровой прогресс будет утерян","Выход",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(DialogResult==DialogResult.OK)
            {
                this.Hide();
                FMenu f = new FMenu();
                f.Show();
                //this.Hide();
                //FMenu f2 = new FMenu();
                //f2.Show();

            }
            
        }
    }
}
