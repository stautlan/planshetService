using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    public class UserType : EntityData
    {
        public string Type { get; set; }
        public Nullable<int> UserId { get; set; }

        public virtual User User { get; set; }
    }
}