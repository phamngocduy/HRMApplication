using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLThinhGiang.Models
{
    public partial class dsQHGiaDinh
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
		[StringLength(50)]
        public string HoTen { get; set; }
        public Nullable<int> NgaySinh { get; set; }
		[Required]
        public int QuanHe_id { get; set; }
		[StringLength(100)]
        public string DiaChi { get; set; }
        public string NgheNghiep { get; set; }
		[StringLength(20)]
        public string MaSoThue { get; set; }
        public string CoQuan { get; set; }
		[StringLength(20)]
        public string tenMoiQuanHe { get; set; }

    }
}
