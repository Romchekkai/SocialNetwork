﻿using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationView
    {
        UserService userService;
        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.WriteLine("Enter your name to create a new profile:");
            userRegistrationData.FirstName = Console.ReadLine();

            Console.Write("LastName:");
            userRegistrationData.LastName = Console.ReadLine();

            Console.Write("Password:");
            userRegistrationData.Password = Console.ReadLine();

            Console.Write("Email:");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                this.userService.Register(userRegistrationData);

                SuccessMessage.Show("Your profile has been successfully created. you can log in with your usage data.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Please enter a valid value.");
            }

            catch (Exception)
            {
                AlertMessage.Show("An error occurred during registration.");
            }
        }
    }
}