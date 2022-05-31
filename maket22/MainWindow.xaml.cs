using System;
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

namespace maket22
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Об аптеке");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Медицинские статьи");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Как нас найти");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            grid1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(238, 238, 238));
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush myVerticalGradient =
    new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Red, 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Orange, 0.20));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Yellow, 0.40));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.LimeGreen, 0.60));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.DeepSkyBlue, 0.80));
            myVerticalGradient.GradientStops.Add(
               new GradientStop(Colors.Purple, 1));
            grid1.Background = myVerticalGradient;
        }

        private void hover1(object sender, MouseEventArgs e)
        {
            Change.Text = "Каталог товаров";
        }

        private void hover2(object sender, MouseEventArgs e)
        {
            Change.Text = "Об аптеке";
        }

        private void hover3(object sender, MouseEventArgs e)
        {
            Change.Text = "Медицинские статьи";
        }

        private void hover4(object sender, MouseEventArgs e)
        {
            Change.Text = "Как нас найти";
        }

        private void hover5(object sender, MouseEventArgs e)
        {
            Change.Text = "Светлая тема";
        }

        private void hover6(object sender, MouseEventArgs e)
        {
            Change.Text = "Pride";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товары");
        }
    }
}
