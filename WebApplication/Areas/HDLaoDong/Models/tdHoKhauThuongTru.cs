using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class tdHoKhauThuongTru
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int TTLienHe_id { get; set; }
        public Nullable<int> hkQuocGia_id { get; set; }
        public Nullable<int> hkTinhThanh_id { get; set; }
        public Nullable<int> hkQuanHuyen_id { get; set; }
        public Nullable<int> hkPhuongXa_id { get; set; }
        public string hkTenDuong { get; set; }

		[ForeignKey("TTLienHe_id")]
        public virtual tdThongTinLienHe tdThongTinLienHe { get; set; }
    }
}
