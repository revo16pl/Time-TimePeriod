using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TimeTimePeriod.Lib;
using Timer = System.Threading.Timer;

namespace TimeTimePeriod.StoperGUI
{
    public partial class minutnik : Form
    {
        private bool Stopped = false;

        private Time mainTime = new Time(0, 0, 0);
        private Time addedTime = new Time(0, 0, 1);
        private Time FinalTime = new Time(23, 59, 59);

        public minutnik()
        {
            InitializeComponent();
        }

        private async void button_start_ClickAsync(object sender, EventArgs e)
        {        
            Stopped = false;
            button_start.Visible = false;
            button_start.Enabled = false;

            button_Stop.Visible = true;

            await WaitForSecond();
            button_Stop.Enabled = true;
       
             await CountTimeAsync();                  
        }

        private async void button_Stop_ClickAsync(object sender, EventArgs e)
        {
            Stopped = true;
            button_Stop.Visible = false;
            button_Stop.Enabled = false;

            button_start.Visible = true;

            await WaitForSecond();
            button_start.Enabled = true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            TimeReset();
        }

        private async Task CountTimeAsync()
        {
            
            while (true)
            { 
                if (Stopped)
                {
                    break;
                }
            
                if (!Stopped)
                {
                    if (mainTime == FinalTime)
                    {
                        TimeReset();
                        //wyrzuc komunikat o maksymalnym czasie
                        break;
                    }                 
                    mainTime += addedTime;
                    Label_licznik.Text = mainTime.ToString();
                    await WaitForSecond();
                }                    
            }
        }

        private async Task WaitForSecond()
        {
            await Task.Delay(1000);
        }

        private void TimeReset()
        {
            Stopped = true;
            button_start.Visible = true;
            button_start.Enabled = true;

            button_Stop.Visible = false;
            button_Stop.Enabled = false;

            mainTime = new Time(0, 0, 0);
            Label_licznik.Text = mainTime.ToString();           
        }

        
    }
}
