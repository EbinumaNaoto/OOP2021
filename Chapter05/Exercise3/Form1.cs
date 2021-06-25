using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //フォームがロードされるタイミングで１回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStringText.Text = "Jackdaws love my big sphinx of quartz";
            inputStringData.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        //問１
        private void spaceCountButton_Click(object sender, EventArgs e) {
            spaceCountText.Text = inputStringText.Text.Count(s => s == ' ').ToString();
        }

        //問２
        private void replaceBigWithSmallButton_Click(object sender, EventArgs e) {
            replaceBigWithSmallText.Text = inputStringText.Text.Replace("big", "small");
        }

        //問３
        private void wordCountButton_Click(object sender, EventArgs e) {
            if (inputStringText.Text.Length < 1) {
                wordCountText.Text = "0";
            } else {
                wordCountText.Text = inputStringText.Text.Split(' ').Length.ToString();
            }
        }

        //問４
        private void fourLetterWordListButton_Click(object sender, EventArgs e) {
            var fourLetterWordList = inputStringText.Text.Split(' ').Where(s => s.Length <= 4);
            fourLetterWordListText.Text = string.Join(",",fourLetterWordList);
        }

        //問５
        private void reproductionWordButton_Click(object sender, EventArgs e) {
            var words = inputStringText.Text.Split(' ');
            if (words.Length > 0) {
                var sb = new StringBuilder(words[0]);
                foreach (var word in words.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                reproductionWordText.Text = sb.ToString();
            }
        }

        //問２(応用)
        private void replaceButton_Click(object sender, EventArgs e) {
            replaceText.Text = inputStringText.Text.Replace(beforeReplaceText.Text, afterReplaceText.Text);
        }

        //問5.4
        private void breakButton_Click(object sender, EventArgs e) {
            outputStringData.Text = null;
            foreach (var item in inputStringData.Text.Split(';')) {
                var array = item.Split('=');
                outputStringData.Text += ToJapanees(array[0]) + ":" + array[1] + "\r\n";
                //outputStringData.Text += ToJapanees(array[0]) + ":" + array[1] + Environment.NewLine; //改行
            }
        }

        private string ToJapanees(string English) {
            switch (English) {
                case "Novelist":
                    return "作家　 ";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
