//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daily_Payment_System.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_daily_rate
    {
        public int rate_id { get; set; }
        public decimal C1_sale_out { get; set; }
        public decimal C1_buy_in { get; set; }
        public decimal C2_sale_out { get; set; }
        public decimal C2_buy_in { get; set; }
        public System.DateTime create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}