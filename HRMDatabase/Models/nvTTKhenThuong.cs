using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvTTKhenThuong
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public System.DateTime NgayQuyetDinh { get; set; }
		[StringLength(20)]
        public string SoQuyetDinh { get; set; }
        public Nullable<int> HinhThuc_id { get; set; }
		[Required]
        public string CapKhenThuong { get; set; }
		[Required]
        public string NoiDungKhenThuong { get; set; }
		[StringLength(50)]
        public string MucKhenThuong { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("HinhThuc_id")]
        public virtual dmHinhThucKhenThuong dmHinhThucKhenThuong { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
