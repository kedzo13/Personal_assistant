﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Funkcionalnost_prijave
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PI21_54_DBEntities : DbContext
    {
        public PI21_54_DBEntities()
            : base("name=PI21_54_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Type> User_Type { get; set; }
    }
}
