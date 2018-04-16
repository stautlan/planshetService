using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;

namespace planshetService.DataObjects
{
    public class Product : EntityData
    {
        public Product()
        {
            this.Basket = new HashSet<Basket>();
            this.Order = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Unit { get; set; }

        public virtual ICollection<Basket> Basket { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}