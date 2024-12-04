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

namespace Calc_Good
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
        private void CheckTriangleType(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(SideA.Text, out int a) && int.TryParse(SideB.Text, out int b) && int.TryParse(SideC.Text, out int c))
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    MessageBox.Show("Длины сторон должны быть положительными числами.");
                    return;
                }

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    MessageBox.Show("Треугольник с такими сторонами не существует.");
                    return;
                }

                if (a == b && b == c)
                {
                    MessageBox.Show("Треугольник равносторонний.");
                }
                else if (a == b || b == c || a == c)
                {
                    MessageBox.Show("Треугольник равнобедренный.");
                }
                else
                {
                    MessageBox.Show("Треугольник разносторонний.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные целые числа для всех сторон.");
            }
        }
    }
}