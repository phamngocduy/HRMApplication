using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsNganhGiangDay
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int NganhGiangDay { get; set; }
		[Required]
        public System.DateTime ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
		[Required]
        public int KhoaGiangDay { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[Required]
        public int idNganhGiangDay { get; set; }
		[Required]
        public int idKhoaGiangDay { get; set; }
		[StringLength(10)]
        public string maNganhGiangDay { get; set; }
		[StringLength(50)]
        public string tenNganhGiangDay { get; set; }
        public Nullable<int> sttNganhGiangDay { get; set; }
		[StringLength(10)]
        public string maKhoaGiangDay { get; set; }
		[StringLength(100)]
        public string tenKhoaGiangDay { get; set; }
        public Nullable<int> sttKhoaGiangDay { get; set; }
        public Nullable<int> LaChinh { get; set; }

    }
}
