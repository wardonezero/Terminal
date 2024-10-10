using MyDataStructure;
using QueueProject;
using System.Reflection.Emit;
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
namespace VisualQueueWPF;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly Random random = new();
    private readonly MyQueue<int> _list = new();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void DoEnqueue(object sender, RoutedEventArgs e)
    {
        _list.Enqueue(random.Next(0, 256));
        if (_list.Count < 7)
            UpdateGrid();
    }

    private void DoDequeue(object sender, RoutedEventArgs e)
    {
        if (_list.Count > 0)
        {
            listbox.Items.Add(_list.Dequeue().ToString());
            UpdateGrid();
        }
    }

    private void UpdateGrid()
    {
        System.Windows.Controls.Label[] labels = [label0, label1, label2, label3, label4, label5];
        MyLinkedListNode<int>? current = _list.GetHead();
        for (int i = 0; i < 6; i++)
        {
            if (current != null && _list.Count > 0)
            {
                labels[i].Content = current.Value;
                current = current.Next;
            }
            else
                labels[i].Content = ' ';
        }

    }
}