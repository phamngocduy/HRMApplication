using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class tdBangCap
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int UngVien_id { get; set; }
        public Nullable<int> TrinhDo_id { get; set; }
        public Nullable<int> ChuyenNganh_id { get; set; }
		[StringLength(100)]
        public string NoiDaoTao { get; set; }
        public Nullable<int> NamTotNghiep { get; set; }
        public Nullable<int> XepLoai_id { get; set; }
		[Required]
        public bool SetDefault { get; set; }

		[ForeignKey("UngVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
    }
}
