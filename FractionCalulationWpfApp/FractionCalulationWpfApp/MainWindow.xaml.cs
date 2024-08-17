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
        num1.Text = "0";
        den1.Text = "0";
        num2.Text = "0";
        den2.Text = "0";
    }

    private void btnCalculate_Click(object sender, RoutedEventArgs e)
    {
        bool isNum1 = int.TryParse(num1.Text, out int intNum1);
        bool isDen1 = int.TryParse(den1.Text, out int intDen1);
        bool isNum2 = int.TryParse(num2.Text, out int intNum2);
        bool isDen2 = int.TryParse(den2.Text, out int intDen2);
        var selectedOperation = op.SelectedItem as ComboBoxItem;
        string? operation = selectedOperation?.Content.ToString();
        if (isNum1 && isDen1 && isNum2 && isDen2)
        {
            if (operation != null)
            {
                Fraction fraction1 = new Fraction(intNum1, intDen1);
                Fraction fraction2 = new Fraction(intNum2, intDen2);
                Fraction fraction3 = new Fraction(1, 1);
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
            //Fraction fraction1 = new Fraction();
        }
    }
}