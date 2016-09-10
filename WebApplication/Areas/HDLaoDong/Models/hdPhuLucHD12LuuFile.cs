using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class hdPhuLucHD12LuuFile
    {
		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(50)]
        public string LoaiPL { get; set; }
		[Required]
        public int HD_id { get; set; }
		[StringLength(100)]
        public string TenPL { get; set; }
		[Required]
        public System.DateTime NgaylapPL { get; set; }
		[Required]
        public byte[] FileAnh { get; set; }
		[Required]
		[StringLength(50)]
        public string MimeType { get; set; }
		[Required]
		[StringLength(50)]
        public string FileName { get; set; }
        public string Ghichu { get; set; }

		[ForeignKey("HD_id")]
        public virtual hdChiTietHDLD hdChiTietHDLD { get; set; }
    }
}
