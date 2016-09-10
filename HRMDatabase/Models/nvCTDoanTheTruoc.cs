using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvCTDoanTheTruoc
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int CongTac_id { get; set; }
		[Required]
        public string ChucVu { get; set; }
		[Required]
        public string DonVi { get; set; }
		[Required]
		[StringLength(50)]
        public string NgayBatDau { get; set; }
		[StringLength(50)]
        public string NgayKetThuc { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("CongTac_id")]
        public virtual dmCongTacDoanThe dmCongTacDoanThe { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
