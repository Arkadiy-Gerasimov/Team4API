﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team4API
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Inventory_ItemsEntities : DbContext
    {
        public Inventory_ItemsEntities()
            : base("name=Inventory_ItemsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Act> Act { get; set; }
        public virtual DbSet<Archiev> Archiev { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_map> Product_map { get; set; }
        public virtual DbSet<Responsible_persons> Responsible_persons { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Story> Story { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
