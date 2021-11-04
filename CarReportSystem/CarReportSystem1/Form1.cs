﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem1 {
    public partial class fmMain : Form {

        public fmMain() {
            InitializeComponent();
        }

        //終了ボタン
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit(); //アプリケーションの終了
        }

        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //選択されているメーカーの列挙を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }  
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        //グループボックスにメーカーをセットする
        private void setMakerRadioButton(string maker) {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Text.Equals(maker)) {
                    ((RadioButton)rb).Checked = true;
                    return;
                }
            }
            ((RadioButton)gbMaker.Controls[0]).Checked = true;
        }

        //接続ボタン
        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202127DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202127DataSet.CarReport);
            for (int i = 1; i < carReportDataGridView.RowCount; i++) {
                setCbAuthor(carReportDataGridView.Rows[i-1].Cells[2].Value.ToString());
                setCbCarName(carReportDataGridView.Rows[i-1].Cells[4].Value.ToString());
            }
        }

        //更新ボタン
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;       //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;      //記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();   //メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   //車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;   //レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);//写真

            //データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202127DataSet);
        }

        private void fmMain_Load(object sender, EventArgs e) {
            //dgvRegistData.Columns[5].Visible = false;
            ssErrorLabel.Text = "";
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].Visible = false;
        }

        //DataGridViewが選択された時の処理
        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            ssErrorLabel.Text = "";
            if (carReportDataGridView.CurrentRow == null) return;

            try {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value; //日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString(); //記録者
                setMakerRadioButton(carReportDataGridView.CurrentRow.Cells[3].Value.ToString()); //メーカー
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString(); //車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString(); //レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value); //写真
            } catch (InvalidCastException) {
                pbPicture.Image = null;
            } catch (Exception ex) {
                ssErrorLabel.Text = ex.Message; //ステータスエリアに表示する
            }
        }

        // バイト配列をImageオブジェクトに変換
        private static Image ByteArrayToImage(byte[] b) {
            Image img = null;
            if (b.Length > 0) {
                ImageConverter imgconv = new ImageConverter();
                img = (Image)imgconv.ConvertFrom(b);
            }
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        private static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //エラー処理
        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        //新規作成をクリックしたときに呼ばれるイベントハンドラ
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;
            dtpDate.Value = DateTime.Now; //日付
            cbAuthor.Text = ""; //記録者
            setMakerRadioButton("その他"); //メーカー
            cbCarName.Text = ""; //車名
            tbReport.Text = ""; //レポート
            pbPicture.Image = null; //写真
        }
    }
}
