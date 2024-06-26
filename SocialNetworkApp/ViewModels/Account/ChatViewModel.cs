﻿using SocialNetworkApp.Models.Users;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;

namespace SocialNetworkApp.ViewModels.Account
{
    public class ChatViewModel
    {
        public User You { get; set; }

        public User ToWhom { get; set; }

        public List<Message> History { get; set; }

        public MessageViewModel NewMessage { get; set; }

        public ChatViewModel()
        {
            NewMessage = new MessageViewModel();
        }

    }
}

