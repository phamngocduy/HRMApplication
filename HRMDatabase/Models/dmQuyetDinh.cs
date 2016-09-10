using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmQuyetDinh
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int LoaiQuyetDinh_id { get; set; }
		[Required]
		[StringLength(30)]
        public string MaQuyetDinh { get; set; }
		[Required]
        public System.DateTime NgayKy { get; set; }
        public Nullable<System.DateTime> NgayApDung { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public string TepDinhKem { get; set; }

		[ForeignKey("LoaiQuyetDinh_id")]
        public virtual dmLoaiQuyetDinh dmLoaiQuyetDinh { get; set; }
    }
}
