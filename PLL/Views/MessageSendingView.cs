using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class MessageSendingView
    {
        UserService userService;
        MessageService messageService;
        public MessageSendingView(MessageService messageService, UserService userService)
        {
            this.messageService = messageService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var messageSendingData = new MessageSendingData();

            Console.Write("Enter recipient's email: ");
            messageSendingData.RecipientEmail = Console.ReadLine();

            Console.WriteLine("Enter a message (max. 5000 characters): ");
            messageSendingData.Content = Console.ReadLine();

            messageSendingData.SenderId = user.Id;

            try
            {
                messageService.SendMessage(messageSendingData);

                SuccessMessage.Show("Message sent successfully!");

                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("User is not found!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("\r\nPlease enter a valid value!");
            }

            catch (Exception)
            {
                AlertMessage.Show("There was an error sending the message!");
            }

        }
    }
}