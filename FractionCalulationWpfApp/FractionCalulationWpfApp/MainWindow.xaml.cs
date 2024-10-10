using FractionCalculator;
using System.Windows;
using System.Windows.Controls;
namespace FractionCalulationWpfApp;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        num1.Text = "";
        den1.Text = "";
        num2.Text = "";
        den2.Text = "";
    }

    private void btnCalculate_Click(object sender, RoutedEventArgs e)
    {
        bool isNum1 = int.TryParse(num1.Text, out int intNum1) && intNum1 != 0;
        bool isDen1 = int.TryParse(den1.Text, out int intDen1) && intDen1 != 0;
        bool isNum2 = int.TryParse(num2.Text, out int intNum2) && intNum2 != 0;
        bool isDen2 = int.TryParse(den2.Text, out int intDen2) && intDen2 != 0;
        var selectedOperation = op.SelectedItem as ComboBoxItem;
        string? operation = selectedOperation?.Content.ToString();
        if (isNum1 && isDen1 && isNum2 && isDen2)
        {
            if (operation != null)
            {
                Fraction fraction1 = new(intNum1, intDen1);
                Fraction fraction2 = new(intNum2, intDen2);
                Fraction fraction3 = new(1, 1);
                switch (operation)
                {
                    case "+":
                        Answer.Content = (fraction1 + fraction2).ToString();
                        break;
                    case "-":
                        Answer.Content = (fraction1 - fraction2).ToString();
                        break;
                    case "*":
                        Answer.Content = (fraction1 * fraction2).ToString();
                        break;
                    case "/":
                        Answer.Content = (fraction1 / fraction2).ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers.");
            }
        }
    }
}