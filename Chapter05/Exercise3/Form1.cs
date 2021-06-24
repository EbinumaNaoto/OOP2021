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
            wordCountText.Text = inputStringText.Text.Split(' ').Length.ToString();
        }

        //問４
        private void fourLetterWordListButton_Click(object sender, EventArgs e) {
            var fourLetterWordList = inputStringText.Text.Split(' ').Where(s => s.Length <= 4);
            fourLetterWordListText.Text = string.Join(",",fourLetterWordList);
        }

        //問５
        private void reproductionWordButton_Click(object sender, EventArgs e) {
            var sb = new StringBuilder();
            var words = inputStringText.Text.Split(' ');
            foreach (var word in words) {
                sb.Append(word);
                sb.Append(" ");
            }
            reproductionWordText.Text = sb.ToString();
        }

        //問２(応用)
        private void replaceButton_Click(object sender, EventArgs e) {
            replaceText.Text = inputStringText.Text.Replace(beforeReplaceText.Text, afterReplaceText.Text);
        }
    }
}
