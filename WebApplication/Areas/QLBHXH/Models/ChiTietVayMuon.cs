using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class ChiTietVayMuon
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> idVm { get; set; }
        public Nullable<int> IdNhanVienVayMuon { get; set; }
		[Required]
        public System.DateTime NgayChungTu { get; set; }
		[StringLength(10)]
        public string SoChungTu { get; set; }
		[StringLength(200)]
        public string DienGiai { get; set; }
        public Nullable<int> MucDichSuDung { get; set; }
        public Nullable<bool> Dinhmuc { get; set; }
        public Nullable<long> SoTienVay { get; set; }
        public Nullable<long> SotienHoan { get; set; }
        public Nullable<long> SotienLai { get; set; }
        public Nullable<int> idvay { get; set; }
        public Nullable<int> idhoan { get; set; }

		[ForeignKey("MucDichSuDung")]
        public virtual dmMucDichSuDung dmMucDichSuDung { get; set; }
    }
}
