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

namespace lab3
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

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fraction fr = new Fraction(int.Parse(whol.Text), int.Parse(numerator1.Text), int.Parse(den1.Text));
                Fraction fr2 = new Fraction(int.Parse(whol2.Text), int.Parse(numerator2.Text), int.Parse(den2.Text));
                Fraction res = fr + fr2;
                wholefull.Text = res.ToString();
            }
            catch {
                MessageBox.Show("Вводите числа");
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fraction fr = new Fraction(int.Parse(whol.Text), int.Parse(numerator1.Text), int.Parse(den1.Text));
                Fraction fr2 = new Fraction(int.Parse(whol2.Text), int.Parse(numerator2.Text), int.Parse(den2.Text));
                Fraction res = fr - fr2;
                wholefull.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show("Вводите числа");
            }

        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            try { 
            Fraction fr = new Fraction(int.Parse(whol.Text), int.Parse(numerator1.Text), int.Parse(den1.Text));
            Fraction fr2 = new Fraction(int.Parse(whol2.Text), int.Parse(numerator2.Text), int.Parse(den2.Text));
            Fraction res = fr * fr2;
            wholefull.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show("Вводите числа");
            }
        }

        private void comp_Click(object sender, RoutedEventArgs e)
        {
            try {
            Fraction fr = new Fraction(int.Parse(whol.Text), int.Parse(numerator1.Text), int.Parse(den1.Text));
            Fraction fr2 = new Fraction(int.Parse(whol2.Text), int.Parse(numerator2.Text), int.Parse(den2.Text));
            bool v = fr == fr2;
            wholefull.Text = v.ToString();
            }
             catch
                 {
                MessageBox.Show("Вводите числа");
                 }
}   
    }
}
