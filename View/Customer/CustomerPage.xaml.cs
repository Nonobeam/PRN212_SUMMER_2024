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

namespace View.Customer
{
    /// <summary>
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Window
    {
        private static Data.Entities.Customer customer;
        public CustomerPage(Data.Entities.Customer _customer)
        {
            customer = _customer;
            InitializeComponent();
        }

        private void clinic_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            DentistryPage dentistryPage = new DentistryPage(customer);
            dentistryPage.Show();
        }

        private void booking_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Booking bookingPage = new Booking(customer);
            bookingPage.Show();
        }

        private void history_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AppointmentHistory appointmentHistory = new AppointmentHistory(customer);
            appointmentHistory.Show();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
