using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQTNghiNganHan
    {
        public nvQTNghiNganHan()
        {
            this.nvGiuBacLuongs = new List<nvGiuBacLuong>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int CT_id { get; set; }
		[Required]
        public int LoaiNghi_id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
		[StringLength(20)]
        public string SoQuyetDinh { get; set; }
		[StringLength(150)]
        public string GhiChu { get; set; }

		[ForeignKey("LoaiNghi_id")]
        public virtual dmLoaiNghiNganHan dmLoaiNghiNganHan { get; set; }
        public virtual ICollection<nvGiuBacLuong> nvGiuBacLuongs { get; set; }
		[ForeignKey("CT_id")]
        public virtual nvQTLamViec CongTac { get; set; }
    }
}
