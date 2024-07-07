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
    /// Interaction logic for DentistryPage.xaml
    /// </summary>
    public partial class DentistryPage : Window
    {
        private static User customer;
        private ClinicService clinicService;
        private BookingService userService;

        public DentistryPage()
        {
        }

        public DentistryPage(User _customer)
        {
            customer = _customer;
            InitializeComponent();
            clinicList.ItemsSource = GetAllClinic();
            serviceList.ItemsSource = GetAllService();
        }

        private IEnumerable<Data.Entities.Service> GetAllService()
        {
            userService = BookingService.GetInstance();
            return userService.GetServiceForBooking();
        }

        private IEnumerable<Clinic> GetAllClinic()
        {
            clinicService = ClinicService.GetInstance();
            return clinicService.GetAllClinics();
        }
    }
}
