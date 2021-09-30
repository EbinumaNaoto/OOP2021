using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail {

    public class Settings {

        private static Settings instance = null;

        public int Port { set; get; }   //ポート番号
        public string Host { set; get; }    //ホスト名
        public string MailAddr { set; get; }    //メールアドレス
        public string Pass { set; get; }    //パスワード
        public bool SSL { set; get; }   //SSL

        //コンストラクタを秘匿にする
        private Settings() {}
        
        //インスタンスを取得する
        public static Settings getInstance() {
            if (instance == null) {
                instance = new Settings();
            }
            return instance;
        }

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
            return "Infosys2021";
        }

    }
}
