//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThietBi()
        {
            this.ChiTietPhieuGiaoNhan = new HashSet<ChiTietPhieuGiaoNhan>();
            this.PhieuNhap = new HashSet<PhieuNhap>();
        }
    
        public int MaThietBi { get; set; }
        public int MaLoai { get; set; }
        public Nullable<System.DateTime> NgayDuaVaoSuDung { get; set; }
        public int TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuGiaoNhan> ChiTietPhieuGiaoNhan { get; set; }
        public virtual Loai Loai { get; set; }
        public virtual TinhTrang TinhTrang1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhap { get; set; }
    }
}
