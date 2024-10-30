using System.Data;
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
using Microsoft.Data.SqlClient;


namespace ADONETWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = @"Data Source=DESKTOP-S9KHPNV\WARDONEZERO;
                                        Initial Catalog=TSQLV4;
                                        Integrated Security=True;
                                        Connect Timeout=30;
                                        Encrypt=True;
                                        Trust Server Certificate=True;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False";
            string sql = "SELECT empid, lastname, firstname, hiredate , country FROM HR.Employees WHERE empid > 2";
            using SqlConnection connection = new(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new(sql, connection);
            DataSet ds = new();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGrid1.ItemsSource = dt.DefaultView;
        }
    }
}