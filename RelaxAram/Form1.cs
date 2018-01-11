using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelaxAram
{
    public partial class RelaxTime : Form
    {
        public RelaxTime()
        {
            InitializeComponent();
        }

        private void RelaxAlarm_Load(object sender, EventArgs e)
        {

        } 

        private void bStart_Click(object sender, EventArgs e)
        {
            DateTime time;
            bool start = false;

            System.Threading.Timer timer;
            timer.

            while (tbTime.Text != "00:00:00")
            {
                start = true;

                int num = 0;
                time = Convert.ToDateTime(tbTime.Text);
                //time.ToLongTimeString(); 

                time = time.AddSeconds(-1);

                tbTime.Text = time.ToLongTimeString();

                //TimerCallback tm = new TimerCallback();
                //System.Threading.Timer timer = new System.Threading.Timer(num, 0, 1000);

                //Application.DoEvents();
                //Thread.Sleep(1000);
            }

            if (start)
                Console.Beep(100, 500);
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            string temp = mTBHour.Text + ':' + mTBMinute.Text + ':' + mTBSecond.Text;
            tbTime.Text = temp;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            mTBHour.Text = "";
            mTBMinute.Text = "";
            mTBSecond.Text = "";
        }
    }
}
