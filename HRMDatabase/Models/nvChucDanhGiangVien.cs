using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvChucDanhGiangVien
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int ChucDanh_id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }

		[ForeignKey("ChucDanh_id")]
        public virtual dmChucDanhGiangVien dmChucDanhGiangVien { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
