using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class tdThongTinUngTuyen
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int UngVien_id { get; set; }
        public Nullable<int> ViTriUngTuyen_id { get; set; }
        public Nullable<int> DonViUngTuyen_id { get; set; }
        public Nullable<System.DateTime> NgayNhanHS { get; set; }
		[StringLength(150)]
        public string NguonTuyenDung { get; set; }
        public string KinhNghiemLamViec { get; set; }
		[StringLength(15)]
        public string MucLuongYeuCau { get; set; }
        public Nullable<System.DateTime> NgayBatDauLamViec { get; set; }
        public Nullable<int> MucLuongTT { get; set; }
        public Nullable<System.DateTime> NgayBatDauLamViecTT { get; set; }
        public Nullable<int> SoNgayThuViec { get; set; }
		[StringLength(100)]
        public string ChucDanhTT { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("UngVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
    }
}
