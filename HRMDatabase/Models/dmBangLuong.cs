using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmBangLuong
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int stt { get; set; }
		[Required]
        public int idNhomNgach { get; set; }
		[Required]
		[StringLength(5)]
        public string bacLuong { get; set; }
		[Required]
        public double hesoLuong { get; set; }
		[Required]
        public int phuCap { get; set; }
		[Required]
        public int soThang { get; set; }

		[ForeignKey("idNhomNgach")]
        public virtual dmNhomNgachVienChuc dmNhomNgachVienChuc { get; set; }
    }
}
