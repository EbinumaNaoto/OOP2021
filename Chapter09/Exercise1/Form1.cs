using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //9.1.1
        private void buttonOpen_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine(); //1行読み込み
                        if (line.Contains(textBoxKeyWord.Text))
                            count++;
                    }
                    textBoxOutput.Text = $"{textBoxKeyWord.Text}が含まれる行数は{count}行でした。";
                }
            }
                
        }

        //9.1.2
        private void buttonReadAllLines_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                foreach (var line in lines) {
                    textBoxOutput.Text += line + "\r\n";
                }
            }
        }

        //9.1.3
        private void buttonReadLines_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                foreach (var line in lines) {
                    textBoxOutput.Text += line + "\r\n";
                }
            }
        }
    }
}
