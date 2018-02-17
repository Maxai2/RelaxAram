using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelaxAram
{
    public partial class RelaxTime : Form
    {
        Timer timer = null;
        public RelaxTime()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timeGo);
        }

        void TimerOnOff() => timer.Enabled = !timer.Enabled;

        bool WorkState = false;
        int Work = 30 * 60;
        int Rest = 5 * 60;
        int Curr;

        private void bStart_Click(object sender, EventArgs e)
        {
            TimerOnOff();

            if (timer.Enabled)
            {
                bStart.Text = "Stop";
                WorkState = true;
                Curr = Work;
            }
            else
            {
                bStart.Text = "Start";
            }
        }

        DateTime time;

        void timeGo(object sender, EventArgs e)
        {
            Curr--;

            if (Curr == 0)
            {
                Console.Beep();

                WorkState = !WorkState;

                if (WorkState)
                {
                    Curr = Work;
                }
                else
                {
                    Curr = Rest;
                }
            }
            else
            {
                int sec = Curr % 60;
                int min = Curr / 60;

                string timeShow = "";

                timeShow += min < 10 ? '0' + min.ToString() : min.ToString();

                timeShow += ':';

                timeShow += sec < 10 ? '0' + sec.ToString() : sec.ToString();

                tbTime.Text = timeShow;
            }

            //if (tbTime.Text == "00:00:00")
            //{
            //    Functions.getInstance().SuperMario();
            //    TimerOnOff();
            //    return;
            //}

            //time = Convert.ToDateTime(tbTime.Text);
            ////time.ToLongTimeString(); 

            //time = time.AddSeconds(-1);

            //tbTime.Text = time.ToLongTimeString();
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            //int hour = Convert.ToInt32(mTBHour.Text);
            int minute = Convert.ToInt32(mTBWMinute.Text);
            int second = Convert.ToInt32(mTBWSecond.Text);
            Work = minute * 60 + second;

            minute = Convert.ToInt32(mTBRMinute.Text);
            second = Convert.ToInt32(mTBRSecond.Text);
            Rest = minute * 60 + second;

            //if (second < 60)
            //{
            //    second = 0;
            //    minute++;
            //}

            //if (minute < 60)
            //{
            //    minute = 0;
            //    //hour++;
            //}

            //if (hour < 24)
            //    hour = 0;

            //string temp = hour < 10 ? '0' + hour.ToString() : hour.ToString() + ':';
            //temp += (minute < 10) ? '0' + minute.ToString() : minute.ToString() + ':';
            //temp += (second < 10) ? '0' + second.ToString() : second.ToString();

            //tbTime.Text = temp;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
//            mTBHour.Text = "";
            mTBWMinute.Text = "";
            mTBWSecond.Text = "";

            tbTime.Text = "00:00";
        }
    }
}
