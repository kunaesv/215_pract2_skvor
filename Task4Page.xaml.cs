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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 1 дополнительное

            int A = Convert.ToInt32(TbNumberA.Text);
            int B = Convert.ToInt32(TbNumberB.Text);
            int C = Convert.ToInt32(TbNumberC.Text);

            int count = (A / C) * (B / C);
            int area = A * B - count * C * C;

            TextBlockCount.Text = $"Количество квадратов: {count}";
            TextBlockArea.Text = $"Площадь незанятой части: {area}";

        }
    }
}
