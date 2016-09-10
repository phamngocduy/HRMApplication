using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class tdDiaChiLienLac
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int TTLienHe_id { get; set; }
        public Nullable<int> llQuocGia_id { get; set; }
        public Nullable<int> llTinhThanh_id { get; set; }
        public Nullable<int> llQuanHuyen_id { get; set; }
        public Nullable<int> llPhuongXa_id { get; set; }
        public string llTenDuong { get; set; }

		[ForeignKey("TTLienHe_id")]
        public virtual tdThongTinLienHe tdThongTinLienHe { get; set; }
    }
}
