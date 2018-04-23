using Microsoft.Azure.Mobile.Server;
using System;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Purchase")]
    public class Purchase : EntityData
    {
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? Amount { get; set; }
        public DateTime DateTime { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}