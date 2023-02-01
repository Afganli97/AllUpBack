using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.DAL
{
    public class DataBase : IdentityDbContext<AppUser>
    {
        public DataBase(DbContextOptions options) : base(options)
        {
        }
    }
}