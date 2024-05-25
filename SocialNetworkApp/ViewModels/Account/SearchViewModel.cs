using SocialNetworkApp.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SocialNetworkApp.ViewModels.Account
{
    public class SearchViewModel
    {
        public List<UserWithFriendExt> UserList { get; set; }

    }
}
