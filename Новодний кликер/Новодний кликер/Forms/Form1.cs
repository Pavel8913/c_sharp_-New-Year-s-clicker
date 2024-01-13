using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Новодний_кликер.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace Новодний_кликер
{
    public partial class Form1 : Form
    {
        public static Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            label3.Text= "Best score: " + Properties.Settings.Default.Score;
            timer.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            if(FShop.knopka==true&&FShop.knopkacheked==true)
            {
                button1.BackgroundImage = Properties.Resources.Кнопка_кликер;
                button1.Size = new Size(231, 231);
                button1.Location = new Point(12, 224);
                button2.Location = new Point(78, 140);
            }
            
        }       
        public static int times=30, rec, cl,pauseres,reccl;
        private void button2_Click(object sender, EventArgs e)
        {           
            timer.Start();
            timers = true;
            times =30;
            cl = 0;
            label2.Text = "Clicks: ";
            button1.Enabled = true;
            button4.Enabled = true;
        }
        private void reset()
        {            
            times = 30;
            cl = 0;
            label2.Text = "Clicks: ";
            button1.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Score = rec;
            //Properties.Settings.Default.Save();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FMenu f = new FMenu();  
            f.Show();
        }
        SoundPlayer sp1 = new SoundPlayer("C:\\Music\\Click.wav");
        private DateTime ElapsedTime = new DateTime(0, 0);
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if(pause==true&&button4.Enabled==true)
            //{
            //    timer.Stop();
            //    pauseres = times;
            //}
            //if(pause==false&& button4.Enabled == false)
            //{
            //    times = pauseres;
            //    timer.Start();
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //e.SuppressKeyPress = true;
            //if (e.KeyData == Keys.Escape)
            //{

            //    FMenu f = new FMenu();
            //    f.ShowDialog();
            //}
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FMenu f = new FMenu();
            f.Show();
        }

        public void button4_Click(object sender, EventArgs e)
        {
                
                FPause f = new FPause();
                timer.Stop();
                f.ShowDialog();
            
        }
        public static bool pause=false;

        private void Form1_Enter(object sender, EventArgs e)
        {            
        }

        public static bool timers = false;
        public static int p;
        public static int coins;

        private void button1_Click(object sender, EventArgs e)
        {
            //sp1.Play();
            cl++;
            label2.Text = "Clicks: " + cl.ToString();
            coins++;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = "Timer: " + (--times).ToString() + " Sec";
            if (times == 0)
            {
                timer.Stop();
                reccl = cl;
                Properties.Settings.Default.Result = reccl;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Coins += coins;
                Properties.Settings.Default.Save();
                if (cl>rec)
                {
                    
                    rec = cl;
                    Properties.Settings.Default.Score = rec;
                    Properties.Settings.Default.Save();
                    label3.Text = "Best score: " + Convert.ToString(rec);
                    MessageBox.Show("Time is over\nYour score: " + rec + "\nBest score: " + rec+ "\nCoins: " + coins, "Game over!", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    reset();
                    
                }
                else
                {
                    MessageBox.Show("Time is over\nYour score: " +cl+"\nBest score: " + rec, "Game over!"+"\nCoins: " + coins, MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    reset();
                }
               
                

            }
        }
    }
}
