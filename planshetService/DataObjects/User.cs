using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Server;

namespace planshetService.DataObjects
{
    public class User : EntityData
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSirname { get; set; }
        public string UserPassword { get; set; }
        public string UserPic { get; set; }
        public string UserMobile { get; set; }

        public virtual ICollection<Basket> Basket { get; set; }
        public virtual ICollection<UserType> UserType { get; set; }
    }
}