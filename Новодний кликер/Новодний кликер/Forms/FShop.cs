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
    public partial class FShop : Form
    {
        public FShop()
        {
            InitializeComponent();
            label3.Text = "Coins: " + Properties.Settings.Default.Coins;
        }

        private void FShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FMenu f = new FMenu();
            f.Show();
        }
        public static bool knopka = false;
        public static bool knopkacheked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.coins <= 1000)
            {
                DialogResult = MessageBox.Show("Вы уверены, что хотите преобрести товар?", "Покупка", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult == DialogResult.Yes)
                {
                    knopka = true;
                    Form1.coins -= 1000;
                    button1.Enabled = false;
                    checkBox1.Visible = true;
                }
                else
                {
                    return;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            knopkacheked = true;
        }
    }
}
