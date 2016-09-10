using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class tdNoiSinh
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int UngVien_id { get; set; }
        public Nullable<int> QuocGia_id { get; set; }
        public Nullable<int> TinhThanh_id { get; set; }

		[ForeignKey("UngVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
    }
}
