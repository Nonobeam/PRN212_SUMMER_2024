﻿using Data.Entities;
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
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        private static User customer;
        private BookingService bookingService;

        public Booking()
        {
        }

        public Booking(User _customer)
        {
            customer = _customer;
            InitializeComponent();
            clinic.ItemsSource = ClinicList();
            clinic.DisplayMemberPath = "Name";
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var datePicker = sender as DatePicker;
            if (datePicker != null)
            {
                if(date.SelectedDate != null && date.SelectedDate >= DateTime.Now)
                {
                    if (clinic.SelectedValue != null)
                    {
                        timeslot.ItemsSource = TimeSlotOptions(date.SelectedDate, (Clinic)clinic.SelectedItem);
                        timeslot.DisplayMemberPath = "Time";
                    }
                }                    else MessageBox.Show("You have to select future or present date");

                
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
            if(timeslot.SelectedValue != null && clinic.SelectedValue != null && date.SelectedDate != null)
            {
                servicelist.ItemsSource = GetServiceForBooking();
                servicelist.DisplayMemberPath = "Name";
            }
        }

        private IEnumerable<Data.Entities.Service> GetServiceForBooking()
        {
            bookingService = BookingService.GetInstance();
            return bookingService.GetServiceForBooking();
        }


    private IEnumerable<Dentist> GetDentistList(TimeSlot? timeSlotSelection, Clinic? clinicSelect, DateTime? selectedDate)
        {
            bookingService = BookingService.GetInstance();
            return bookingService.GetDentistListForBooking(timeSlotSelection, clinicSelect, selectedDate);
        }

        private void Servicelist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (timeslot.SelectedValue != null && clinic.SelectedValue != null && date.SelectedDate != null && servicelist.SelectedValue !=null)
            {
                var clinicSeletion = clinic.SelectedItem as Clinic;
                var timeSlotSelection = timeslot.SelectedItem as TimeSlot;
                dentistlist.ItemsSource = GetDentistList(timeSlotSelection, clinicSeletion, date.SelectedDate);
                dentistlist.DisplayMemberPath = "User.Name";
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
                var dentistSelection = dentistlist.SelectedItem as Dentist;
                
                Appointment appointment = new Appointment();
                appointment.ServiceId = serviceSelection.Id;
                appointment.DentistId = dentistSelection.UserId;
                appointment.ClinicId = clinicSeletion.Id;
                appointment.CustomerId = customer.Id;
                appointment.TimeSlotId = timeSlotSelection.Id;
                appointment.Date =  date.SelectedDate;
                bookingService.MakeAppointment(appointment);
               
                MessageBox.Show("Booking successfully");
                

            } else
            {
                MessageBox.Show("You should input all field");
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CustomerPage customerPage = new CustomerPage(customer);
            customerPage.Show();
            this.Close();

        }
    }
}
