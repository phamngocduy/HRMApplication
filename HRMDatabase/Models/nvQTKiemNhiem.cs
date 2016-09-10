using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQTKiemNhiem
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public System.DateTime ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
		[Required]
        public int DonVi_id { get; set; }
        public string CongViec { get; set; }
		[StringLength(50)]
        public string PhuCap { get; set; }
		[StringLength(100)]
        public string GhiChu { get; set; }

		[ForeignKey("DonVi_id")]
        public virtual dmDonVi dmDonVi { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
