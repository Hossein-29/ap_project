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

namespace WpfPostCompany
{
    /// <summary>
    /// Interaction logic for EmployeePanel.xaml
    /// </summary>
    public partial class EmployeePanel : Window
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void OrderRegistrationBtn(object sender, RoutedEventArgs e)
        {

        }

        private void SendDeliveryEmail(object sender, RoutedEventArgs e)
        {

        }

        private void RegisterCostumerBtn(object sender, RoutedEventArgs e)
        {
            var RegisterCostumer = new RegisterCostumerWindow();
            RegisterCostumer.Show();
            this.Close();
        }

        private void DisplayPackageInfoBtn(object sender, RoutedEventArgs e)
        {

        }

        private void ViewCostumerCommentsBtn(object sender, RoutedEventArgs e)
        {

        }

        private void ReportingOfOrdersBtn(object sender, RoutedEventArgs e)
        {

        }
    }
}