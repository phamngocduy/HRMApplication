using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsCTDoanTheTruoc
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
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(10)]
        public string maCongTacDoanThe { get; set; }
		[StringLength(50)]
        public string tenCongTacDoanThe { get; set; }
        public Nullable<int> sttCongTacDoanThe { get; set; }

    }
}
