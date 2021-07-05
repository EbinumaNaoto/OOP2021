using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            textBoxDateDisp.Text = string.Format("{0:yyyy/MM/dd HH:mm}",today)+"\r\n";
            //textBoxDateDisp.Text = today.ToString("d");

            textBoxDateDisp.Text += string.Format("{0:yyyy年MM月dd日 HH時mm分ss秒}",today)+"\r\n";

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var str = today.ToString("ggyy",culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(today.DayOfWeek);

            textBoxDateDisp.Text += string.Format("{0}年{1,2}月{2,2}日({3})",str,today.Month,today.Day,dayOfWeek);
        }

        private void Form1_Load(object sender, EventArgs e) {
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            timer.Start();
            toolStripStatusTimeLabel.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
        }

        private void Timer_Tick(object sender, EventArgs e) {
            toolStripStatusTimeLabel.Text = string.Format("{0:HH:mm:ss}",DateTime.Now);
        }
    }
}
