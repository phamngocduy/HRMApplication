using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class ChungChi
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int LoaiChungChi_id { get; set; }
        public string Capdo { get; set; }
		[Required]
        public string NoiCap { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
		[StringLength(50)]
        public string HieuLuc { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> SauKhiVeTruong { get; set; }
        public Nullable<int> HoTro { get; set; }

		[ForeignKey("LoaiChungChi_id")]
        public virtual dmLoaiChungChi dmLoaichungchi { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
		[ForeignKey("HoTro")]
        public virtual nvQTChungChi nvQTChungChi { get; set; }
    }
}
