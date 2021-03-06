using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvTTMoRong
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int ThamNienGiangDay_Truoc { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
