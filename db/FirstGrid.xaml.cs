using db.ITCompanyDataSetTableAdapters;
using System;
using System.Collections.Generic;
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
using db.ITCompanyDataSetTableAdapters;

namespace db
{
    /// Логика взаимодействия для FirstGrid.xaml
    public partial class FirstGrid : Page
    {
        EmployeesTableAdapter employees = new EmployeesTableAdapter();

        public FirstGrid()
        {
            InitializeComponent();
            EmployeesDataGrid.ItemsSource = employees.GetData();
        }
    }
}