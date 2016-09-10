using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmTyLeDongBHXH
    {
        public dmTyLeDongBHXH()
        {
            this.nvbhLaiTruyThuBHs = new List<nvbhLaiTruyThuBH>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public System.DateTime NgayApDung { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
		[Required]
		[StringLength(10)]
        public string DoanhNghiepBHXH { get; set; }
		[Required]
		[StringLength(10)]
        public string NguoiLDBHXH { get; set; }
		[StringLength(10)]
        public string TongBHXH { get; set; }
		[Required]
		[StringLength(10)]
        public string DoanhNghiepBHYT { get; set; }
		[Required]
		[StringLength(10)]
        public string NguoiLDBHYT { get; set; }
		[StringLength(10)]
        public string TongBHYT { get; set; }
		[Required]
		[StringLength(10)]
        public string DoanhNghiepBHTN { get; set; }
		[Required]
		[StringLength(10)]
        public string NguoiLDBHTN { get; set; }
		[StringLength(10)]
        public string TongBHTN { get; set; }
		[StringLength(10)]
        public string TongCong { get; set; }
		[Required]
        public bool TrangThai { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<int> SoNgayConLai { get; set; }

        public virtual ICollection<nvbhLaiTruyThuBH> nvbhLaiTruyThuBHs { get; set; }
    }
}
