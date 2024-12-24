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
using Lib_1;

namespace Practical15
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Generator_Click1(object sender, RoutedEventArgs e)
        {
            // Проверка введенного значения
            if (!int.TryParse(InputTextBox.Text, out int k) || k <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное положительное целое число для K.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            GenerationNumbers.GeneratorRandomSum(k, out string count, out int sum);
            ResultatTextBox.Text = $"Сгенерированные числа: {count}\nСумма: {sum}";
        }
    }
}