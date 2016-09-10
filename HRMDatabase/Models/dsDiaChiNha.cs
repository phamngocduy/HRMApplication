using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
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
        public string HoVaTen { get; set; }
        public Nullable<int> sttPhuongXa { get; set; }
		[StringLength(10)]
        public string maPhuongXa { get; set; }
		[StringLength(50)]
        public string tenPhuongXa { get; set; }
        public Nullable<int> sttQuanHuyen { get; set; }
		[StringLength(10)]
        public string maQuanHuyen { get; set; }
		[StringLength(50)]
        public string tenQuanHuyen { get; set; }
        public Nullable<int> sttTinhThanh { get; set; }
		[StringLength(10)]
        public string maTinhThanh { get; set; }
		[StringLength(50)]
        public string tenTinhThanh { get; set; }

    }
}
