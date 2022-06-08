using PassportWPF.Models;
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

namespace PassportWPF.Views
{
    /// <summary>
    /// Interaction logic for PassportsView.xaml
    /// </summary>
    public partial class PassportsView : UserControl
    {
        private readonly ObservableCollection<Passport> passports;
        public PassportsView()
        {
            InitializeComponent();
            passports = new ObservableCollection<Passport>();
 
            passports.Add(new Passport("Rahul","Nathani",new DateTime(2002, 06, 21),"Canada"));
            passports.Add(new Passport("Het", "Patel", new DateTime(2001, 04, 11), "India"));

            PassportData.ItemsSource = passports;
        }
    }
}
