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
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void clinic_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            DentistryPage dentistryPage = new DentistryPage();
            dentistryPage.Show();
        }

        private void booking_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Booking bookingPage = new Booking();
            bookingPage.Show();
        }

        private void history_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AppointmentHistory appointmentHistory = new AppointmentHistory();
            appointmentHistory.Show();
        }
    }
}
