using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void weatherDisplayButton_Click(object sender, EventArgs e) {
            weatherOutputTextbox.Text = "";
            var results = GetWeatherReportFromYahoo(areaNameToAreaCode(areaInputComboBox.Text));
            foreach (var s in results) {
                weatherOutputTextbox.Text += s+"\r\n";
            }
        }

        //検索
        private int areaNameToAreaCode(string areaName) {
            var areaCode = new Dictionary<string, int> {
                                                        {"東京",4410},
                                                        {"大島",4420},
                                                        {"八丈島",4430},
                                                        {"父島",4440},
                                                        {"横浜",4610},
                                                        {"小田原",4620},
                                                        {"さいたま",4310},
                                                        {"熊谷",4320},
                                                        {"秩父",4330},
                                                        {"千葉",4510},
                                                        {"銚子",4520},
                                                        {"館山",4530},
                                                        {"水戸",4010},
                                                        {"土浦",4020},
                                                        {"宇都宮",4110},
                                                        {"大田原",4120},
                                                        {"前橋",4210},
                                                        {"みなかみ",4220},
                                                        {"甲府",4910},
                                                        {"河口湖",4920}, };

            return areaCode[areaName];
        }

        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】|- Yahoo!天気・災害", "");
                    yield return s; //一件ずつデータを渡すことが出来る
                }
            }
        }

    }
}
