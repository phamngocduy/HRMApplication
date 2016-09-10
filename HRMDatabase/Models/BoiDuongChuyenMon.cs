using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class BoiDuongChuyenMon
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int DonVi_id { get; set; }
		[Required]
		[StringLength(150)]
        public string TenTruong { get; set; }
        public Nullable<int> QuocGia_id { get; set; }
        public Nullable<int> NoiHoc_id { get; set; }
        public Nullable<System.DateTime> BatDau { get; set; }
        public Nullable<System.DateTime> HoanThanh { get; set; }
		[StringLength(20)]
        public string SoQD { get; set; }
        public Nullable<System.DateTime> NgayCapQD { get; set; }
        public Nullable<decimal> KinhPhi { get; set; }
		[StringLength(10)]
        public string GhiChu { get; set; }

		[ForeignKey("DonVi_id")]
        public virtual dmDonVi dmDonVi { get; set; }
		[ForeignKey("NoiHoc_id")]
        public virtual dmNoiHoc dmNoiHoc { get; set; }
		[ForeignKey("QuocGia_id")]
        public virtual dmQuocGia dmQuocGia { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
