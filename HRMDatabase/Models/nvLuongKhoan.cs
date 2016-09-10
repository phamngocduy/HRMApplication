using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvLuongKhoan
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public System.DateTime BatDau { get; set; }
        public Nullable<System.DateTime> KetThuc { get; set; }
        public Nullable<int> SoTien { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
