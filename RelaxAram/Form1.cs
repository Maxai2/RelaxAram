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

        private void bStart_Click(object sender, EventArgs e) => TimerOnOff();

        DateTime time;
        void timeGo(object sender, EventArgs e)
        {
            if (tbTime.Text == "00:00:00")
            {
                Functions.getInstance().SuperMario();
                TimerOnOff();
                return;
            }

            time = Convert.ToDateTime(tbTime.Text);
            //time.ToLongTimeString(); 

            time = time.AddSeconds(-1);

            tbTime.Text = time.ToLongTimeString();
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(mTBHour.Text);
            int minute = Convert.ToInt32(mTBMinute.Text);
            int second = Convert.ToInt32(mTBSecond.Text);

            if (second < 60)
            {
                second = 0;
                minute++;
            }

            if (minute < 60)
            {
                minute = 0;
                hour++;
            }

            if (hour < 24)
                hour = 0;

            string temp = hour < 10 ? '0' + hour.ToString() : hour.ToString() + ':';
            temp += (minute < 10) ? '0' + minute.ToString() : minute.ToString() + ':';
            temp += (second < 10) ? '0' + second.ToString() : second.ToString();

            tbTime.Text = temp;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            mTBHour.Text = "";
            mTBMinute.Text = "";
            mTBSecond.Text = "";

            tbTime.Text = "00:00:00";
        }
    }
}
