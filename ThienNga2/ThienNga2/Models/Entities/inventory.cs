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
    
    public partial class inventory
    {
        public int id { get; set; }
        public string productStoreCode { get; set; }
        public string productFactoryCode { get; set; }
        public System.DateTime dateAdded { get; set; }
        public int inventoryID { get; set; }
        public int quantity { get; set; }
    
        public virtual tb_inventory_name tb_inventory_name { get; set; }
    }
}
