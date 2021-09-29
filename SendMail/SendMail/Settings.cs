using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail {

    public class Settings {

        public int Port { set; get; }   //ポート番号
        public string Host { set; get; }    //ホスト名
        public string MailAddr { set; get; }    //メールアドレス
        public string Pass { set; get; }    //パスワード
        public bool SSL { set; get; }   //SSL

        //初期値
        public string sHost() {
            return "smtp.gmail.com";
        }

        public string sPort() {
            return 587.ToString();
        }

        public string sMailAddr() {
            return "ojsinfosys01@gmail.com";
        }

        public string sPass() {
            return "OjsInfosys2019";
        }

    }
}
