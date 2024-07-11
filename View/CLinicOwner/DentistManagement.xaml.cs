using Data.Entities;
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

namespace View.CLinicOwner
{
    /// <summary>
    /// Interaction logic for DentistManagement.xaml
    /// </summary>
    public partial class DentistManagement : Window
    {
        private DentistService dentistService;
        private UserService userService;
        private ClinicService clinicService;
        public DentistManagement()
        {
            InitializeComponent();
            dentistService = new DentistService();
            List<Dentist> list = dentistService.GetAllDentists().ToList();
            userService = new UserService();
            clinicService = new ClinicService();
            List<DentistDto> listDto = new List<DentistDto>();
            foreach (Dentist dentist in list){
                DentistDto dto = new DentistDto();
                User user = userService.GetUserById(dentist.UserId);
                dto.Id = user.Id;
                dto.Phone = user.Phone;
                dto.Status = user.Status;
                dto.Email = user.Email;
                dto.Name = user.Name;
                dto.Password = user.Password;
                Clinic clinic = clinicService.GetClinicById(dentist.ClinicId);
                dto.ClicnicName = clinic.Name;
                listDto.Add(dto);
            }
            tbDentist.ItemsSource = listDto;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DentistRegister register = new DentistRegister();
            register.Show();
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int id = (int)button.Tag;
            DentistRegister register = new DentistRegister(id);
            register.Show();
            this.Close();
        }
    }
}
