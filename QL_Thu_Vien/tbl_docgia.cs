//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCNPM
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_docgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_docgia()
        {
            this.tbl_phieumuon_tra = new HashSet<tbl_phieumuon_tra>();
        }
    
        public int madg { get; set; }
        public string tendg { get; set; }
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string lop { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_phieumuon_tra> tbl_phieumuon_tra { get; set; }
    }
}
