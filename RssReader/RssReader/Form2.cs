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
    }
}
