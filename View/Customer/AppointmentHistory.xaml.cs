using Data.Entities;
using Service;
using System;
using System.Collections;
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
    /// Interaction logic for AppointmentHistory.xaml
    /// </summary>
    public partial class AppointmentHistory : Window
    {
        private static Data.Entities.Customer customer;
        private BookingService bookingService;

        public AppointmentHistory(Data.Entities.Customer _customer)
        {
            customer = _customer;
            InitializeComponent();
            lvi.ItemsSource = GetAppointmentHistory(customer);
        }

        private IEnumerable<Appointment> GetAppointmentHistory(Data.Entities.Customer customer)
        {
            bookingService = BookingService.GetInstance();
            return bookingService.GetAppointmentHistory(customer);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            bookingService = BookingService.GetInstance();

            if (search != null || searchDate != null)
            {
                lvi.ItemsSource = bookingService.GetAppointmentHistorySearch(customer,search.Text,searchDate.SelectedDate);
            }
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            bookingService = BookingService.GetInstance();

            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this ?", "Delete Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Button button = sender as Button;
                if (button != null)
                {
                    var appointment = button.CommandParameter as Appointment;
                    if (appointment != null)
                    {
                        bookingService.DeleteAppointment(appointment.Id);
                    }
                }
            } 
            lvi.ItemsSource = GetAppointmentHistory(customer);
        }
    }
}
