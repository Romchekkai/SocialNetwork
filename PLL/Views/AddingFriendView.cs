using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class AddingFriendView
    {
        UserService userService;
        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserFriendsData();

                Console.WriteLine("Enter the email address of the user you want to add as a friend: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("You have successfully added the user as a friend!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("The user with the specified email address does not exist!");
            }

            catch (Exception)
            {
                AlertMessage.Show("An error occurred when adding the user as a friend!");
            }

        }
    }
}