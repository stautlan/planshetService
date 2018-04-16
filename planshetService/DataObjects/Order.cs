using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    public class Order : EntityData
    {
        public Order()
        {
            this.OrderState = new HashSet<OrderState>();
        }

        public int OrderId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<OrderState> OrderState { get; set; }
    }
}