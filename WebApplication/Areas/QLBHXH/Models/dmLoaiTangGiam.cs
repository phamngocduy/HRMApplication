using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmLoaiTangGiam
    {
		[Required]
        public int id { get; set; }
		[StringLength(10)]
        public string Ma { get; set; }
		[StringLength(100)]
        public string LoaiTangGiam { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<int> idLoaiDieuChinh { get; set; }

		[ForeignKey("idLoaiDieuChinh")]
        public virtual dmLoaiDieuChinh dmLoaiDieuChinh { get; set; }
    }
}
