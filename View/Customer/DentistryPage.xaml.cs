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

namespace View.Customer
{
    /// <summary>
    /// Interaction logic for DentistryPage.xaml
    /// </summary>
    public partial class DentistryPage : Window
    {
        private static Data.Entities.Customer customer;

        public DentistryPage(Data.Entities.Customer _customer)
        {
            customer = _customer;
            InitializeComponent();
        }
    }
}