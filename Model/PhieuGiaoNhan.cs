﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PhieuGiaoNhan {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuGiaoNhan() {
            this.ChiTietPhieuGiaoNhan = new HashSet<ChiTietPhieuGiaoNhan>();
        }

        public int MaPhieuGiaoNhan { get; set; }

        public int MaDonVi { get; set; }

        [Display(Name = "Ngày giao nhận")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime NgayGiaoNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuGiaoNhan> ChiTietPhieuGiaoNhan { get; set; }
        public virtual DonVi DonVi { get; set; }
    }
}
