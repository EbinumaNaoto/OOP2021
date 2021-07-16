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
            dgvRegistData.DataSource = listCarReport;
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
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Text.Equals(selectedCar.Maker.ToString())) {
                    ((RadioButton)rb).Checked = true;
                }
            }
        }

        //開くボタン
        private void btOpen_Click(object sender, EventArgs e) {
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
        }

        //削除ボタン
        private void btDataDelete_Click(object sender, EventArgs e) {
            if (dgvRegistData.CurrentRow == null)
                return;
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        //修正ボタン
        private void btDataCorrect_Click(object sender, EventArgs e) {
            if (dgvRegistData.CurrentRow == null)
                return;
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,cbAuthor.Text,selectedGroup(),cbCarName.Text,tbReport.Text,pbPicture.Image);
            dgvRegistData.Refresh();    //コントロールの強制再描画
        }

        //保存ボタン
        private void btSave_Click(object sender, EventArgs e) {
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
        }

        //フォーム1に読みもむメソッド
        private void fmMain_Load(object sender, EventArgs e) {
            dgvRegistData.Columns[5].Visible = false;
        }
    }
}
