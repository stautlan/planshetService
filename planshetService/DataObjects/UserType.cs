using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("UserType")]
    public class UserType : EntityData
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string Type { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}