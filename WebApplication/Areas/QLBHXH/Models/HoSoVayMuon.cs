using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class HoSoVayMuon
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int idGiayTo { get; set; }
		[Required]
        public int idKhoanVay { get; set; }
		[Required]
        public bool TrangThai { get; set; }
		[StringLength(100)]
        public string URLFile { get; set; }

		[ForeignKey("idGiayTo")]
        public virtual dmGiayTo dmGiayTo { get; set; }
		[ForeignKey("idKhoanVay")]
        public virtual KhoanVay KhoanVay { get; set; }
    }
}
