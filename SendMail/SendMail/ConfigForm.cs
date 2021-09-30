using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SettingRegist();
        }

        //OK設定
        private void btOK_Click(object sender, EventArgs e) {
            SettingRegist();
            this.Close();
        }

        //キャンセル設定
        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SettingRegist() {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.SSL = cbSSL.Checked;
        }
    }
}
