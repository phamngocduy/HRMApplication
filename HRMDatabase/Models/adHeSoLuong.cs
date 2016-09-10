using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class adHeSoLuong
    {
        public Nullable<int> NV_id { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
		[Required]
        public int ThoiGianGiuBac { get; set; }
        public Nullable<int> NhomNgach_id { get; set; }
        public Nullable<int> Ngach_id { get; set; }
		[StringLength(4)]
        public string BacLuong { get; set; }
		[Required]
        public double HeSoLuong { get; set; }
		[Required]
        public int PhuCap { get; set; }
		[Required]
        public int id { get; set; }

    }
}
