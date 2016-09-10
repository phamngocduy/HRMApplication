using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsQLHoSoHSL
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int HSL_id { get; set; }
        public Nullable<System.DateTime> BanTuNhanXet { get; set; }
        public Nullable<System.DateTime> BienBanHopDonVi { get; set; }
        public Nullable<System.DateTime> DeXuatTruongDonVi { get; set; }
		[Required]
        public bool HoanThanh { get; set; }
		[StringLength(4)]
        public string BacLuong { get; set; }
		[Required]
        public double HeSoLuong { get; set; }
		[Required]
        public int PhuCap { get; set; }
		[Required]
        public int ThoiGianGiuBac { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
        public Nullable<int> NV_id { get; set; }
        public Nullable<System.DateTime> HSL_ThoiGianDenHan { get; set; }
		[StringLength(4)]
        public string HSL_BacLuong { get; set; }
        public Nullable<double> HSL_HeSoLuong { get; set; }
        public Nullable<int> HSL_PhuCap { get; set; }
        public Nullable<int> NhomNgach_id { get; set; }
        public Nullable<int> Ngach_id { get; set; }
		[StringLength(10)]
        public string maNhomNgachVienChuc { get; set; }
		[StringLength(50)]
        public string tenNhomNgachVienChuc { get; set; }
		[StringLength(10)]
        public string maNgachVienChuc { get; set; }
		[StringLength(60)]
        public string tenNgachVienChuc { get; set; }

    }
}
