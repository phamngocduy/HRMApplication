using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsDienBienLuong
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
		[Required]
        public int ThoiGianGiuBac { get; set; }
        public Nullable<int> NhomNgach_id { get; set; }
        public Nullable<int> Ngach_id { get; set; }
		[StringLength(4)]
        public string BacLuong { get; set; }
		[Required]
        public double HeSoLuong { get; set; }
		[Required]
        public int PhuCap { get; set; }
		[StringLength(50)]
        public string LyDoThayDoi { get; set; }
		[Required]
        public int User_id { get; set; }
		[StringLength(50)]
        public string GhiChu { get; set; }
		[StringLength(20)]
        public string SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> KetThucDuKien { get; set; }
		[StringLength(10)]
        public string maNhomNgachVienChuc { get; set; }
		[StringLength(50)]
        public string tenNhomNgachVienChuc { get; set; }
		[StringLength(10)]
        public string maNgachVienChuc { get; set; }
		[StringLength(60)]
        public string tenNgachVienChuc { get; set; }
        public Nullable<int> G_id { get; set; }
        public Nullable<int> G_SoThangThayDoi { get; set; }
		[StringLength(50)]
        public string G_SoQuyetDinh { get; set; }
		[StringLength(50)]
        public string G_LyDoThayDoi { get; set; }
		[StringLength(50)]
        public string G_tenLoaiThayDoi { get; set; }
		[Required]
        public int HienTai { get; set; }

    }
}
