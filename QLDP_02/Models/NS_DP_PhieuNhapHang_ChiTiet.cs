//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDP_02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NS_DP_PhieuNhapHang_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapHang { get; set; }
        public int SanPham { get; set; }
        public Nullable<int> Size { get; set; }
        public int SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> DonViTinh { get; set; }
        public Nullable<int> SoLuongDaNhap { get; set; }
        public Nullable<int> TinhChatDongPhuc { get; set; }
    }
}
