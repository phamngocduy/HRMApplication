using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmMucLuongToiThieuChung
    {
        public dmMucLuongToiThieuChung()
        {
            this.nvbhLaiTruyThuBHs = new List<nvbhLaiTruyThuBH>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
		[Required]
        public long MucLuong { get; set; }
		[Required]
        public bool TrangThai { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<int> SoNgayConLai { get; set; }

        public virtual ICollection<nvbhLaiTruyThuBH> nvbhLaiTruyThuBHs { get; set; }
    }
}
