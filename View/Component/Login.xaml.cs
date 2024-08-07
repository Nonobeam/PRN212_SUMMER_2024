﻿using Data.Entities;
using Service;
using System.IO;
using System.Windows;
using View.Admin;
using View.CLinicOwner;
using View.Customer;
using View.DentistPage;

namespace View.Component
{
    public partial class Login : Window
    {
        private static User user;
        private UserService userService;
        private BookingService service;
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
                String welcome = "Login Successful.\nWelcome back " + user.Name;
                MessageBox.Show(welcome, "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                string dateString = "2024-07-24 12:00:00";
                DateTime? parsedDate = DateTime.Parse(dateString);
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
                    case "Dentist":
                        AppointmentWeek dentistWindow = new AppointmentWeek(user);
                        dentistWindow.Show();
                        break;
                    case "Manager":
                        ManagerWindow managerWindow = new ManagerWindow(user);
                        managerWindow.Show();
                        break;
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
