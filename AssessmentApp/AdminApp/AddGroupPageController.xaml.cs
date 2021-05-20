using AssessmentApp.BL.Controller;
using AssessmentApp.BL.Model;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace AdminApp
{
    /// <summary>
    /// Interaction logic for AddGroupPageController.xaml
    /// </summary>
    /// 
    public class MajorTable 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public partial class AddGroupPageController : UserControl
    {
        public AddGroupPageController()
        {
            InitializeComponent();
            ObservableCollection<MajorTable> majors = new ObservableCollection<MajorTable>();
            var majorController = new MajorController();
            var majorsList = majorController.GetMajors();
            foreach (Major m in majorsList)
            {
                majors.Add(new MajorTable { Id = m.Id, Name = m.Name });
            }
            GroupDataGrid.ItemsSource = majors;
          /*  for (int i = 0; i < GroupDataGrid.Items.Count; i++)
            {
                (DataGridRow)GroupDataGrid.Items.IndexOf(0)).Tag.ToString() = "ReadOnly";
                (DataGridRow)GroupDataGrid.Items.
                GroupDataGrid.Columns[i].IsReadOnly = true;
                //GroupDataGrid.
            }*/
           // Point relativePoint = myVisual.TransformToAncestor(rootVisual)
           //                   .Transform(new Point(0, 0));
        }

        private void ButtonFecr_Click(object sender, RoutedEventArgs e)
        {
            var majorController = new MajorController();
           // majorController.Add("poz");
            var majorsList = majorController.GetMajors();
          //  int k = 0;
            //groupController.
        }

        private void GroupDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
