//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnPBL3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANAN()
        {
            this.BANPHUCVUs = new HashSet<BANPHUCVU>();
        }
    
        public string maBan { get; set; }
        public int soGhe { get; set; }
        public string trangThai { get; set; }
        public string ghiChu { get; set; }
        public bool coXoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANPHUCVU> BANPHUCVUs { get; set; }
    }
}
