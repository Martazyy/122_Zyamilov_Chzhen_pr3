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

namespace InterestCalculation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += Window_Closing;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount) &&
                int.TryParse(txtTerm.Text, out int term) &&
                double.TryParse(txtRate.Text, out double rate))
            {
                if (amount < 0 || term < 0 || rate < 0)
                {
                    MessageBox.Show("Все вводимые числа должны быть неотрицательными.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                double result = 0;

                if (rbSimple.IsChecked == true)
                {
                    result = amount * (1 + (rate / 100) * (term / 12.0));
                }
                else if (rbCompound.IsChecked == true)
                {
                    result = amount * Math.Pow(1 + (rate / (100 * 12)), term);
                }

                txtResult.Text = $"Итоговая сумма: {result:F2}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Уверены, что хотите выйти из приложения?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
