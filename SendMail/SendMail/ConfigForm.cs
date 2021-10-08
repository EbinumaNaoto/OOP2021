using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class ConfigForm : Form {

        //設定情報
        private Settings settings = Settings.getInstance();

        public ConfigForm() {
            InitializeComponent();
        }

        //デフォルト設定
        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost(); //ホスト名
            tbPort.Text = settings.sPort(); //ポート番号
            tbSender.Text = tbUserName.Text = settings.sMailAddr(); //ユーザー名と送信元
            tbPass.Text = settings.sPass(); //パスワード
            cbSSL.Checked = true;   //SSL
        }

        //適用設定
        private void btApply_Click(object sender, EventArgs e) {
            //Settingオブジェクトに入力データを渡して登録
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSSL.Checked);
        }

        //OK設定
        private void btOK_Click(object sender, EventArgs e) {
            btApply_Click(sender, e);

            this.Close();
        }

        //キャンセル設定
        private void btCancel_Click(object sender, EventArgs e) {
            if (!settings.ConfigurationData) {
                MessageBox.Show("データが未設定です");
                return;
            }
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e) {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = tbSender.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSSL.Checked = settings.SSL;
        }
    }
}
