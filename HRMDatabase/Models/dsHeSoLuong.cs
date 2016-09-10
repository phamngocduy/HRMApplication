using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsHeSoLuong
    {
        public Nullable<int> id { get; set; }
        public Nullable<int> NV_id { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<int> ThoiGianGiuBac { get; set; }
        public Nullable<int> NhomNgach_id { get; set; }
        public Nullable<int> Ngach_id { get; set; }
		[StringLength(4)]
        public string BacLuong { get; set; }
        public Nullable<double> HeSoLuong { get; set; }
        public Nullable<int> PhuCap { get; set; }
		[StringLength(50)]
        public string LyDoThayDoi { get; set; }
        public Nullable<int> User_id { get; set; }
		[StringLength(50)]
        public string GhiChu { get; set; }
		[StringLength(20)]
        public string SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> ThoiGianDenHan { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[Required]
        public int N_id { get; set; }
		[StringLength(100)]
        public string tenDonVi { get; set; }
		[StringLength(10)]
        public string maDonVi { get; set; }
		[StringLength(10)]
        public string maChucDanh { get; set; }
		[StringLength(50)]
        public string tenChucDanh { get; set; }
        public Nullable<System.DateTime> ngayNghiViec { get; set; }

    }
}
