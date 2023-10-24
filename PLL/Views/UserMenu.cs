using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserMenu
    {
        UserService userService;
        public UserMenu(UserService userService)
        {
            this.userService = userService;
        }
        
        public void ShowUserMenu(User user)
        {
            while(true) 
            {
                Console.WriteLine($"Incoming messages: {user.IncomingMessages.Count()}");
                Console.WriteLine($"Outgoing messages: {user.OutgoingMessages.Count()}\n");
                Console.WriteLine($"Your friends: {user.Friends.Count()}");

                Console.WriteLine("Press 1: View my profile information");
                Console.WriteLine("Press 2: Edit my profile");
                Console.WriteLine("Press 3: Add as Friend");
                Console.WriteLine("Press 4: New message)");
                Console.WriteLine("Press 5: View incoming messages)");
                Console.WriteLine("Press 6: View outgoing messages)");
                Console.WriteLine("Press 7: View your friends)");
                Console.WriteLine("Press 8: Log out");

                string key = Console.ReadLine();

                if (key == "8") break;
                switch (key)
                {
                    case "1":
                        {
                            Program.userInfo.Show(user);
                            break;
                        }
                    case "2":
                        {
                            Program.userDataUpdateView.Show(user);
                            user = userService.FindById(user.Id);
                            break;
                        }

                    case "3":
                        {
                            Program.addingFriendView.Show(user);
                            user = userService.FindById(user.Id);
                            break;
                        }

                    case "4":
                        {
                            Program.messageSendingView.Show(user);
                            user = userService.FindById(user.Id);
                            break;
                        }

                    case "5":
                        {

                            Program.userIncomingMessageView.Show(user.IncomingMessages);
                            break;
                        }

                    case "6":
                        {
                            Program.userOutcomingMessageView.Show(user.OutgoingMessages);
                            break;
                        }

                    case "7":
                        {
                            Program.userFriendView.Show(user.Friends);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter correct value:");
                            break;
                        }
                }
            }
        }
    }
}
            


        
    

