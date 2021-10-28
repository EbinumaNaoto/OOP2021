using System;
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

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
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

        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbCarName.Text == "" || cbAuthor.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            }

            CarReport carReport = new CarReport { 
                Date = dtpDate.Value ,
                Auther = cbAuthor.Text ,
                Maker = selectedGroup() ,
                CarName = cbCarName.Text ,
                Report = tbReport.Text ,
                Picture = pbPicture.Image,
            };
            listCarReport.Add(carReport);

            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
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
        }

        //listCarReportを表示する
        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            //選択された行のデータを取得
            if (e.RowIndex.Equals(-1))
                return;
            CarReport selectedCar = listCarReport[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
            setMakerRadioButton(selectedCar.Maker.ToString());
        }

        //接続ボタン
        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202127DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202127DataSet.CarReport);
#if false
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }

                    //読みこんだデータを各コンボボックスに登録する
                    foreach (var selectedCar in listCarReport) {
                        setCbAuthor(selectedCar.Auther);
                        setCbCarName(selectedCar.CarName);
                    }
                    /*
                    //データグリッドビューから取得
                    for (int i = 0; i < dgvRegistData.RowCount; i++) {
                        setCbAuthor(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                        setCbCarName(dgvRegistData.Rows[i].Cells[3].Value.ToString());
                    }
                    */
                } catch (FileNotFoundException fileNotFoundException) {
                    MessageBox.Show("ファイルが見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(fileNotFoundException.Message);
                } catch (SerializationException serializationException) {
                    MessageBox.Show("ファイル形式が違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(serializationException.Message);
                }
            }
#endif
        }

        //削除ボタン
        private void btDataDelete_Click(object sender, EventArgs e) {
#if false
            if (dgvRegistData.CurrentRow == null)
                return;
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
#endif
        }

        //修正ボタン
        private void btDataCorrect_Click(object sender, EventArgs e) {
#if false
            if (dgvRegistData.CurrentRow == null)
                return;
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,cbAuthor.Text,selectedGroup(),cbCarName.Text,tbReport.Text,pbPicture.Image);
            dgvRegistData.Refresh();    //コントロールの強制再描画
#endif
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
#if false
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create))
                        bf.Serialize(fs, listCarReport);
                } catch (IOException ioException) {
                    MessageBox.Show("ファイルを保存できませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ioException.Message);
                }
            }
#endif
        }

        private void fmMain_Load(object sender, EventArgs e) {
            //dgvRegistData.Columns[5].Visible = false;
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].Visible = false;
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {

        }

        //DataGridViewが選択された時の処理
        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;

            try {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value; //日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString(); //記録者
                setMakerRadioButton(carReportDataGridView.CurrentRow.Cells[3].Value.ToString()); //メーカー
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString(); //車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString(); //レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value); //写真
                setCbAuthor(cbAuthor.Text); //記録者をセット
                setCbCarName(cbCarName.Text); //車名をセット
            } catch (Exception) {
                pbPicture.Image = null;
            }
            
        }

        // バイト配列をImageオブジェクトに変換
        private static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        private static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
    }
}
