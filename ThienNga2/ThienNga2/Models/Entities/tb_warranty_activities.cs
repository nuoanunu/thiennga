//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThienNga2.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_warranty_activities
    {
        public int id { get; set; }
        public System.DateTime startDate { get; set; }
        public int employee { get; set; }
        public string warrantyID { get; set; }
        public string Description { get; set; }
        public int status { get; set; }
        public Nullable<System.DateTime> realeaseDATE { get; set; }
        public string itemID { get; set; }
        public Nullable<System.DateTime> finishFixingDate { get; set; }
    
        public virtual employee employee1 { get; set; }
        public virtual tb_warrnaty_status tb_warrnaty_status { get; set; }
    }
}
