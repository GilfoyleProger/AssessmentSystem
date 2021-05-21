﻿using System;
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
using System.Windows.Shapes;

namespace EduApp.WPF
{
    /// <summary>
    /// Interaction logic for SubjectMainWindow.xaml
    /// </summary>
    public partial class SubjectMainWindow : Window
    {
        public SubjectMainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new SubjectMainPageController());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new SubjectCurriculumController());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new SubjectsMarksController());
                    break;
                case 3:
                    Close();
                    break;
                case 4:
                    System.Diagnostics.Process.Start("https://github.com/GilfoyleProger/AssessmentSystem");
                    break;

                default:
                    break;
            }
        }
    }
}
