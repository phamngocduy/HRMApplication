using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQLThuViec
    {
		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[Required]
		[StringLength(10)]
        public string maThuViec { get; set; }
		[Required]
        public System.DateTime ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
		[Required]
        public int SoNgayThuViec { get; set; }
        public Nullable<System.DateTime> NgayNhanHoSo { get; set; }
        public Nullable<System.DateTime> NgayLapToTrinh { get; set; }
        public Nullable<System.DateTime> NgayThongBao { get; set; }
		[StringLength(150)]
        public string GhiChu { get; set; }
        public Nullable<int> DonVi_id { get; set; }
        public Nullable<int> ChucDanh_id { get; set; }
        public Nullable<int> ChucDanhChucVu_id { get; set; }
		[StringLength(10)]
        public string MaNV { get; set; }

		[ForeignKey("ChucDanh_id")]
        public virtual dmChucDanh ChucDanh { get; set; }
		[ForeignKey("ChucDanhChucVu_id")]
        public virtual dmChucDanhChuyenMon ChucDanhChuyenMon { get; set; }
		[ForeignKey("DonVi_id")]
        public virtual dmDonVi DonVi { get; set; }
    }
}
