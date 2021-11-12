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
        public MainWindow() {
            InitializeComponent();

            SetNumberButton();
        }

        //ボタンを25個配置する処理
        private void SetNumberButton() {
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Button button = new Button();
                    button.Content = ((i+1)*(j+1)).ToString();
                    button.Name = $"button{button.Content}";
                    button.Click += (sender, e) => Button_Click(sender);
                    button.Height = 50;
                    button.Width = 50;
                    button.FontSize = 30;
                    button.SetValue(Grid.RowProperty, i);
                    button.SetValue(Grid.ColumnProperty, j);
                    gridPanel.Children.Add(button);
                }
            }

            for (int i = 1; i <= 25; i++) {
                Button button = new Button();
                button.Content = (i).ToString();
                button.Name = $"button{button.Content}";
                button.Click += (sender, e) => Button_Click(sender);
                button.Height = 50;
                button.Width = 50;
                button.FontSize = 30;
                button.SetValue(Grid.RowProperty, i); //行 割った数を使う
                button.SetValue(Grid.ColumnProperty,i); //列 余りを使う
                gridPanel.Children.Add(button);
            }
        }

        //ボタンがクリックされた時のイベントハンドラー
        private void Button_Click(object sender) {

        }
    }
}
