using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvCTDoanThe
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
        public Nullable<System.DateTime> NgayVaoDuBi { get; set; }
        public Nullable<System.DateTime> NgayVaoChinhThuc { get; set; }
		[StringLength(100)]
        public string NoiKetNap { get; set; }
		[StringLength(50)]
        public string ChiBo { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
		[Required]
        public int ChucVu_id { get; set; }
        public string DonVi { get; set; }

		[ForeignKey("ChucVu_id")]
        public virtual dmChucVuDoanThe dmChucVuDoanThe { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
