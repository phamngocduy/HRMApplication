using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsChucDanhGiangVien
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int ChucDanh_id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(10)]
        public string maChucDanhGiangVien { get; set; }
		[StringLength(50)]
        public string tenChucDanhGiangVien { get; set; }
        public Nullable<byte> doUuTien { get; set; }
        public Nullable<int> sttChucDanhGiangVien { get; set; }

    }
}
