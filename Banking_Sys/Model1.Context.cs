﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banking_Sys
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Banking_dbEntities : DbContext
    {
        public Banking_dbEntities()
            : base("name=Banking_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Db1> Db1 { get; set; }
        public virtual DbSet<debit> debits { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<FD> FDs { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<userAccount> userAccounts { get; set; }
        public virtual DbSet<userTable> userTables { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
    }
}