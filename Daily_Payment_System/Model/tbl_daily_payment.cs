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
    
    public partial class tbl_daily_payment
    {
        public int dlp_id { get; set; }
        public int acc_type_id { get; set; }
        public int cur_id { get; set; }
        public decimal ammount { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}
