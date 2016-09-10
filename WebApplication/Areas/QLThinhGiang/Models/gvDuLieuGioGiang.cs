using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLThinhGiang.Models
{
    public partial class gvDuLieuGioGiang
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int GV_id { get; set; }
		[Required]
		[StringLength(10)]
        public string maGV { get; set; }
		[Required]
        public int HocKy { get; set; }
		[Required]
        public int NamHoc { get; set; }
		[Required]
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(50)]
        public string ChucDanh { get; set; }
		[StringLength(50)]
        public string HocVi { get; set; }
		[StringLength(50)]
        public string ChucDanhTrinhDo { get; set; }
		[Required]
		[StringLength(50)]
        public string MonDay { get; set; }
		[Required]
		[StringLength(10)]
        public string TietThuc { get; set; }
		[Required]
        public double TietQuyDoi { get; set; }
		[Required]
		[StringLength(50)]
        public string Lop { get; set; }
		[StringLength(10)]
        public string So { get; set; }
		[Required]
        public double HeSoChucDanh { get; set; }
		[Required]
        public double HeSoLopDong { get; set; }
		[Required]
        public int MucChuan { get; set; }
		[Required]
        public double DonGia { get; set; }
		[Required]
        public int TongThuLao { get; set; }
		[Required]
        public double LyThuyet { get; set; }
		[Required]
        public double ThucHanh { get; set; }
		[StringLength(10)]
        public string NhomMH2 { get; set; }
		[StringLength(10)]
        public string NhomMH3 { get; set; }
		[StringLength(10)]
        public string NhomMH6 { get; set; }
		[StringLength(10)]
        public string DonViCongTac { get; set; }
		[Required]
		[StringLength(10)]
        public string KhoaGiangDay { get; set; }
		[Required]
		[StringLength(10)]
        public string NganhGiangDay { get; set; }
		[StringLength(10)]
        public string PhanLoaiGV { get; set; }
		[StringLength(10)]
        public string PhanLoaiGV2 { get; set; }
		[StringLength(50)]
        public string DacCach { get; set; }
        public string GhiChu { get; set; }
		[Required]
        public System.DateTime ThoiGian { get; set; }
        public Nullable<int> nvNganhGiangDay_id { get; set; }

    }
}
