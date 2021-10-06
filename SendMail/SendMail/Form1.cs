using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail {
    public partial class Form1 : Form {

        //設定画面
        private ConfigForm configForm = new ConfigForm();

        //設定情報
        private Settings settings = Settings.getInstance();

        //トークン
        private string tokun = null;

        public Form1() {
            InitializeComponent();
        }

        //送信ボタン
        private void btSend_Click(object sender, EventArgs e) {
            try {
                //メール送信のためのインスタンスを生成
                var mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先(To)
                mailMessage.To.Add(tbTo.Text);
                //宛先(Cc)
                if (!string.IsNullOrEmpty(tbCc.Text)) {
                    mailMessage.CC.Add(tbCc.Text);
                }
                //宛先(Bcc)
                if (!string.IsNullOrEmpty(tbBcc.Text)) {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                //件名(タイトル)
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                var smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定(ユーザー,パスワード)
                smtpClient.Credentials = new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.SSL;
                //smtpClient.Send(mailMessage);

                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                smtpClient.SendAsync(mailMessage, tokun);

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
        }

        //送信が完了すると呼ばれるコールバックメソッド
        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            tokun = (string)e.UserState;
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
            }
        }

        private void btConfig_Click(object sender, EventArgs e) {
            configForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {

            //ファイルが存在する場合
            if (File.Exists(settings.xmlFileTitle)) {
                settings.reSerialize();
            } else {    //ファイルが存在しない場合

                //設定画面表示
                configForm.Show();
            }
        }
    }
}
