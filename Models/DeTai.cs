//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Đồ_án.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeTai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeTai()
        {
            this.SinhViens = new HashSet<SinhVien>();
        }
    
        public string MaDT { get; set; }
        public string TenDT { get; set; }
        public string MoTaDT { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public System.DateTime NgayKetThuc { get; set; }
        public double TienDoDT { get; set; }
        public string MaGV { get; set; }
        public string NhanXet { get; set; }
        public string FileDeTai { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
