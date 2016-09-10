using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class tdQuaTrinhTuyenDung
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int UngVien_id { get; set; }
        public Nullable<int> QuanLyLH_id { get; set; }
        public Nullable<System.DateTime> NgayPhongVanGiangThu { get; set; }
        public Nullable<int> DonViPhongVan { get; set; }
		[StringLength(100)]
        public string HinhThucPhongVan { get; set; }
        public string NhanXet { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("UngVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
		[ForeignKey("QuanLyLH_id")]
        public virtual tdXemVaXepLichHen tdXemVaXepLichHen { get; set; }
    }
}
