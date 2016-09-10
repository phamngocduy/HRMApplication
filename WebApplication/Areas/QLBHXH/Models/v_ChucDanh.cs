using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class v_ChucDanh
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int idchucdanh { get; set; }
        public Nullable<int> NV_id { get; set; }
		[StringLength(200)]
        public string CVMoi { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
		[Required]
        public System.DateTime TuThangNam { get; set; }
		[StringLength(100)]
        public string HoVaTen { get; set; }
        public Nullable<int> SoBHXH { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> Nu { get; set; }
		[Required]
        public int idLoaiDieuChinh { get; set; }
		[Required]
        public int MoiNhat { get; set; }
		[StringLength(200)]
        public string CVCu { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
        public Nullable<System.DateTime> NgayPhatSinh { get; set; }

    }
}
