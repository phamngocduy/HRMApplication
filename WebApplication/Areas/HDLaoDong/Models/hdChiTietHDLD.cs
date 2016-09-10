using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class hdChiTietHDLD
    {
        public hdChiTietHDLD()
        {
            this.hdPhuLucHD12LuuFile = new List<hdPhuLucHD12LuuFile>();
            this.hdPhuLucHD2 = new List<hdPhuLucHD2>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int NLD_id { get; set; }
		[Required]
		[StringLength(50)]
        public string HotenNLD { get; set; }
        public Nullable<int> Gioitinh_id { get; set; }
        public Nullable<int> Quoctich_id { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
        public string Noisinh { get; set; }
        public Nullable<int> Nghenghiep_id { get; set; }
        public string NgheNghiep { get; set; }
        public string Diachithuongtru { get; set; }
		[StringLength(15)]
        public string soCMND { get; set; }
        public Nullable<System.DateTime> cmndNgaycap { get; set; }
        public Nullable<int> cmndNoicap { get; set; }
        public Nullable<int> Donvi_id { get; set; }
        public string DonVi { get; set; }
		[StringLength(100)]
        public string ChucvutruongDV { get; set; }
        public Nullable<int> Chucdanh_id { get; set; }
        public string ChucDanh { get; set; }
        public Nullable<int> Chucvu_id { get; set; }
        public string ChucVu { get; set; }
		[Required]
		[StringLength(20)]
        public string SoHD { get; set; }
		[StringLength(50)]
        public string LoaiHD { get; set; }
		[Required]
        public int LoaiHD_id { get; set; }
		[Required]
        public int ThoihanHD_id { get; set; }
        public string ThoiHanHD { get; set; }
		[Required]
        public System.DateTime NgayHL { get; set; }
        public Nullable<System.DateTime> NgayhetHL { get; set; }
        public string Congviec { get; set; }
		[Required]
        public int ThoigioLV_id { get; set; }
        public string ThoiGioLV { get; set; }
		[Required]
        public bool BHXH { get; set; }
		[StringLength(15)]
        public string Mucluongchinh { get; set; }
        public Nullable<int> Tyleluong { get; set; }
        public Nullable<int> HSLuong_id { get; set; }
        public Nullable<double> HSLuong { get; set; }
        public Nullable<int> Bac_id { get; set; }
		[StringLength(50)]
        public string Bac { get; set; }
        public Nullable<int> Ngach_id { get; set; }
		[StringLength(50)]
        public string Ngach { get; set; }
        public Nullable<int> Nhom_id { get; set; }
		[StringLength(50)]
        public string Nhom { get; set; }
		[StringLength(50)]
        public string MaNhom { get; set; }
        public string Bangluong_id { get; set; }
		[StringLength(1)]
        public string QT_NLDky { get; set; }
		[StringLength(1)]
        public string QT_TrinhHT { get; set; }
		[StringLength(1)]
        public string QT_HTky { get; set; }
		[StringLength(1)]
        public string QT_LuuHS { get; set; }
		[StringLength(1)]
        public string QT_TraNLD { get; set; }
        public Nullable<System.DateTime> QT_NgayNLDky { get; set; }
        public Nullable<System.DateTime> QT_NgayTrinhHT { get; set; }
        public Nullable<System.DateTime> QT_NgayHTky { get; set; }
        public Nullable<System.DateTime> QT_NgayLuuHS { get; set; }
        public Nullable<System.DateTime> QT_NgayTraNLD { get; set; }
        public string Ghichu { get; set; }
        public string mauHopDong { get; set; }
        public string banHopDong { get; set; }

		[ForeignKey("LoaiHD_id")]
        public virtual dmLoaiHopDong dmLoaiHopDong { get; set; }
		[ForeignKey("ThoigioLV_id")]
        public virtual dmThoiGioLamViec dmThoiGioLamViec { get; set; }
		[ForeignKey("ThoihanHD_id")]
        public virtual dmThoiHanHD dmThoiHanHD { get; set; }
		[ForeignKey("NLD_id")]
        public virtual hdNLD hdNLD1 { get; set; }
        public virtual ICollection<hdPhuLucHD12LuuFile> hdPhuLucHD12LuuFile { get; set; }
        public virtual ICollection<hdPhuLucHD2> hdPhuLucHD2 { get; set; }
    }
}
