using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class nvbhNhanVienBHXH
    {
        public nvbhNhanVienBHXH()
        {
            this.nvbhDanhSachDieuChinhChucDanhs = new List<nvbhDanhSachDieuChinhChucDanh>();
            this.nvbhLaiTruyThuBHs = new List<nvbhLaiTruyThuBH>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(5)]
        public string TinhTrang { get; set; }
		[StringLength(100)]
        public string HoVaTen { get; set; }
        public Nullable<double> HeSoLuong { get; set; }
        public Nullable<long> MucLuongDongBHXHVaBHYT { get; set; }
        public Nullable<int> SoThangThamGiaBHXH { get; set; }
        public Nullable<int> SoNamThamGiaBHXH { get; set; }
        public Nullable<int> SoNamThamGiaBHXHTruocVeTruong { get; set; }
        public Nullable<int> SoThangThamGiaBHXHTruocVeTruong { get; set; }
        public Nullable<System.DateTime> ThoiGianThamGiaBHXHTaiTruong { get; set; }
        public Nullable<int> SoNamThamGiaBHTNT { get; set; }
        public Nullable<int> SoThangThamGiaBHTN { get; set; }
        public Nullable<int> SoNamThamGiaBHTNTruocVeTruong { get; set; }
        public Nullable<int> SoThangThamGiaBHTNTruocVeTruong { get; set; }
        public Nullable<System.DateTime> ThoiGianThamGiaBHTNTaiTruong { get; set; }
		[StringLength(50)]
        public string MANV { get; set; }
		[StringLength(50)]
        public string DonVi { get; set; }
        public Nullable<bool> Nu { get; set; }
        public Nullable<int> CMND { get; set; }
		[StringLength(50)]
        public string ChucDanh { get; set; }
		[StringLength(200)]
        public string DiaChiTT { get; set; }
        public Nullable<int> SoBHXH { get; set; }
        public Nullable<int> SoKCB { get; set; }
        public Nullable<int> iddmNoiKCB { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> Donvi_id { get; set; }
        public Nullable<int> NV_id { get; set; }
        public Nullable<System.DateTime> TG_BD_TS { get; set; }
        public Nullable<System.DateTime> TG_KT_TS { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
        public Nullable<bool> TGBHXHBHYT { get; set; }
        public Nullable<bool> TGBHTN { get; set; }
        public Nullable<int> sonamBHXH { get; set; }
        public Nullable<int> sothangBHXH { get; set; }
        public Nullable<int> sonamBHTN { get; set; }
        public Nullable<int> sothangBHTN { get; set; }
        public Nullable<int> ThangNghiTS { get; set; }

		[ForeignKey("iddmNoiKCB")]
        public virtual dmNoiKCB dmNoiKCB { get; set; }
        public virtual ICollection<nvbhDanhSachDieuChinhChucDanh> nvbhDanhSachDieuChinhChucDanhs { get; set; }
        public virtual ICollection<nvbhLaiTruyThuBH> nvbhLaiTruyThuBHs { get; set; }
    }
}
