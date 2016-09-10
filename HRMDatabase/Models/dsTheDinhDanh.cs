using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
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
        public string HoVaTen { get; set; }
		[StringLength(10)]
        public string maLoaiTheDinhDanh { get; set; }
		[StringLength(50)]
        public string tenLoaiTheDinhDanh { get; set; }
        public Nullable<int> sttLoaiTheDinhDanh { get; set; }
		[StringLength(10)]
        public string maTinhThanh { get; set; }
		[StringLength(50)]
        public string tenTinhThanh { get; set; }
        public Nullable<int> sttTinhThanh { get; set; }

    }
}
