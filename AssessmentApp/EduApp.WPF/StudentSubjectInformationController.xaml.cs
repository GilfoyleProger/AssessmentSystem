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

namespace EduApp.WPF
{
    /// <summary>
    /// Interaction logic for StudentSubjectInformationController.xaml
    /// </summary>
    public partial class StudentSubjectInformationController : UserControl
    {
        public StudentSubjectInformationController()
        {
            InitializeComponent();
        }

        private void subjectMouseClick(object sender, MouseButtonEventArgs e)
        {
            SubjectMainWindow subjectMainWindow = new SubjectMainWindow();
            subjectMainWindow.Show();
        }
    }
}
