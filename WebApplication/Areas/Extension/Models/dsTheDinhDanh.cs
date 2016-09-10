using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Extension.Databases.Models
{
    public partial class dsTheDinhDanh
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int LoaiThe_id { get; set; }
		[Required]
		[StringLength(30)]
        public string SoThe { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public Nullable<int> NoiCap_id { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
		[StringLength(50)]
        public string tenLoaiTheDinhDanh { get; set; }
		[StringLength(50)]
        public string tenTinhThanh { get; set; }

    }
}
