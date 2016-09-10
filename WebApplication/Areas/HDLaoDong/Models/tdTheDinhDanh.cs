using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class tdTheDinhDanh
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int UngVien_id { get; set; }
		[Required]
        public int LoaiThe_id { get; set; }
		[Required]
		[StringLength(30)]
        public string SoThe { get; set; }
		[Required]
        public System.DateTime NgayCap { get; set; }
		[Required]
        public int NoiCap_id { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }

		[ForeignKey("LoaiThe_id")]
        public virtual tdLoaiTheDinhDanh tdLoaiTheDinhDanh { get; set; }
		[ForeignKey("UngVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
    }
}
