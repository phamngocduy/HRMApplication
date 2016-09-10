using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvCTNganHan
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int CT_id { get; set; }
		[Required]
        public int NV_id { get; set; }
        public Nullable<int> KinhPhi { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("CT_id")]
        public virtual CTNganHan CongTac { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
