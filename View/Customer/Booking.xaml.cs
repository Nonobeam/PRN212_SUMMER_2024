using Data.Entities;
using Service;
using System.Windows;
using System.Windows.Controls;

using Dentist = Data.Entities.Dentist;

namespace View.Customer
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        private static Data.Entities.Customer customer;
        private BookingService bookingService;
        public Booking(Data.Entities.Customer _customer)
        {
            customer = _customer;
            InitializeComponent();
            clinic.ItemsSource = ClinicList();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var datePicker = sender as DatePicker;
            if (datePicker != null)
            {
                if (datePicker.SelectedDate != null && clinic.SelectedValue!=null)
                {
                    timeslot.ItemsSource = TimeSlotOptions(datePicker.SelectedDate, (Clinic)clinic.SelectedItem);
                }
            }
        }
        private IEnumerable<TimeSlot?> TimeSlotOptions(DateTime? selectedDate, Clinic clinic)
        {
            bookingService = BookingService.GetInstance();
            return bookingService.GetTimeSlotForBooking(selectedDate, clinic);
        }
        private IEnumerable<Clinic> ClinicList()
        {
            bookingService = BookingService.GetInstance();
            return bookingService.GetAllClinic();
        }

        private void Timeslot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var timeSlotSelection = sender as TimeSlot;
            if(timeSlotSelection != null && clinic.SelectedValue != null && date.SelectedDate != null)
            {
                servicelist.ItemsSource = GetServiceForBooking();
            }
        }

        private IEnumerable<Data.Entities.Service> GetServiceForBooking()
        {
            bookingService = BookingService.GetInstance();
            return bookingService.GetServiceForBooking();
        }


    private IEnumerable<Data.Entities.Dentist> GetDentistList(TimeSlot? timeSlotSelection, Clinic? clinicSelect, DateTime? selectedDate)
        {
            bookingService = BookingService.GetInstance();
            return bookingService.GetDentistListForBooking(timeSlotSelection, clinicSelect, selectedDate);
        }

        private void servicelist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var services = sender as Data.Entities.Service;
            if (timeslot.SelectedValue != null && clinic.SelectedValue != null && date.SelectedDate != null && services !=null)
            {
                var clinicSeletion = clinic.SelectedItem as Clinic;
                var timeSlotSelection = timeslot.SelectedItem as TimeSlot;
                dentistlist.ItemsSource = GetDentistList(timeSlotSelection, clinicSeletion, date.SelectedDate);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bookingService = BookingService.GetInstance();

            if (timeslot.SelectedValue != null && clinic.SelectedValue != null && date.SelectedDate != null && servicelist != null && dentistlist != null)
            {

                var clinicSeletion = clinic.SelectedItem as Clinic;
                var timeSlotSelection = timeslot.SelectedItem as TimeSlot;
                var serviceSelection = servicelist.SelectedItem as Data.Entities.Service;
                var dentistSelection = dentistlist.SelectedItem as Data.Entities.Dentist;
                Appointment appointment = new Appointment();
                appointment.ServiceId = serviceSelection.Id;
                appointment.DentistId = dentistSelection.UserId;
                appointment.ClinicId = clinicSeletion.Id;
                appointment.CustomerId = customer.UserId;
                appointment.TimeSlotId = timeSlotSelection.Id;
                bookingService.MakeAppointment(appointment);
                this.Close();
                MessageBox.Show("Booking successfully");
            } else
            {
                MessageBox.Show("You should input all field");
            }

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CustomerPage customerPage = new CustomerPage(customer);
            customerPage.Show();
        }
    }
}
