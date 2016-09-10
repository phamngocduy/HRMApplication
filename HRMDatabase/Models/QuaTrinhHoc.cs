using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class QuaTrinhHoc
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[StringLength(50)]
        public string BacHoc { get; set; }
		[StringLength(150)]
        public string TruongHoc { get; set; }
        public Nullable<int> NamBatDau { get; set; }
        public Nullable<int> NamKetThuc { get; set; }
		[StringLength(150)]
        public string GhiChu { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
