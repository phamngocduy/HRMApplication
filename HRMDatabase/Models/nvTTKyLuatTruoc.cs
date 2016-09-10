using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvTTKyLuatTruoc
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[StringLength(20)]
        public string SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> NgayQuyetDinh { get; set; }
		[StringLength(50)]
        public string CapQuyetDinh { get; set; }
		[StringLength(100)]
        public string NoiCapQuyetDinh { get; set; }
		[Required]
		[StringLength(100)]
        public string LyDoKyLuat { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
