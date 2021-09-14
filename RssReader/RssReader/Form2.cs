using System;
using System.Windows.Forms;

namespace RssReader {
    public partial class Form2 : Form {

        public Form2(string link) {
            InitializeComponent();
            wbBrowser.Navigate(link);
        }

        private void btback_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btAdvance_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            //前のページに履歴がある場合、戻るボタンを有効にする
            btback.Enabled = (wbBrowser.CanGoBack == true) ? true : false;

            //次のページに履歴がある場合、進むボタンを有効にする
            btAdvance.Enabled = (wbBrowser.CanGoForward == true) ? true : false;
            
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            wbBrowser.Refresh();
        }

        private void btHome_Click(object sender, EventArgs e) {
            wbBrowser.Url = new System.Uri("https://www.yahoo.co.jp/");
        }
    }
}
