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
using DataAccess.Models;

namespace WpfPostCompany
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public Customer customer;
        public ReportWindow(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            PostCompanyEntities dbContext = new PostCompanyEntities();
            report_dtgrid.ItemsSource = dbContext.Orders.Where(o => o.CustomerSSN == customer.SSN).ToList();
        }
    }
}