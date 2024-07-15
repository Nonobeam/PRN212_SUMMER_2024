using Data.Entities;
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
using System.Windows.Shapes;
using View.Component;

namespace View.CLinicOwner
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        private static User manager;
        public ManagerWindow()
        {
        }

        public ManagerWindow(User user)
        {
            manager = user;
            InitializeComponent();
        }

        private void Clinic_Click(object sender, RoutedEventArgs e)
        {
            ClinicRegister clinicRegister = new ClinicRegister(manager);
            clinicRegister.Show();
            this.Close();
        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            AppoinmentManagement appoinmentManagement = new AppoinmentManagement(manager);
            appoinmentManagement.Show();
            this.Close();
        }

        private void Dentist_Click(object sender, RoutedEventArgs e)
        {
            DentistManagement dentistManagement = new DentistManagement(manager);
            dentistManagement.Show();
            this.Close();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement(manager);
            customerManagement.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
