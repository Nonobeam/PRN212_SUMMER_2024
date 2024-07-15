using Data.Entities;
using Data.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using Service;
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
using System.Xml.Linq;
using View.Customer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View.CLinicOwner
{
    /// <summary>
    /// Interaction logic for AppoinmentManagement.xaml
    /// </summary>
    public partial class AppoinmentManagement : System.Windows.Window
    {
        private AppointmentService appointmentService;
        private UserService userService;
        private DentistService dentistService;
        private ServiceService serviceService;
        private ClinicService clinicService;
        private static Data.Entities.User manager;

        public AppoinmentManagement()
        {
            

        }

        public AppoinmentManagement(Data.Entities.User i)
        {
            manager = i;
            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.userService = new UserService();
            this.serviceService = new ServiceService();
            this.clinicService = new ClinicService();
            listAppoinment();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string id = txtId.Text;
            string date = txtDate.Text;
            int slot = int.Parse(txtTime.Text);
            string customerId = txtCustomer.Text;
            string serviceId = txtService.Text;
            string dentistId = txtDentist.Text;
            string status = cbStatus.Text;
            string clinicId = txtClinicId.Text;
            int available = 0;
            if (status == "Active")
            {
                available = 1;
            }
            Appointment appointment = new Appointment();
            appointment.Available = available;
            appointment.DentistId = int.Parse(dentistId);
            appointment.Date = DateTime.Parse(date);
            appointment.TimeSlotId = slot;
            appointment.ClinicId = int.Parse(clinicId);
            appointment.CustomerId = int.Parse(customerId);
            appointment.ServiceId = int.Parse(serviceId);
            try
            {
                if (id != "")
                {
                    appointment.Id = int.Parse(id);

                }
                appointmentService.AddAppoinment(appointment);
                txtId.Text = "";
                txtDate.Text = "";
                txtTime.Text = "";
                txtCustomer.Text = "";
                txtService.Text = "";
                txtDentist.Text = "";
                txtClinicId.Text = "";
                tbAppoinment.ItemsSource = null;
                listAppoinment();
            }
            catch (Exception ex)
            {
                txtError.Text = "Cannot add new Appoinment!";
            }

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
            int id = (int)btn.Tag;
            Appointment appointment = appointmentService.GetAppointment(id);
            txtId.Text = appointment.Id + "";
            txtDate.Text = appointment.Date + "";
            txtTime.Text = appointment.TimeSlotId + "";
            txtCustomer.Text = appointment.CustomerId + "";
            txtService.Text = appointment.ServiceId + "";
            txtDentist.Text = appointment.DentistId + "";
            txtClinicId.Text = appointment.ClinicId + "";
            cbStatus.SelectedIndex = appointment.Available;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtDate.Text = "";
            txtTime.Text = "";
            txtCustomer.Text =  "";
            txtService.Text = "";
            txtDentist.Text = "";
            txtClinicId.Text = "";
        }

        private void listAppoinment()
        {
            List<Appointment> list = appointmentService.GetAllAppointmentsByManager(manager.Id).ToList();
            List<AppoinmentDto> listDto = new List<AppoinmentDto>();
            cbStatus.ItemsSource = new List<string> { "Active", "Inactive" };
            foreach (Appointment appointment in list)
            {
                AppoinmentDto dto = new AppoinmentDto();
                dto.Id = appointment.Id;
                dto.Date = appointment.Date;
                dto.TimeSlotId = appointment.TimeSlotId;
                dto.Status = appointment.Status;
                dto.CustomerName = userService.GetUserById(appointment.CustomerId).Name;
                dto.ServiceName = serviceService.getServiceById(appointment.ServiceId).Name;
                dto.ClinicName = clinicService.GetClinicById(appointment.ClinicId).Name;
                dto.DentistName = userService.GetUserById(appointment.DentistId).Name;
                listDto.Add(dto);
            }
            tbAppoinment.ItemsSource = listDto;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow customerPage = new ManagerWindow(manager);
            customerPage.Show();
            this.Close();
        }
    }
}
