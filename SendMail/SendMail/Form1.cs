using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Settings settings = new Settings();

        private void btSend_Click(object sender, EventArgs e) {
            try {
                //メール送信のためのインスタンスを生成
                var mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先(To)
                mailMessage.To.Add(tbTo.Text);
                //宛先(Cc)
                mailMessage.CC.Add(tbCc.Text);
                //宛先(Bcc)
                mailMessage.Bcc.Add(tbBcc.Text);
                //件名(タイトル)
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                var smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定(ユーザー,パスワード)
                smtpClient.Credentials = new NetworkCredential(settings.MailAddr,settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.SSL;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
        }

        private void btConfig_Click(object sender, EventArgs e) {
            new ConfigForm().ShowDialog();
        }
    }
}
