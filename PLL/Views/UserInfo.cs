using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.PLL.Views
{
    public class UserInfo
    {
        public void Show(User user)
        {
            Console.WriteLine("Profile information");
            Console.WriteLine($"ID: {user.Id}");
            Console.WriteLine($"Name: {user.FirstName}");
            Console.WriteLine($"LastName: {user.LastName}");
            Console.WriteLine($"Password: {user.Password}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"The Refer to profile photo: {user.Photo}");
            Console.WriteLine($"My favorite movie: {user.FavoriteMovie}");
            Console.WriteLine($"My favorite book: {user.FavoriteBook}");
        }
    }
}
