using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Order")]
    public class Order : EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderStates = new HashSet<OrderState>();
        }

        public int OrderId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Amount { get; set; }

        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderState> OrderStates { get; set; }
    }
}