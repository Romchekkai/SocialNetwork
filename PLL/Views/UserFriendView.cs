using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("My friends: ");


            if (friends.Count() == 0)
            {
                Console.WriteLine("You don't have friends");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine($"Friend's email: {friend.Email}. Name of a friend: {friend.FirstName}. LastName of a friend: {friend.LastName}");
            });

        }

    }
}