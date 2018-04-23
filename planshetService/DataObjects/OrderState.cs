using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("OrderState")]
    public class OrderState : EntityData
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string OrderStates { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}