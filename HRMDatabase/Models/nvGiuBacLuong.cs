using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvGiuBacLuong
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int HSL_id { get; set; }
		[Required]
        public int SoThangThayDoi { get; set; }
		[StringLength(50)]
        public string SoQuyetDinh { get; set; }
		[StringLength(50)]
        public string LyDoThayDoi { get; set; }
		[Required]
        public int LoaiThayDoi_id { get; set; }
        public Nullable<int> NghiKL_id { get; set; }

		[ForeignKey("LoaiThayDoi_id")]
        public virtual dmLoaiBaoLuuHSL LoaiBaoLuu { get; set; }
		[ForeignKey("HSL_id")]
        public virtual nvHeSoLuong HeSoLuong { get; set; }
		[ForeignKey("NghiKL_id")]
        public virtual nvQTNghiNganHan nvQLNghiViec { get; set; }
    }
}
