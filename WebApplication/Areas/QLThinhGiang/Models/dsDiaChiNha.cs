using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLThinhGiang.Models
{
    public partial class dsDiaChiNha
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> PhuongXa_id { get; set; }
        public Nullable<int> QuanHuyen_id { get; set; }
        public Nullable<int> TinhThanh_id { get; set; }
		[StringLength(50)]
        public string tenPhuongXa { get; set; }
		[StringLength(50)]
        public string tenQuanHuyen { get; set; }
		[StringLength(50)]
        public string tenTinhThanh { get; set; }

    }
}
