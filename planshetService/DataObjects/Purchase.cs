using Microsoft.Azure.Mobile.Server;
using System;

namespace planshetService.DataObjects
{
    public class Purchase : EntityData
    {
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Amount { get; set; }
        public DateTime DateTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}