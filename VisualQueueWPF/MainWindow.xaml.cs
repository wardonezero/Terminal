using MyDataStructure;
using QueueProject;
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

namespace VisualQueueWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        MyQueue<int> _list = new MyQueue<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoEnqueue(object sender, RoutedEventArgs e)
        {
            _list.Enqueue(random.Next(0, 256));
            UpdateGrid();
        }

        private void DoDequeue(object sender, RoutedEventArgs e)
        {
            if (_list.Count > 0)
            {
                listbox.Items.Add(_list.Dequeue().ToString());
            }
        }

        private void UpdateGrid()
        {
            MyLinkedListNode<int> current = _list.Peek();
            lable0.Content = _list.Peek();
        }
    }
}