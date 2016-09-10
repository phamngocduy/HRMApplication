using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsHocHam1
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int HocHam_id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(10)]
        public string maHocHam { get; set; }
		[StringLength(50)]
        public string tenHocHam { get; set; }
        public Nullable<byte> doUuTien { get; set; }
        public Nullable<int> sttHocHam { get; set; }
        public Nullable<long> stt { get; set; }

    }
}
