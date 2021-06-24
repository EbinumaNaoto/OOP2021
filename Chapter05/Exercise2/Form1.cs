using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button5_2_Click(object sender, EventArgs e) {

            int number;
            if (int.TryParse(inputStringNumber.Text,out number)) {
                outputStringNumber.Text = number.ToString("#,#");
            } else {
                outputStringNumber.Text = "変換できません";
            }
        }
    }
}
