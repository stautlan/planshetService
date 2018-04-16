using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    public class OrderState : EntityData
    {
        public string OrderStates { get; set; }
        public Nullable<int> OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}