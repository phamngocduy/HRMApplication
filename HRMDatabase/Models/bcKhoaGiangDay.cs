using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class bcKhoaGiangDay
    {
		[Required]
        public int id { get; set; }
		[Required]
        public System.DateTime NgayBC { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int Chinh_id { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
		[ForeignKey("Chinh_id")]
        public virtual nvNganhGiangDay nvNganhGiangDay { get; set; }
    }
}
