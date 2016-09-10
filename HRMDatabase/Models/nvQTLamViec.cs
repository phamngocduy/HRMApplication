using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQTLamViec
    {
        public nvQTLamViec()
        {
            this.NhanViens = new List<NhanVien>();
            this.nvQLTapSus = new List<nvQLTapSu>();
            this.nvQTNghiNganHans = new List<nvQTNghiNganHan>();
        }

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

		[ForeignKey("ChucDanh_id")]
        public virtual dmChucDanh ChucDanh { get; set; }
		[ForeignKey("ChucDanhChucVu_id")]
        public virtual dmChucDanhChuyenMon ChucDanhChuyenMon { get; set; }
		[ForeignKey("ChucVu_id")]
        public virtual dmChucVu dmChucVu { get; set; }
		[ForeignKey("DonVi_id")]
        public virtual dmDonVi DonVi { get; set; }
		[ForeignKey("NgheNghiep_id")]
        public virtual dmNgheNghiep NgheNghiep { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<nvQLTapSu> nvQLTapSus { get; set; }
        public virtual ICollection<nvQTNghiNganHan> nvQTNghiNganHans { get; set; }
    }
}
