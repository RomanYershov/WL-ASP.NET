﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ForumDbEntities : DbContext
    {
        public ForumDbEntities()
            : base("name=ForumDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Discussions> DiscussionsSet { get; set; }
        public virtual DbSet<Comments> CommentsSet { get; set; }
        public virtual DbSet<Categories> CategoriesSet { get; set; }
    }
}
