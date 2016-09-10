using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLThinhGiang.Models
{
    public partial class dsNhanVien
    {
		[Required]
        public int id { get; set; }
		[StringLength(10)]
        public string MaHS { get; set; }
		[StringLength(10)]
        public string MaTV { get; set; }
		[Required]
		[StringLength(10)]
        public string MaNV { get; set; }
		[Required]
        public bool laNVMoi { get; set; }
        public Nullable<System.DateTime> ngayNghiViec { get; set; }
		[StringLength(20)]
        public string ttlhDTNhaRieng { get; set; }
		[StringLength(20)]
        public string ttlhDTDiDong { get; set; }
		[StringLength(50)]
        public string ttlhEmailTruong { get; set; }
		[StringLength(100)]
        public string ttlhEmailKhac { get; set; }
        public Nullable<int> ttlhDCTamTruKT3_id { get; set; }
		[Required]
        public int qtlvThamNienGiangDayT { get; set; }
        public Nullable<int> qtlvCongTac_id { get; set; }
        public Nullable<int> qltlHeSoLuong_id { get; set; }
		[StringLength(20)]
        public string qtlvSoQDNghiViec { get; set; }
        public Nullable<int> nvNganhGiangDay_id { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(100)]
        public string tenDonVi { get; set; }

    }
}
