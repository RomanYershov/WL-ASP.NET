using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WL.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
        base("ForumConString")
        { }

        public DbSet<User> Users { get; set; }
    }
}