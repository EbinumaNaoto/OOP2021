﻿using System;
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
    public partial class Form1 : Form {
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
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    
                    lbTitles.Items.Add(node);
                }
            }
        }

        //クリックされたタイトルのlinkをウェブブラウザのurlに取り込む
        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            var titleItem = (XElement)lbTitles.SelectedItem;
            var link = Regex.Replace(titleItem.NextNode.ToString(), "<link>|</link>", "");

            wbBrowser.Navigate(link);

            //クリックしたタイトルのdescriptionを表示

            lbdescription.Text = titleItem.Parent.Element("description").Value;
        }
    }
}