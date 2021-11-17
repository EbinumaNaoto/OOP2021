using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        private int answerNumber { get; set; } //答えとなる数字
        private int oneSide { get; set; } = 5;//一辺あたりのマス目

        public MainWindow() {
            InitializeComponent();

            SetNumberButton();
            SetAnswerNumber();
        }

        //ボタンを25個配置する処理
        private void SetNumberButton() {
            for (int i = 0; i < Math.Pow(oneSide,2); i++) {
                Button button = new Button();
                button.Content = (i+1).ToString();
                button.Name = $"button{button.Content}";
                button.Click += (sender, e) => Button_Click(sender);
                button.Height = 50;
                button.Width = 50;
                button.FontSize = 30;
                button.SetValue(Grid.RowProperty, i/oneSide); //行 割った数を使う
                button.SetValue(Grid.ColumnProperty,i%oneSide); //列 余りを使う
                gridPanel.Children.Add(button);
            }
        }

        //答えとなる数字を生成する処理
        private void SetAnswerNumber() {
            var random = new Random();
            answerNumber = random.Next(1, (int)Math.Pow(oneSide, 2));
        }

        //ボタンがクリックされた時のイベントハンドラー
        private void Button_Click(object sender) {
            if (answerNumber < int.Parse(((Button)sender).Content.ToString())) {
                answerLabel.Content = "小さい数です";
            } else if (answerNumber > int.Parse(((Button)sender).Content.ToString())) {
                answerLabel.Content = "大きい数です";
            } else {
                answerLabel.Content = "正解です";
            }
            
        }
    }
}
