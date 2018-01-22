using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace MasterDetailSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var Persons = new ObservableCollection<Person> {
                    new Person { Name = "Adam", Age = 10, IsValid = true},
                    new Person {Name = "Eve", Age = 45, IsValid = false } };
            DataContext = new MainViewModel
            {
                Persons = Persons,
                SelectedPerson = Persons.First()
            };
        }
    }
}
