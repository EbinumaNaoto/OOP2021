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
        public ConfigForm() {
            InitializeComponent();
        }

        private Settings settings = new Settings();

        //デフォルト設定
        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbSender.Text = tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSSL.Checked = true;
        }

        //適用設定
        private void btApply_Click(object sender, EventArgs e) {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.SSL = cbSSL.Checked;
        }

        //OK設定
        private void btOK_Click(object sender, EventArgs e) {
            btApply_Click(sender,e);
            Close();
        }

        //キャンセル設定
        private void btCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
