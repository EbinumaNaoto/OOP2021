﻿using System;
using System.Collections.Generic;
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

namespace SampleGridApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        
        private void cheakBox_Checked(object sender, RoutedEventArgs e) {
            cheakBoxTextBlock.Text = "チェック済み";
        }

        private void cheakBox_Unchecked(object sender, RoutedEventArgs e) {
            cheakBoxTextBlock.Text = "未チェック";
        }

        private void redRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "赤";
            colorTextBox.Background = Brushes.Red;
            colorTextBox.Foreground = Brushes.White;
        }

        private void yellowRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "黄";
            colorTextBox.Background = Brushes.Yellow;
            colorTextBox.Foreground = Brushes.Black;
        }

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "青";
            colorTextBox.Background = Brushes.Blue;
            colorTextBox.Foreground = Brushes.White;
        }

        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = ((ComboBoxItem)seasonComboBox.SelectedItem).Content.ToString();
        }
    }
}