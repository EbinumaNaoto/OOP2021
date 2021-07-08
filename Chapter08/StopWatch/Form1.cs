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

namespace StopWatch {
    public partial class Form1 : Form {

        //時間計測のストップウォッチオブジェクト
        Stopwatch stopWatch = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        private void StopWatchDisplay(object sender, EventArgs e) {
            TimerDispLabel.Text = stopWatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");            
        }

        private void startButton_Click(object sender, EventArgs e) {
            stopWatch.Start();
            timer.Start();
        }

        private void risetButton_Click(object sender, EventArgs e) {
            stopWatch.Reset();
            StopWatchDisplay(sender,e);
        }

        private void stopButton_Click(object sender, EventArgs e) {
            stopWatch.Stop();
            timer.Stop();
        }

        private void rapButton_Click(object sender, EventArgs e) {
            rapDispListBox.Items.Insert(0,TimerDispLabel.Text);
        }

    }
}
