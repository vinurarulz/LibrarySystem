﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryDBEntities : DbContext
    {
        public LibraryDBEntities()
            : base("name=LibraryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Barcode> Barcodes { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BorrowDetail> BorrowDetails { get; set; }
        public virtual DbSet<BorrowHeader> BorrowHeaders { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MainCategory> MainCategories { get; set; }
        public virtual DbSet<Penalty> Penalties { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Refree> Refrees { get; set; }
        public virtual DbSet<Register_fee> Register_fee { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Type> User_Type { get; set; }
    }
}
