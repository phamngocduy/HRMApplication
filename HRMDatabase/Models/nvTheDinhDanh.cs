using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvTheDinhDanh
    {
        public nvTheDinhDanh()
        {
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int LoaiThe_id { get; set; }
		[Required]
		[StringLength(30)]
        public string SoThe { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public Nullable<int> NoiCap_id { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }

		[ForeignKey("LoaiThe_id")]
        public virtual dmLoaiTheDinhDanh dmLoaiTheDinhDanh { get; set; }
		[ForeignKey("NoiCap_id")]
        public virtual dmTinhThanh dmTinhThanh { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
    }
}
