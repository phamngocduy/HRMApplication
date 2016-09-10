using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvTrangThaiLuong
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
        public Nullable<int> HocHam_id { get; set; }
        public Nullable<int> HocVi_id { get; set; }
        public Nullable<int> ChucDanh_id { get; set; }
        public Nullable<int> ChucDanhChucVu_id { get; set; }
        public Nullable<int> NgheNghiep_id { get; set; }

		[ForeignKey("ChucDanh_id")]
        public virtual dmChucDanh ChucDanh { get; set; }
		[ForeignKey("ChucDanhChucVu_id")]
        public virtual dmChucDanhChuyenMon dmChucDanhChuyenMon { get; set; }
		[ForeignKey("HocHam_id")]
        public virtual dmHocHam HocHam { get; set; }
		[ForeignKey("HocVi_id")]
        public virtual dmHocVi HocVi { get; set; }
		[ForeignKey("NgheNghiep_id")]
        public virtual dmNgheNghiep NgheNghiep { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
