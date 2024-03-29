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

namespace _215_pract2_skvor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Manager4.MainFrame = MainFrame;
            MainFrame.Navigate(new Task1Page());
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 1

            //int number = Convert.ToInt32(TbNumberA.Text);
            //int firstDigit = number / 100;

            //TextBlockAnswer.Text = $"Первая цифра числа {number}: {firstDigit}";

            // Задание 2

            //int number = Convert.ToInt32(TbNumberA.Text);
            //int thousandsDigit = (number / 1000) % 10;

            //TextBlockAnswer.Text = $"Цифра разряда тысяч числа {number}: {thousandsDigit}";

            // Задание 3

            //int k = Convert.ToInt32(TbNumberA.Text);
            //int dayOfWeek = ((k - 1) % 7 + 6) % 7 + 1; // 6 - это номер дня недели 1 января (суббота)

            //TextBlockAnswer.Text = $"День недели для {k}-го дня года: {dayOfWeek}";

        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task1Page());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task2Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task3Page());
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task4Page());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task5Page());
        }
    }
}
