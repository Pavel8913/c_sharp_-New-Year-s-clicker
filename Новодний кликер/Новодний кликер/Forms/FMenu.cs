using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Новодний_кликер.Forms
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
            label1.Text = "Best score: " + Properties.Settings.Default.Score;
            label2.Text = "Past result: " + Properties.Settings.Default.Result;
            label3.Text = "Coins: " + Properties.Settings.Default.Coins;
            if (Properties.Settings.Default.Metka==true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            //System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            //SoundPlayer sound = new SoundPlayer(Properties.Resources.Music);
            //sp.SoundLocation = "BoneyM-JingleBells.mp3";
            //if (checkBox1.Checked==true)
            //{
            //    sp.Play();
            //}


        }
        SoundPlayer sp = new SoundPlayer("C:\\Music\\Music.wav");
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f =new Form1();
            f.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                sp.PlayLooping();                      
                if (checkBox1.Checked==true)
                {
                    Properties.Settings.Default.Metka = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    sp.Stop();
                    Properties.Settings.Default.Metka = false;
                    Properties.Settings.Default.Save();
                }
                

            }
            catch
            {
                MessageBox.Show("Error 1","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FMenu_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            try 
            { 
            Process.Start("http://t.me/Pavlentyi22/");
            }
            catch
            {
                MessageBox.Show("Error 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FShop f = new FShop();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            scores.Owner = this;
            scores.Show();

        }
    }
}
