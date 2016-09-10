using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQTLamViecTruoc
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public string DonViCongTac { get; set; }
        public string ChucDanhChucVu { get; set; }
		[StringLength(50)]
        public string ThoiGianBatDau { get; set; }
		[StringLength(50)]
        public string ThoiGianKetThuc { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
