using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class nvbhLaiTruyThuBH
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int iddmLaiSuatTruyThu { get; set; }
		[Required]
        public int iddmMucLuongToiThieuChung { get; set; }
		[Required]
        public int idnvbhNhanVienBHXH { get; set; }
		[Required]
        public int iddmTyLeDongBHXH { get; set; }
		[Required]
        public double TienLuongHoacChenhLechTienLuong { get; set; }
		[Required]
        public System.DateTime TuThangNam { get; set; }
		[Required]
        public System.DateTime DenThangNam { get; set; }
        public Nullable<int> SoThangTruyThu { get; set; }
        public Nullable<int> TongThoiGianChamDong { get; set; }
        public Nullable<double> TienLaiTruyThuBHXH { get; set; }
        public Nullable<double> TienLaiTruyThuBHTN { get; set; }
        public Nullable<double> TienLaiTruyThuBHYT { get; set; }
        public Nullable<double> TongCong { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }

		[ForeignKey("iddmLaiSuatTruyThu")]
        public virtual dmLaiSuatTruyThu dmLaiSuatTruyThu { get; set; }
		[ForeignKey("iddmMucLuongToiThieuChung")]
        public virtual dmMucLuongToiThieuChung dmMucLuongToiThieuChung { get; set; }
		[ForeignKey("iddmTyLeDongBHXH")]
        public virtual dmTyLeDongBHXH dmTyLeDongBHXH { get; set; }
		[ForeignKey("idnvbhNhanVienBHXH")]
        public virtual nvbhNhanVienBHXH nvbhNhanVienBHXH { get; set; }
    }
}
