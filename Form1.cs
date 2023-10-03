using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RanaClock
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        private int clickCount = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clickCount++;
            

            if (clickCount % 2 ==1 )
            {
                btnPlay.Text = "Stop";
                stopwatch.Start();
                timer1.Enabled = true;
                
            }
            else
            {
                btnPlay.Text = "Play";
                stopwatch.Stop();
                txtMinute.Text = "00";
                txtSecond.Text = "00";
                txtMilliSecond.Text = "00";
                timer1.Enabled = false;
               

            }


        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timespan = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);
            txtMinute.Text = timespan.Minutes.ToString().Length < 2
                ? "0" + timespan.Minutes.ToString()
                : timespan.Minutes.ToString();

            txtSecond.Text = timespan.Seconds.ToString().Length < 2 
                ? "0" + timespan.Seconds.ToString()
                : timespan.Seconds.ToString();

            txtMilliSecond.Text = timespan.Milliseconds.ToString().Length < 2 
                ? "0" + timespan.Milliseconds.ToString()
                : timespan.Milliseconds.ToString();

        }

        private void txtSecond_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {             
                stopwatch.Stop();
                btnPlay.Text = "Play";
                    
            
        }
    }
}
