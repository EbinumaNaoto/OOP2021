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

namespace RssReader {
    public partial class Form1 : Form{

        List<ItemData> items = null;

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            lbTitles.Items.Clear();
            setRssTitle(tbUrl.Text);

        }

        //指定したURL先からXMLデータを取得しtitleを取得し、リストボックスへセットする
        private void setRssTitle(string urlText) {
            try {
                using (var wc = new WebClient()) {
                    wc.Headers.Add("Content-type", "charset=UTF-8");

                    var stream = wc.OpenRead(urlText);

                    XDocument xdoc = XDocument.Load(stream);

                    items = xdoc.Root.Descendants("item").Select(x => new ItemData {
                        Title = x.Element("title").Value,
                        Link = x.Element("link").Value,
                        PubDate = (DateTime)x.Element("pubDate"),
                        Description = x.Element("description").Value
                    }).ToList();

                    foreach (var item in items) {

                        lbTitles.Items.Add(item.Title);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //クリックされたタイトルのlinkをウェブブラウザのurlに取り込む
        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            var item = items[lbTitles.SelectedIndex];
            lbdescription.Text = "概要:"+item.Description+"\r\n更新時間:"+item.PubDate.ToString("F");
        }

        private void btWebDisplay_Click(object sender, EventArgs e) {
            var link = items[lbTitles.SelectedIndex].Link;
            var formWebbrowser = new Form2(link);
            formWebbrowser.Show();
        }

    }
}
