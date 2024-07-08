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

namespace View.Customer
{
    /// <summary>
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Window
    {
        private static User customer;

        public CustomerPage()
        {
        }

        public CustomerPage(User _customer)
        {
            customer = _customer;
            InitializeComponent();
        }

        private void Clinic_Click(object sender, RoutedEventArgs e)
        {
            DentistryPage dentistryPage = new DentistryPage(customer);
            dentistryPage.Show();
            this.Close();

        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            Booking bookingPage = new Booking(customer);
            bookingPage.Show();
            this.Close();

        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            AppointmentHistory appointmentHistory = new AppointmentHistory(customer);
            appointmentHistory.Show();
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