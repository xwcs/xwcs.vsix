﻿//------------------------------------------------------------------------------
// <auto-generated>
// By: Laco
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.db.iter_new
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class niter_newEntities3 : DbContext
    {
        public niter_newEntities3()
            : base("name=niter_newEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<iter> iter { get; set; }
        public virtual DbSet<iter_in_opere> iter_in_opere { get; set; }
        public virtual DbSet<opere> opere { get; set; }
        public virtual DbSet<tipologie> tipologie { get; set; }
    }
}
