using System;
using Microsoft.Azure.Mobile.Server;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Basket")]
    public class Basket : EntityData
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int BasketItemId { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public int? Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}