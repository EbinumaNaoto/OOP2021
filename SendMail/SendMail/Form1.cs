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

        private void btSend_Click(object sender, EventArgs e) {
            try {

                var address = "ojsinfosys01@gmail.com";
                var password = "Infosys2021";

                //メール送信のためのインスタンスを生成
                var mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(address);
                //宛先(Tb)
                mailMessage.To.Add(tbTo.Text);
                //件名(タイトル)
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                var smtpClient = new SmtpClient();
                smtpClient.Credentials = new NetworkCredential(address,password);
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }*/
        }
    }
}
