using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserOutcomingMessageView
    {
        public void Show(IEnumerable<Message> outcomingMessages)
        {
            Console.WriteLine("Outgoing messages");

            if (outcomingMessages.Count() == 0)
            {
                Console.WriteLine("No outgoing messages");
                return;
            }

            outcomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine($"To: {message.RecipientEmail}. Message: {message.Content}");
            });
        }
    }
}