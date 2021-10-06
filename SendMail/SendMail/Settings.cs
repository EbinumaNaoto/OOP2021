using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail {

    public class Settings {

        //singleton
        private static Settings instance = null;

        public int Port { set; get; }   //ポート番号
        public string Host { set; get; }    //ホスト名
        public string MailAddr { set; get; }    //メールアドレス
        public string Pass { set; get; }    //パスワード
        public bool SSL { set; get; }   //SSL
        public string xmlFileTitle { get { return "mailConfigFile.xml"; } }

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

        public void serialize() {


            //シリアル化するための設定値
            var set = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = "    ",
            };

            //settingsをxmlファイルにシリアル化
            using (var writer = XmlWriter.Create(xmlFileTitle, set)) {
                var serializer = new DataContractSerializer(GetType());
                serializer.WriteObject(writer, this);
            }

        }
        /*
        public void reSerialize() {
            //xmlファイルからsettingsを逆シリアル化
            using (var reader = XmlReader.Create(xmlFileTitle)) {
                var serializer = new DataContractSerializer(typeof(Settings));
                this = serializer.ReadObject(reader) as Settings;
            }
        }
        */
    }
}
