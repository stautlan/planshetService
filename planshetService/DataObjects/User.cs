using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Server;

namespace planshetService.DataObjects
{
    [System.ComponentModel.DataAnnotations.Schema.Table("User")]
    public class User : EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Baskets = new HashSet<Basket>();
            UserTypes = new HashSet<UserType>();
        }

        [System.ComponentModel.DataAnnotations.Key]
        public int UserId { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string UserSirname { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string UserPassword { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string UserPic { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string UserMobile { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<UserType> UserTypes { get; set; }
    }
}