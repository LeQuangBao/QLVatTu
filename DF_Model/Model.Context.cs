﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DF_Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyVatTuContext : DbContext
    {
        public QuanLyVatTuContext()
            : base(@"metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=';data source=.\SORA_SERVER;initial catalog=QuanLyVatTu;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework';")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietPhieuGiaoNhan> ChiTietPhieuGiaoNhan { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
        public virtual DbSet<DonVi> DonVi { get; set; }
        public virtual DbSet<DonViTinh> DonViTinh { get; set; }
        public virtual DbSet<Loai> Loai { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<PhieuGiaoNhan> PhieuGiaoNhan { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TinhTrang> TinhTrang { get; set; }
        public virtual DbSet<ThietBi> ThietBi { get; set; }
    }
}
