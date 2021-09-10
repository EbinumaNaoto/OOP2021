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

        List<XElement> xitem = new List<XElement>();

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            lbTitles.Items.Clear();
            setRssTitle(tbUrl.Text);

        }

        //指定したURL先からXMLデータを取得しtitleを取得し、リストボックスへセットする
        private void setRssTitle(string urlText) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(urlText);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("item");
                foreach (var node in nodes) {
                    
                    lbTitles.Items.Add(node.Element("title").Value);
                    xitem.Add(node);
                }
            }
        }

        //クリックされたタイトルのlinkをウェブブラウザのurlに取り込む
        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            var item = xitem[lbTitles.SelectedIndex];
            

            lbdescription.Text = item.Element("description").Value+"\r\n"+item.Element("pubDate").Value;

            //wbBrowser.Navigate(link);

        }

        private void btWebDisplay_Click(object sender, EventArgs e) {
            var link = xitem[lbTitles.SelectedIndex].Element("link").Value;
            var formWebbrowser = new Form2(link);
            formWebbrowser.Show();
        }
    }
}
