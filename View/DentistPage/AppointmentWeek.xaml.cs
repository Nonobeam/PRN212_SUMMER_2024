using Data;
using Data.Entities;
using Service;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using View.Component;
using View.Customer;

namespace View.DentistPage
{
    public partial class AppointmentWeek : Window, INotifyPropertyChanged
    {
        public DateTime MondayDate { get; set; }
        public DateTime TuesdayDate { get; set; }
        public DateTime WednesdayDate { get; set; }
        public DateTime ThursdayDate { get; set; }
        public DateTime FridayDate { get; set; }
        public DateTime SaturdayDate { get; set; }
        public DateTime SundayDate { get; set; }

        public ObservableCollection<Appointment> MondayAppointments { get; set; }
        public ObservableCollection<Appointment> TuesdayAppointments { get; set; }
        public ObservableCollection<Appointment> WednesdayAppointments { get; set; }
        public ObservableCollection<Appointment> ThursdayAppointments { get; set; }
        public ObservableCollection<Appointment> FridayAppointments { get; set; }
        public ObservableCollection<Appointment> SaturdayAppointments { get; set; }
        public ObservableCollection<Appointment> SundayAppointments { get; set; }

        public UserService userService;
        private readonly User currentDentist;

        public event PropertyChangedEventHandler PropertyChanged;

        public AppointmentWeek()
        {
            InitializeComponent();
        }

        public AppointmentWeek(User dentist)
        {
            InitializeComponent();
            currentDentist = dentist;
            DataContext = this;

            MondayAppointments = new ObservableCollection<Appointment>();
            TuesdayAppointments = new ObservableCollection<Appointment>();
            WednesdayAppointments = new ObservableCollection<Appointment>();
            ThursdayAppointments = new ObservableCollection<Appointment>();
            FridayAppointments = new ObservableCollection<Appointment>();
            SaturdayAppointments = new ObservableCollection<Appointment>();
            SundayAppointments = new ObservableCollection<Appointment>();

            DateTime startOfWeek = getStartOfWeek();

            MondayDate = startOfWeek;
            TuesdayDate = MondayDate.AddDays(1);
            WednesdayDate = MondayDate.AddDays(2);
            ThursdayDate = MondayDate.AddDays(3);
            FridayDate = MondayDate.AddDays(4);
            SaturdayDate = MondayDate.AddDays(5);
            SundayDate = MondayDate.AddDays(6);

            LoadAppointments(dentist);
        }

        private DateTime getStartOfWeek()
        {
            DateTime today = DateTime.Today;
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime monday = today.AddDays(daysUntilMonday - 7);

            return monday;
        }

        private DateTime getStartOfWeek(DateTime date)
        {
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)date.DayOfWeek + 7) % 7;
            DateTime monday = date.AddDays(-((int)date.DayOfWeek - (int)DayOfWeek.Monday));

            return monday;
        }

        private void LoadAppointments(User dentist)
        {
            int dentistId = dentist.Id;

            using (var context = new PrnProjectContext())
            {
                var appointments = context.Appointments
                                          .Where(a => a.DentistId == dentistId && a.Date >= MondayDate && a.Date <= SundayDate)
                                          .ToList();

                DateTime monday = getStartOfWeek();

                foreach (var appointment in appointments)
                {
                    context.Entry(appointment).Reference(a => a.TimeSlot).Load();
                    context.Entry(appointment).Reference(a => a.Customer).Load();
                    context.Entry(appointment).Reference(a => a.Service).Load();
                    context.Entry(appointment.Customer).Reference(c => c.User).Load();

                    if (appointment.Date.Equals(monday))
                    {
                        MondayAppointments.Add(appointment);
                    }
                    else if (appointment.Date.Equals(monday.AddDays(1)))
                    {
                        TuesdayAppointments.Add(appointment);
                    }
                    else if (appointment.Date.Equals(monday.AddDays(2)))
                    {
                        WednesdayAppointments.Add(appointment);
                    }
                    else if (appointment.Date.Equals(monday.AddDays(3)))
                    {
                        ThursdayAppointments.Add(appointment);
                    }
                    else if (appointment.Date.Equals(monday.AddDays(4)))
                    {
                        FridayAppointments.Add(appointment);
                    }
                    else if (appointment.Date.Equals(monday.AddDays(5)))
                    {
                        SaturdayAppointments.Add(appointment);
                    }
                    else if (appointment.Date.Equals(monday.AddDays(6)))
                    {
                        SundayAppointments.Add(appointment);
                    }
                }

                if (appointments.Count == 0)
                {
                    userService = new UserService();
                    MessageBox.Show("You don't have any appointment for this week right now Dr. " + userService.GetUserById(dentistId).Name);
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            DentistAppointmentHistory appointmentHistory = new DentistAppointmentHistory(currentDentist);
            appointmentHistory.Show();
            this.Close();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = (DateTime)((DatePicker)sender).SelectedDate;
            DateTime startOfWeek = getStartOfWeek(selectedDate);

            MondayDate = startOfWeek;
            TuesdayDate = MondayDate.AddDays(1);
            WednesdayDate = MondayDate.AddDays(2);
            ThursdayDate = MondayDate.AddDays(3);
            FridayDate = MondayDate.AddDays(4);
            SaturdayDate = MondayDate.AddDays(5);
            SundayDate = MondayDate.AddDays(6);

            ClearAppointments();
            LoadAppointments(currentDentist);
            OnPropertyChanged(nameof(MondayDate));
            OnPropertyChanged(nameof(TuesdayDate));
            OnPropertyChanged(nameof(WednesdayDate));
            OnPropertyChanged(nameof(ThursdayDate));
            OnPropertyChanged(nameof(FridayDate));
            OnPropertyChanged(nameof(SaturdayDate));
            OnPropertyChanged(nameof(SundayDate));
        }

        private void ClearAppointments()
        {
            MondayAppointments.Clear();
            TuesdayAppointments.Clear();
            WednesdayAppointments.Clear();
            ThursdayAppointments.Clear();
            FridayAppointments.Clear();
            SaturdayAppointments.Clear();
            SundayAppointments.Clear();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
