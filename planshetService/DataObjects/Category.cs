using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    public class Category : EntityData
    {
        public Category()
        {
            this.Product = new HashSet<Product>();
        }

        public int CaregoryId { get; set; }
        public string CategoryIcon { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}