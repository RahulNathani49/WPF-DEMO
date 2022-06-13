using PassportWPF.Models;
using PassportWPF.ViewModels;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Data.SqlClient;


namespace PassportWPF.Views
{
    /// <summary>
    /// Interaction logic for PassportsView.xaml
    /// </summary>
    public partial class PassportsView : UserControl
    {
        public PassportsView()
        {
            InitializeComponent();
            DataContext = new PassportsViewModel();
        }

        private void Add_click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=751FJW2\SQLEXPRESS;Initial Catalog=passportDatabase;Integrated Security=True;Pooling=False");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into passports(firstname) values('" + firstname.Text + "')", connection);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("data saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
