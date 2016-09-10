using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvTTThongKe
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
        public Nullable<int> PhanLoaiCBGVNV { get; set; }
        public Nullable<int> KhoaGiangDayChinh { get; set; }
        public Nullable<int> NganhGiangDayChinh { get; set; }

		[ForeignKey("KhoaGiangDayChinh")]
        public virtual dmKhoaGiangDay dmKhoaGiangDay { get; set; }
		[ForeignKey("NganhGiangDayChinh")]
        public virtual dmNganhGiangDay dmNganhGiangDay { get; set; }
		[ForeignKey("PhanLoaiCBGVNV")]
        public virtual dmPhanLoaiCBGVNV dmPhanLoaiCBGVNV { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
