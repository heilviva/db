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

    /// Логика взаимодействия для SecondGrid.xaml
 
    public partial class SecondGrid : Page
    {
        ProjectsTableAdapter projects = new ProjectsTableAdapter();

        public SecondGrid()
        {
            InitializeComponent();
            ProjectsDataGrid.ItemsSource = projects.GetData();
        }
    }
}
