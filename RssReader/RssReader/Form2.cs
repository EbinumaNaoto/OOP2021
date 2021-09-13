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
            if (wbBrowser.CanGoBack == true) {
                btback.Enabled = true;
            } else {
                btback.Enabled = false;
            }

            if (wbBrowser.CanGoForward == true) {
                btAdvance.Enabled = true;
            } else {
                btAdvance.Enabled = false;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            wbBrowser.Refresh();
        }

        private void btHome_Click(object sender, EventArgs e) {
            wbBrowser.Url = new System.Uri("https://www.yahoo.co.jp/");
        }
    }
}
