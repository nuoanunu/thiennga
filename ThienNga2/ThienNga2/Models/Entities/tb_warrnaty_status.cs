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
    
    public partial class tb_warrnaty_status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_warrnaty_status()
        {
            this.tb_warranty_activities = new HashSet<tb_warranty_activities>();
        }
    
        public int id { get; set; }
        public string statusName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_warranty_activities> tb_warranty_activities { get; set; }
    }
}
