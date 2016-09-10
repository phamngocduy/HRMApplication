using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            this.bcKhoaGiangDays = new List<bcKhoaGiangDay>();
            this.BoiDuongChuyenMons = new List<BoiDuongChuyenMon>();
            this.ChungChis = new List<ChungChi>();
            this.DanhHieux = new List<DanhHieu>();
            this.nvBangCaps = new List<nvBangCap>();
            this.nvTTKhenThuongs = new List<nvTTKhenThuong>();
            this.nvQTLamViecTruocs = new List<nvQTLamViecTruoc>();
            this.nvChucDanhGiangViens = new List<nvChucDanhGiangVien>();
            this.nvCTDoanThes = new List<nvCTDoanThe>();
            this.nvCTDoanTheTruocs = new List<nvCTDoanTheTruoc>();
            this.nvCTNganHans = new List<nvCTNganHan>();
            this.nvDiaChiNhas = new List<nvDiaChiNha>();
            this.nvHeSoLuongs = new List<nvHeSoLuong>();
            this.nvHocHams = new List<nvHocHam>();
            this.nvTTKhenThuongTruocs = new List<nvTTKhenThuongTruoc>();
            this.nvKhoaGiangDays = new List<nvKhoaGiangDay>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
            this.nvTTKyLuats = new List<nvTTKyLuat>();
            this.nvTTKyLuatTruocs = new List<nvTTKyLuatTruoc>();
            this.nvLuongKhoans = new List<nvLuongKhoan>();
            this.nvNganhGiangDays = new List<nvNganhGiangDay>();
            this.nvQTChungChis = new List<nvQTChungChi>();
            this.nvQTKiemNhiems = new List<nvQTKiemNhiem>();
            this.nvQHGiaDinhs = new List<nvQHGiaDinh>();
            this.nvTapHuans = new List<nvTapHuan>();
            this.nvTrangThaiLuongs = new List<nvTrangThaiLuong>();
            this.nvTTMoRongs = new List<nvTTMoRong>();
            this.nvTTThongKes = new List<nvTTThongKe>();
            this.nvQTLamViecs = new List<nvQTLamViec>();
            this.QuaTrinhHocs = new List<QuaTrinhHoc>();
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
            this.nvTheDinhDanhs = new List<nvTheDinhDanh>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(10)]
        public string MaHS { get; set; }
		[StringLength(10)]
        public string MaTD { get; set; }
		[StringLength(10)]
        public string MaTV { get; set; }
		[Required]
		[StringLength(10)]
        public string MaNV { get; set; }
		[StringLength(20)]
        public string MaST { get; set; }
		[Required]
        public bool laNVMoi { get; set; }
        public Nullable<System.DateTime> ngayNghiViec { get; set; }
		[StringLength(20)]
        public string ttlhDTNhaRieng { get; set; }
		[StringLength(20)]
        public string ttlhDTDiDong { get; set; }
		[StringLength(50)]
        public string ttlhEmailTruong { get; set; }
		[StringLength(100)]
        public string ttlhEmailKhac { get; set; }
        public Nullable<int> ttlhDCTamTruKT3_id { get; set; }
		[Required]
        public int qtlvThamNienGiangDayT { get; set; }
        public Nullable<int> qtlvCongTac_id { get; set; }
        public Nullable<int> qltlHeSoLuong_id { get; set; }
		[StringLength(20)]
        public string qtlvSoQDNghiViec { get; set; }
        public Nullable<int> nvNganhGiangDay_id { get; set; }

        public virtual ICollection<bcKhoaGiangDay> bcKhoaGiangDays { get; set; }
        public virtual ICollection<BoiDuongChuyenMon> BoiDuongChuyenMons { get; set; }
        public virtual ICollection<ChungChi> ChungChis { get; set; }
        public virtual ICollection<DanhHieu> DanhHieux { get; set; }
        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
        public virtual ICollection<nvTTKhenThuong> nvTTKhenThuongs { get; set; }
        public virtual ICollection<nvQTLamViecTruoc> nvQTLamViecTruocs { get; set; }
		[ForeignKey("ttlhDCTamTruKT3_id")]
        public virtual nvDiaChiNha nvDiaChiNhaKT3 { get; set; }
		[ForeignKey("qltlHeSoLuong_id")]
        public virtual nvHeSoLuong nvHeSoLuong { get; set; }
		[ForeignKey("nvNganhGiangDay_id")]
        public virtual nvNganhGiangDay nvNganhGiangDay { get; set; }
		[ForeignKey("qtlvCongTac_id")]
        public virtual nvQTLamViec nvQTLamViec { get; set; }
        public virtual ICollection<nvChucDanhGiangVien> nvChucDanhGiangViens { get; set; }
        public virtual ICollection<nvCTDoanThe> nvCTDoanThes { get; set; }
        public virtual ICollection<nvCTDoanTheTruoc> nvCTDoanTheTruocs { get; set; }
        public virtual ICollection<nvCTNganHan> nvCTNganHans { get; set; }
        public virtual ICollection<nvDiaChiNha> nvDiaChiNhas { get; set; }
        public virtual ICollection<nvHeSoLuong> nvHeSoLuongs { get; set; }
        public virtual ICollection<nvHocHam> nvHocHams { get; set; }
        public virtual ICollection<nvTTKhenThuongTruoc> nvTTKhenThuongTruocs { get; set; }
        public virtual ICollection<nvKhoaGiangDay> nvKhoaGiangDays { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
        public virtual ICollection<nvTTKyLuat> nvTTKyLuats { get; set; }
        public virtual ICollection<nvTTKyLuatTruoc> nvTTKyLuatTruocs { get; set; }
        public virtual ICollection<nvLuongKhoan> nvLuongKhoans { get; set; }
        public virtual ICollection<nvNganhGiangDay> nvNganhGiangDays { get; set; }
        public virtual ICollection<nvQTChungChi> nvQTChungChis { get; set; }
        public virtual ICollection<nvQTKiemNhiem> nvQTKiemNhiems { get; set; }
        public virtual ICollection<nvQHGiaDinh> nvQHGiaDinhs { get; set; }
        public virtual ICollection<nvTapHuan> nvTapHuans { get; set; }
        public virtual ICollection<nvTrangThaiLuong> nvTrangThaiLuongs { get; set; }
        public virtual ICollection<nvTTMoRong> nvTTMoRongs { get; set; }
        public virtual ICollection<nvTTThongKe> nvTTThongKes { get; set; }
        public virtual ICollection<nvQTLamViec> nvQTLamViecs { get; set; }
        public virtual ICollection<QuaTrinhHoc> QuaTrinhHocs { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
        public virtual ICollection<nvTheDinhDanh> nvTheDinhDanhs { get; set; }
    }
}
