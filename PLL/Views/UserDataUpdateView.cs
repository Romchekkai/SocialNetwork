using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserDataUpdateView
    {
        UserService userService;
        public UserDataUpdateView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            Console.Write("Name:");
            user.FirstName = Console.ReadLine();

            Console.Write("LastName:");
            user.LastName = Console.ReadLine();

            Console.Write("The Refer to profile photo:");
            user.Photo = Console.ReadLine();

            Console.Write("My favorite movie:");
            user.FavoriteMovie = Console.ReadLine();

            Console.Write("My favorite book:");
            user.FavoriteBook = Console.ReadLine();

            this.userService.Update(user);

            SuccessMessage.Show("Your profile has been successfully updated!");
        }
    }
}

