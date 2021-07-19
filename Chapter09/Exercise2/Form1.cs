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

namespace Exercise2 {
    public partial class Form1 : Form {

        string inputPath = ""; //変換元ファイル(読み込むファイル)
        string outputPath = ""; //変換先ファイル
        string[] lines = null;

        public Form1() {
            InitializeComponent();
        }

        //変換元のファイルを指定
        private void buttonOpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                inputPath = openFileDialog.FileName;
            }
        }

        //変換したファイルの保存
        private void buttonChangeFile_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                outputPath = saveFileDialog.FileName;
                File.WriteAllLines(outputPath,lines);
            }
        }

        //行番号を追加する処理
        private void buttonChange_Click(object sender, EventArgs e) {
            lines = File.ReadLines(inputPath, Encoding.UTF8).Select((s, index) => string.Format($"{index + 1}: {s}")).ToArray();
        }

        //テキストファイルの挿入する処理
        private void buttonTextFileAdd_Click(object sender, EventArgs e) {
            if (openFileDialogAdd.ShowDialog() == DialogResult.OK) {
                using (var writer = new StreamWriter(openFileDialogAdd.FileName, append: true)) {
                    
                }
            }

        }
    }
}
