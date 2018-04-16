using System;
using Microsoft.Azure.Mobile.Server;

namespace planshetService.DataObjects
{
    public class Basket : EntityData
    {
        public int BasketItemId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}