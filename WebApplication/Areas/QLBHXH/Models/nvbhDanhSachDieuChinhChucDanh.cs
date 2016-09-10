using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class nvbhDanhSachDieuChinhChucDanh
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> idLoaiDieuChinh { get; set; }
        public Nullable<int> idnvbhNhanVienBHXH { get; set; }
        public Nullable<System.DateTime> NgayPhatSinh { get; set; }
		[StringLength(200)]
        public string ChucVuCu { get; set; }
		[StringLength(200)]
        public string ChucVuMoi { get; set; }
        public Nullable<System.DateTime> TuThangNam { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }

		[ForeignKey("idLoaiDieuChinh")]
        public virtual dmLoaiDieuChinh dmLoaiDieuChinh { get; set; }
		[ForeignKey("idnvbhNhanVienBHXH")]
        public virtual nvbhNhanVienBHXH nvbhNhanVienBHXH { get; set; }
    }
}
