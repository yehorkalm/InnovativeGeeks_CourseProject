﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class eWalletEntities : DbContext
{
    public eWalletEntities()
        : base("name=eWalletEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<AccountInfo> AccountInfoes { get; set; }
    public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
    public virtual DbSet<Login> Logins { get; set; }
    public virtual DbSet<transaction> transactions { get; set; }
}
