﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daily_Payment_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DailyPaymentEntities : DbContext
    {
        public DailyPaymentEntities()
            : base("name=DailyPaymentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_account_type> tbl_account_type { get; set; }
        public virtual DbSet<tbl_currency> tbl_currency { get; set; }
        public virtual DbSet<tbl_daily_payment> tbl_daily_payment { get; set; }
        public virtual DbSet<tbl_daily_profit> tbl_daily_profit { get; set; }
        public virtual DbSet<tbl_profit_type> tbl_profit_type { get; set; }
        public virtual DbSet<tbl_daily_rate> tbl_daily_rate { get; set; }
    }
}
