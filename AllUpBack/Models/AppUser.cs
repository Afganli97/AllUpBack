using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AllUpBack.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            IsDeleted = false;
        }
        public string FullName { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}