using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Category")]
    public class Category : EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        [System.ComponentModel.DataAnnotations.Key]
        public int CaregoryId { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "image")]
        public string CategoryIcon { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        public string CategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}