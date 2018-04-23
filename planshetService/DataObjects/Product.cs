using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Product")]
    public class Product : EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Baskets = new HashSet<Basket>();
            this.Orders = new HashSet<Order>();
        }

        [System.ComponentModel.DataAnnotations.Key]
        public int ProductId { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string Unit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}