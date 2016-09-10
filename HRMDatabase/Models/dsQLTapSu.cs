using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsQLTapSu
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int CT_id { get; set; }
        public Nullable<System.DateTime> ThoiGianDenHan { get; set; }
        public Nullable<System.DateTime> NgayThongBao { get; set; }
        public Nullable<System.DateTime> NgayNhanHoSo { get; set; }
        public Nullable<System.DateTime> NgayLapToTrinh { get; set; }
        public string GhiChu { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(100)]
        public string tenDonVi { get; set; }
		[StringLength(10)]
        public string maDonVi { get; set; }
        public Nullable<int> sttDonVi { get; set; }
		[StringLength(50)]
        public string tenChucDanhChuyenMon { get; set; }
		[StringLength(10)]
        public string maChucDanhChuyenMon { get; set; }
        public Nullable<int> sttChucDanhChuyenMon { get; set; }
        public Nullable<int> NV_id { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<System.DateTime> NgayTuyenDung { get; set; }

    }
}
