using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class HoanVay
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> idKhoanVay { get; set; }
		[Required]
		[StringLength(10)]
        public string SoChungTu { get; set; }
		[Required]
        public System.DateTime NgayChungTu { get; set; }
		[Required]
		[StringLength(200)]
        public string DienGiai { get; set; }
		[Required]
        public long SoTienHoan { get; set; }
		[Required]
        public long SoTienLai { get; set; }
		[StringLength(10)]
        public string MaNV { get; set; }
		[Required]
        public bool TrangThai { get; set; }
        public Nullable<int> IdNV { get; set; }

		[ForeignKey("idKhoanVay")]
        public virtual KhoanVay KhoanVay { get; set; }
    }
}
