using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class hdCauHinh
    {
		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(50)]
        public string HotenNSDLD { get; set; }
		[Required]
        public int Quoctich_id { get; set; }
		[Required]
        public int Chucvu_id { get; set; }
		[Required]
		[StringLength(100)]
        public string Coquan { get; set; }
		[Required]
        public string Diachi { get; set; }
		[Required]
		[StringLength(50)]
        public string SDT { get; set; }
		[Required]
		[StringLength(15)]
        public string Mucluongchinh { get; set; }
		[Required]
		[StringLength(15)]
        public string Cosotienluong { get; set; }
		[Required]
        public string DiadiemLV { get; set; }
		[Required]
        public int NgayHDTV { get; set; }
		[Required]
        public int NgayHDCT { get; set; }
		[Required]
        public int Gioitinh_id { get; set; }
		[Required]
		[StringLength(15)]
        public string MLTTChung1 { get; set; }
		[Required]
		[StringLength(15)]
        public string MLTTChung2 { get; set; }

    }
}
