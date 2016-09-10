using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class DanhHieu
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int TenDanhHieu_id { get; set; }
		[Required]
        public System.DateTime NgayDatDanhHieu { get; set; }
		[Required]
		[StringLength(50)]
        public string SoQDCongNhan { get; set; }
		[Required]
		[StringLength(50)]
        public string NoiCap { get; set; }
		[StringLength(50)]
        public string GhiChu { get; set; }

		[ForeignKey("TenDanhHieu_id")]
        public virtual dmDanhHieu dmDanhHieu { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
