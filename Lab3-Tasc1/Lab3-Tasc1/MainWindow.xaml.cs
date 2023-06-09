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

namespace Lab3_Tasc1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click_ChangeColor(object sender, RoutedEventArgs e)
        {
            
            SolidColorBrush colorBrush = new SolidColorBrush(Colors.Green);
            this.Background = colorBrush;

            // Обновление информации в строке состояния
            statusBarText.Text = "Цвет фона изменен на зелёный";
        }

        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            // Отображение информации о разработчике
            MessageBox.Show("Студенты ВСПК");

            // Обновление информации в строке состояния
            statusBarText.Text = "Открыто диалоговое окно ";
        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            // Закрытие приложения
            this.Close();
        }
    }
}
