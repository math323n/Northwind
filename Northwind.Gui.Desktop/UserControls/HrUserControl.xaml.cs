using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Northwind.DataAccess;

namespace Northwind.Gui.Desktop.UserControls
{
    /// <summary>
    /// Interaction logic for HrUserControl.xaml
    /// </summary>
    public partial class HrUserControl : UserControl
    {
        public HrUserControl()
        {
            InitializeComponent();
            try
            {
                Repository repository = new Repository();
                List<Employee> employees = repository.GetAllEmployees();
                DataContext = employees;
                dataGridEmployees.ItemsSource = employees;
            }
            catch(Exception)
            {
                MessageBox.Show($"Data kunne desværre ikke hentes. Kontakt en IT medarbejder.", "Fejl", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void ButtonContactinformation_Click(object sender, RoutedEventArgs e)
        {
            (bool isValid, string errorMessage) = ContactInformation.ValidateMail("mara@aspit.dk");

        }
    }
}