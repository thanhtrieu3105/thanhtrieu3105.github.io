//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_dienthoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSKTSP
    {
        public int MaTS { get; set; }
        public string MaSP { get; set; }
        public string CongNgheManHinh { get; set; }
        public string DoPhanGiai { get; set; }
        public string ManHinhrong { get; set; }
        public string MatKinhCamUng { get; set; }
        public string DoPhanGiaiCamS { get; set; }
        public string QuayPhim { get; set; }
        public string Flash { get; set; }
        public string TinhNangCamS { get; set; }
        public string DoPhanGiaiCamT { get; set; }
        public string TinhNangCamT { get; set; }
        public string HeDieuHanh { get; set; }
        public string CPU { get; set; }
        public string TocDoCPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string DungLuong { get; set; }
        public string DungLuongCon { get; set; }
        public string DanhBa { get; set; }
        public string Mang { get; set; }
        public string Sim { get; set; }
        public string Wifi { get; set; }
        public string GPS { get; set; }
        public string Bluetooth { get; set; }
        public string Sac { get; set; }
        public string Jack { get; set; }
        public string KetNoiKhac { get; set; }
        public string DungLuongPin { get; set; }
        public string LoaiPin { get; set; }
        public string SacToiDa { get; set; }
        public string CongNghePin { get; set; }
        public string BaoMatNC { get; set; }
        public string TinhNangDB { get; set; }
        public string KhangNuocBui { get; set; }
        public string XemPhim { get; set; }
        public string NgheNhac { get; set; }
        public string ThietKe { get; set; }
        public string ChatLieu { get; set; }
        public string KichThuoc { get; set; }
        public Nullable<System.DateTime> ThoiDiemRaMat { get; set; }
    
        public virtual SanPham SanPham { get; set; }
    }
}
