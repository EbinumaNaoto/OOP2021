using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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

        private List<Button> buttons = new List<Button>();
        private Random random = new Random();

        private int answerNumber { get; set; } //答えとなる数字
        private int oneSide { get; set; } = 5; //一辺の長さ

        public MainWindow() {
            InitializeComponent();
        }

        //ボタンを配置する処理
        private void SetNumberButton() {
            //行列
            for (int i = 0; i < oneSide; i++) {
                gridPanel.RowDefinitions.Add(new RowDefinition());
                gridPanel.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < Math.Pow(oneSide,2); i++) {
                Button button = new Button();
                button.Content = i+1;
                button.Click += (sender, e) => Button_Click(sender);
                button.Height = MainForm.Height/oneSide;
                button.Width = MainForm.Width/oneSide;
                button.FontSize = 30;
                Grid.SetRow(button, i / oneSide); //行 割った数を使う
                Grid.SetColumn(button, i % oneSide); //列 余りを使う
                buttons.Add(button);
            }
            buttons.ForEach(bt => gridPanel.Children.Add(bt));
            MainForm.Height += answerText.Height + 50;
        }

        //答えとなる数字を生成する処理
        private void SetAnswerNumber() {
            answerNumber = random.Next((int)Math.Pow(oneSide, 2))+1;
        }

        //ボタンがクリックされた時のイベントハンドラー
        private void Button_Click(object sender) {
            if (answerNumber < int.Parse(((Button)sender).Content.ToString())) {
                ((Button)sender).Background = Brushes.Gray;
                answerText.Text = "小さい数です";
            } else if (answerNumber > int.Parse(((Button)sender).Content.ToString())) {
                ((Button)sender).Background = Brushes.Gray;
                answerText.Text = "大きい数です";
            } else {
                ((Button)sender).Background = Brushes.Magenta;
                answerText.Text = "正解です";
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            SetAnswerNumber();
            SetNumberButton();
        }
    }
}
