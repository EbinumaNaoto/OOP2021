using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace SendMail {

    public class Settings {

        //singleton
        private static Settings instance = null;

        public int Port { set; get; }   //ポート番号
        public string Host { set; get; }    //ホスト名
        public string MailAddr { set; get; }    //メールアドレス
        public string Pass { set; get; }    //パスワード
        public bool SSL { set; get; }   //SSL

        public bool ConfigurationData { private set; get; } = false; //データが登録されているかどうか
        
        //コンストラクタを秘匿にする
        private Settings() {}
        
        //インスタンスを取得する
        public static Settings getInstance() {
            if (instance == null) {
                instance = new Settings();

                try {
                    //逆シリアル化
                    if (File.Exists("mailConfigFile.xml")) {
                        //xmlファイルからsettingsを逆シリアル化
                        using (var reader = XmlReader.Create("mailConfigFile.xml")) {
                            var serializer = new DataContractSerializer(typeof(Settings));
                            var set = serializer.ReadObject(reader) as Settings;

                            //ディープコピー
                            instance.Host = set.Host;
                            instance.Port = set.Port;
                            instance.MailAddr = set.MailAddr;
                            instance.Pass = set.Pass;
                            instance.SSL = set.SSL;

                            //登録完了
                            instance.ConfigurationData = true;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

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

        //送信データ登録
        public void setSendConfig(string host, int port, string mailAddr, string pass, bool ssl) {

            Host = host;
            Port = port;
            MailAddr = mailAddr;
            Pass = pass;
            SSL = ssl;

            //登録完了
            ConfigurationData = true;


            //シリアル化するための設定値
            var set = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = "    ",
            };

            //settingsをxmlファイルにシリアル化
            using (var writer = XmlWriter.Create("mailConfigFile.xml", set)) {
                var serializer = new DataContractSerializer(GetType());
                serializer.WriteObject(writer, this);
            }
        }
    }
}
