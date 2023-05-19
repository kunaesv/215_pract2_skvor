using System;
using System.Collections.Generic;
using System.Text;
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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            //Задание 3
            
            int k = Convert.ToInt32(TbNumberA.Text);
            int dayOfWeek = ((k - 1) % 7 + 6) % 7 + 1; // 6 - это номер дня недели 1 января (суббота)

            TextBlockAnswer.Text = $"День недели для {k}-го дня года: {dayOfWeek}";
        }
    }
}
