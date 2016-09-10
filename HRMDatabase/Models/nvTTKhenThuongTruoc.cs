using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvTTKhenThuongTruoc
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[StringLength(50)]
        public string ThangNamKhenThuong { get; set; }
		[Required]
        public string NoiDungKhenThuong { get; set; }
		[Required]
        public string NoiCapQuyetDinh { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
