using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsQTLamNghiViec
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public System.DateTime ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<int> DonVi_id { get; set; }
        public Nullable<int> ChucDanh_id { get; set; }
        public Nullable<int> ChucDanhChucVu_id { get; set; }
        public Nullable<int> NgheNghiep_id { get; set; }
        public string GhiChu { get; set; }
		[StringLength(10)]
        public string SoQuyetDinh { get; set; }
        public Nullable<int> ChucVu_id { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
        public Nullable<int> N_id { get; set; }
        public Nullable<int> LoaiNghi_id { get; set; }
        public Nullable<System.DateTime> N_NgayBatDau { get; set; }
        public Nullable<System.DateTime> N_NgayKetThuc { get; set; }
		[StringLength(20)]
        public string N_SoQuyetDinh { get; set; }
		[StringLength(150)]
        public string N_GhiChu { get; set; }
		[StringLength(10)]
        public string maDonVi { get; set; }
		[StringLength(100)]
        public string tenDonVi { get; set; }
        public Nullable<int> sttDonVi { get; set; }
		[StringLength(10)]
        public string maChucDanh { get; set; }
		[StringLength(50)]
        public string tenChucDanh { get; set; }
        public Nullable<int> sttChucDanh { get; set; }
		[StringLength(10)]
        public string maChucDanhChuyenMon { get; set; }
		[StringLength(50)]
        public string tenChucDanhChuyenMon { get; set; }
        public Nullable<bool> qlTapSu { get; set; }
        public Nullable<int> sttChucDanhChuyenMon { get; set; }
		[StringLength(10)]
        public string maNgheNghiep { get; set; }
		[StringLength(50)]
        public string tenNgheNghiep { get; set; }
        public Nullable<int> sttNgheNghiep { get; set; }
		[StringLength(10)]
        public string maLoaiNghiNganHan { get; set; }
		[StringLength(50)]
        public string tenLoaiNghiNganHan { get; set; }
        public Nullable<bool> khongHuongLuong { get; set; }
        public Nullable<bool> tinhThamNien { get; set; }
        public Nullable<int> sttLoaiNghiNganHan { get; set; }
        public Nullable<int> HienTai { get; set; }

    }
}
