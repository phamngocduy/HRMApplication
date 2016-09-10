using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQLTapSu
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int CT_id { get; set; }
        public Nullable<System.DateTime> ThoiGianDenHan { get; set; }
        public Nullable<System.DateTime> NgayThongBao { get; set; }
        public Nullable<System.DateTime> NgayNhanHoSo { get; set; }
        public Nullable<System.DateTime> NgayLapToTrinh { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("CT_id")]
        public virtual nvQTLamViec CongTac { get; set; }
    }
}
