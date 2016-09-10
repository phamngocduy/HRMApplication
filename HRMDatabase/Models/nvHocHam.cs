using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvHocHam
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int HocHam_id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }

		[ForeignKey("HocHam_id")]
        public virtual dmHocHam dmHocHam { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
