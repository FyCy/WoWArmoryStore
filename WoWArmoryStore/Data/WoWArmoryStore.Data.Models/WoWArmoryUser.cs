// ReSharper disable VirtualMemberCallInConstructor
namespace WoWArmoryStore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    using WoWArmoryStore.Data.Common.Models;

    public class WoWArmoryUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public WoWArmoryUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.MyHeroes = new HashSet<Hero>();
            this.Orders = new List<Order>();
            this.Posts = new HashSet<Post>();
        }

        public string AccountIcon { get; set; }

        public ICollection<Hero> MyHeroes { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Post> Posts { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
