using Data.Entities;
using Service;
using System.IO;
using System.Windows;
using View.Admin;
using View.Customer;

namespace View.Component
{
    public partial class Login : Window
    {
        private static User user;
        private UserService userService;

        public Login()
        {
            InitializeComponent();
            userService = new UserService();
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredEmail = email.Text;
            string enteredPassword = password.Password;

            var user = userService.Login(enteredEmail, enteredPassword);

            if (user != null)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                switch (user.UserType)
                {
                    case "Admin":
                        ManageAccount adminWindow = new ManageAccount();
                        adminWindow.Show();
                        break;
                   case "Customer":
                        CustomerPage customerWindow = new CustomerPage(user);
                        customerWindow.Show();
                        break;
/*                    case "Dentist":
                        DentistWindow dentistWindow = new DentistWindow();
                        dentistWindow.Show();
                        break;
                    case "Manager":
                        ManagerWindow managerWindow = new ManagerWindow();
                        managerWindow.Show();
                        break;*/
                    default:
                        MessageBox.Show("Unknown UserType", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CustomerRegister customerRegister = new CustomerRegister();
            customerRegister.Show();
            this.Close();
        }
    }
}
