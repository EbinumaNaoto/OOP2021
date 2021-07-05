using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonAction_Click(object sender, EventArgs e) { 
            var date = new DateTime((int)numericUpDownYear.Value,(int)numericUpDownMonth.Value,(int)numericUpDownDay.Value);
            #region 曜日を求める
            /*
            DayOfWeek dayOfWeek = date.DayOfWeek;
            
            char dow = ' ';

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = '日';
                    break;
                case DayOfWeek.Monday:
                    dow = '月';              
                    break;
                case DayOfWeek.Tuesday:
                    dow = '火';
                    break;
                case DayOfWeek.Wednesday:
                    dow = '水';
                    break;
                case DayOfWeek.Thursday:
                    dow = '木';
                    break;
                case DayOfWeek.Friday:
                    dow = '金';
                    break;
                case DayOfWeek.Saturday:
                    dow = '土';
                    break;
            }
            textBoxOutput.Text = dow + "曜日です";
            */
            #endregion
            #region 閏年判定
            if (DateTime.IsLeapYear((int)numericUpDownYear.Value))
                textBoxLeapYear.Text = "閏年です。";
            else
                textBoxLeapYear.Text = "閏年ではありません。";
            #endregion
            #region 日数差計算
            var diff = DateTime.Now.Date - date.Date;

            textBoxOutput.Text = $"今日から{Math.Abs(diff.Days)}日間まで差があります。";
            #endregion
            var today = DateTime.Today;
            var age = GetAge(dateTimePickerBirthday.Value, today);
            textBoxOutputAge.Text = $"現在の年齢は{age}歳です";

        }

        private int GetAge(DateTime brithday, DateTime targetDay) {
            var age = targetDay.Year - brithday.Year;
            if (targetDay < brithday.AddYears(age))
                age--;
            return age;

        }
    }
}
