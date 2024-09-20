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

namespace AsyncButtons;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private async void Button_Click_1(object sender, RoutedEventArgs e)
    {
        //Thread.Sleep(5000);
        await Task.Run(() => Thread.Sleep(5000));
        lbl1.Content = "Button Click 1";
        //Thread.Sleep(5000);
        await Task.Run(() => Thread.Sleep(5000));
        lbl1.Content = "Lable";
    }

    private async void Button_Click_2(object sender, RoutedEventArgs e)
    {
        //Thread.Sleep(5000);
        await Task.Run(() => Thread.Sleep(5000));
        lbl2.Content = "Button Click 2";
        //Thread.Sleep(5000);
        await Task.Run(() => Thread.Sleep(5000));
        lbl2.Content = "Lable";
    }

    private async void Button_Click_3(object sender, RoutedEventArgs e)
    {
        //Thread.Sleep(5000);
        await Task.Run(() => Thread.Sleep(5000));
        lbl3.Content = "Button Click 3";
        //Thread.Sleep(5000);
        await Task.Run(() => Thread.Sleep(5000));
        lbl3.Content = "Lable";
    }
}